/*
 * recordtest.c
 *
 *  Created on: Sep 13, 2017
 *      Author: eddyxd
 */

#include <audio_io.h>
#include <recordtest.h>


#define BUFLEN 512
#define SAMPLE_RATE 48000
#define RECORDING_SEC 5 /* Defines how many seconds will the recording last. */
/* Defines recording frequency as 0.1 second, it means recording happens for a data of 0.1 second every time */
#define MIN_RECORDING_INTERVAL  0.1
/* Defines minimum buffer size for playback or recording for 0.1 second */
/* Buffer size for 1 second = SAMPLE_RATE * 2(Num of Channels) * 2 (16 bit data) */
#define MIN_BUFFER_SIZE 19200
#define MIN_2BYTES_SIGNED (-32768)
#define MAX_2BYTES_SIGNED 32767

static audio_in_h g_input = NULL;  /* Audio input handle declaration */
static audio_out_h g_output = NULL; /* Audio output handle declaration */
static void *g_buffer = NULL;  /* Buffer used for audio recording/playback */
static int g_buffer_size;  /* Size of the buffer used for audio recording/playback */
static FILE *g_fp_w = NULL;  /* File used for asynchronous audio recording */
static FILE *g_fp_r = NULL;  /* File used for asynchronous audio playback */

static char *g_sounds_directory = NULL;
static char g_audio_io_file_path[BUFLEN];

static sound_stream_info_h g_stream_info_h = NULL;
static bool g_focus_cb_invoked_sync_record = false;
static bool g_focus_cb_invoked_sync_playback = false;
static bool g_focus_cb_invoked_async_record = false;
static bool g_focus_cb_invoked_async_playback = false;
static current_state_e g_current_state;


/**
 * @brief Called when the state of focus that belongs to the stream_info is changed.
 * @details This function is issued in the internal thread of the sound manager.\n
 * Therefore it is recommended not to call UI update function in this function.
 *
 * @param[in]   stream_info     The handle of stream information
 * @param[in]   focus_mask      The changed focus mask
 * @param[in]   focus_state     The changed focus state
 * @param[in]   reason          The reason for state change of the focus
 * @param[in]   sound_behavior  The requested sound behavior that should be followed, values of #sound_behavior_e combined with bitwise 'or'
 * @param[in]   extra_info      The extra information
 * @param[in]   user_data       The user data passed from the callback registration function
 */
static void __focus_callback_audioio(sound_stream_info_h stream_info,
                            sound_stream_focus_mask_e focus_mask,
                            sound_stream_focus_state_e focus_state,
                            sound_stream_focus_change_reason_e reason,
                            int sound_behavior,
                            const char *extra_info,
                            void *user_data)
{
    PRINT_MSG("\n*** FOCUS callback is called  ***\n");
    PRINT_MSG(" -changed focus sate(%d)\n", focus_state);
    PRINT_MSG("(0:released, 1:acquired)\n");
    PRINT_MSG(" - extra information\n");
    PRINT_MSG("(%s)\n", extra_info);

    switch (g_current_state) {
    case SYNC_RECORD:
        PRINT_MSG("\n*** SYNC_RECORD happening ***\n");
        g_focus_cb_invoked_sync_record = true;
        break;
    case SYNC_PLAYBACK:
        PRINT_MSG("\n*** SYNC_PLAYBACK happening ***\n");
        g_focus_cb_invoked_sync_playback = true;
        break;
    case ASYNC_RECORD:
        PRINT_MSG("\n*** ASYNC_RECORD happening ***\n");
        g_focus_cb_invoked_async_record = true;
        PRINT_MSG("\n*** Focus lost <br>Stop Asynchronous Recording ***\n");
        break;
    case ASYNC_PLAYBACK:
        PRINT_MSG("\n*** ASYNC_PLAYBACK happening ***\n");
        g_focus_cb_invoked_async_playback = true;
        PRINT_MSG("\n*** Focus lost <br>Stop Asynchronous Playback ***\n");
        break;
    default:
        PRINT_MSG("\n*** state is NONE ***\n");
    }

    g_current_state = NONE;
    return;

 }

/**
 * @brief Gets the ID of the internal storage.
 * @details It assigns the ID of the internal storage to the variable passed
 *          as the user data to the callback.
 *          This callback is called for every storage supported by the device.
 * @remarks This function matches the storage_device_supported_cb() signature
 *          defined in the storage-expand.h header file.
 *
 * @param storage_id  The unique ID of the detected storage
 * @param type        The type of the detected storage
 * @param state       The current state of the detected storage.
 *                    This argument is not used in this case.
 * @param path        The absolute path to the root directory of the detected
 *                    storage. This argument is not used in this case.
 * @param user_data   The user data passed via void pointer
 *
 * @return @c true to continue iterating over supported storages, @c false to
 *         stop the iteration.
 */
static bool _storage_cb(int storage_id, storage_type_e type,
                        storage_state_e state, const char *path,
                        void *user_data)
{
    if (STORAGE_TYPE_INTERNAL == type) {
        int *internal_storage_id = (int *) user_data;

        if (NULL != internal_storage_id)
            *internal_storage_id = storage_id;

        /* Internal storage found, stop the iteration. */
        return false;
    } else {
        /* Continue iterating over storages. */
        return true;
    }
}

/**
 * @brief Prepare path for the file.
 */
static void __prepare_path_to_file(void)
{
    int error_code = AUDIO_IO_ERROR_NONE;
    int internal_storage_id;
    static const char *g_audio_io_file_name = "pcm_w.raw";

    /* Get the path to the Sounds directory: */

    /* 1. Get internal storage id. */
    internal_storage_id = -1;

    error_code = storage_foreach_device_supported(_storage_cb,
            &internal_storage_id);
    CHECK_ERROR_AND_RETURN("storage_foreach_device_supported", error_code);

    /* 2. Get the path to the Sounds directory. */
    error_code = storage_get_directory(internal_storage_id,
            STORAGE_DIRECTORY_SOUNDS, &g_sounds_directory);
    CHECK_ERROR_AND_RETURN("storage_get_directory", error_code);

    /* Prepare a path to the file used for asynchronous playback. */
    snprintf(g_audio_io_file_path, BUFLEN, "%s/%s", g_sounds_directory,
            g_audio_io_file_name);
}

/**
 * @brief Initialization function for audio device module.
 */
static void __audio_device_init(void)
{
    int error_code = AUDIO_IO_ERROR_NONE;

    /* Audio input device initialization. */
    error_code = audio_in_create(SAMPLE_RATE, AUDIO_CHANNEL_STEREO,
            AUDIO_SAMPLE_TYPE_S16_LE, &g_input);
    CHECK_ERROR_AND_RETURN("audio_in_create", error_code);

    /* Audio output device initialization. */
    error_code = audio_out_create_new(SAMPLE_RATE, AUDIO_CHANNEL_STEREO,
            AUDIO_SAMPLE_TYPE_S16_LE, &g_output);
    CHECK_ERROR_AND_RETURN("audio_out_create", error_code);

    /*
     * Buffer size for 1 sec is equals to  sample rate * num of channel * num of bytes per sample
     * Buffer size for mentioned RECORDING_SEC
     */
    g_buffer_size = SAMPLE_RATE * 2 * 2 * RECORDING_SEC;

    /* Allocate the memory for the buffer used for recording/playback. */
    g_buffer = malloc(g_buffer_size);
}


/**
 * @brief Initialization function for data module.
 */
void data_initialize(void)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "data_initialize");
    int error_code = SOUND_MANAGER_ERROR_NONE;
    static sound_stream_type_e sound_stream_type = SOUND_STREAM_TYPE_MEDIA;
    /*
     * If you need to initialize application data,
     * please use this function.
     */

    /* Create the sound stream information handle and registers the focus state changed callback function. */
    /*
    error_code = sound_manager_create_stream_information(sound_stream_type, __focus_callback_audioio, NULL, &g_stream_info_h);
    if (SOUND_MANAGER_ERROR_NONE != error_code)
        dlog_print(DLOG_ERROR, LOG_TAG, "sound_manager_create_stream_information() failed! Error code = 0x%x", error_code);
	*/

    /* Focus callback invoke is not needed after stopping the tone player. */
    /*
    error_code = sound_manager_set_focus_reacquisition(g_stream_info_h, false);
    if (SOUND_MANAGER_ERROR_NONE != error_code)
        dlog_print(DLOG_ERROR, LOG_TAG, "sound_manager_set_focus_reacquisition() failed! Error code = 0x%x", error_code);
    g_current_state = NONE;
    */

    /* Initialize audio device input and output handles. */
    __audio_device_init();

    /* Prepare path to file. */
    //__prepare_path_to_file();
}

/**
 * @brief Finalization function for data module.
 */
void data_finalize(void)
{
    int error_code = SOUND_MANAGER_ERROR_NONE;

    /*
     * If you need to finalize application data,
     * please use this function.
     */
    /* Release the memory allocated for the buffer used for recording/playing. */
    if (g_buffer !=  NULL)
        free(g_buffer);

    /* Stop the hardware recording process. */
    audio_in_unprepare(g_input);

    /* Unset the callback function used for asynchronous recording process. */
    audio_in_unset_stream_cb(g_input);

    /* Deinitialize audio input device. */
    audio_in_destroy(g_input);

    /* Stop the hardware playback process. */
    audio_out_unprepare(g_output);

    /* Unset the callback function used for asynchronous playback process. */
    audio_out_unset_stream_cb(g_output);

    /* Deinitialize audio output device. */
    audio_out_destroy(g_output);

    /* Free the Sounds directory path. */
    free(g_sounds_directory);

    /* Free the stream information handle which was created at application view creation. */
    error_code = sound_manager_destroy_stream_information(g_stream_info_h);
    if (SOUND_MANAGER_ERROR_NONE != error_code) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sound_manager_destroy_stream_information() failed! Error code = 0x%x", error_code);
    }
}

/**
 * @brief Called when the audio out data can be written in the asynchronous (event)
 *        mode.
 * @details This callback function is invoked for every stored part of the
 *          audio.
 * @remarks This function matches the audio_out_stream_cb() signature defined in
 *          the audio_io.h header file.
 *
 * @param handle      The handle to the audio output
 * @param nbytes      The amount of audio in data which can be written
 * @param user_data   The user data passed from the callback registration
 *                    function. This argument is not used in this case.
 */
static void _audio_io_stream_write_cb(audio_out_h handle, size_t nbytes,
                                      void *user_data)
{
    char *buff = NULL;
    int bytes_written = 0;

    /* Stream focus is lost and callback is invoked */
    if (g_focus_cb_invoked_async_playback)
        return;

    if (nbytes > 0) {
        buff = malloc(nbytes);
        memset(buff, 0, nbytes);

        /* Play the following part of the recording. */
        fread(buff, sizeof(char), nbytes, g_fp_r);

        /* Copy the recorded data from the buffer to the output buffer. */
        bytes_written = audio_out_write(handle, buff, nbytes);

        if (bytes_written < 0)
            DLOG_PRINT_ERROR("audio_out_write", bytes_written);

        free(buff);
    }
}


/**
 * @brief Called when the audio input data is available in the asynchronous (event)
 *        mode.
 * @details This callback is invoked for every captured part of the recording.
 * @remarks This function matches the audio_in_stream_cb() signature defined in
 *          the audio_io.h header file.
 *
 * @param handle      The handle to the audio input
 * @param nbytes      The amount of available audio in data which can be peeked.
 * @param user_data   The user data passed from the callback registration
 *                    function. This argument is not used in this case.
 */
static void _audio_io_stream_read_cb(audio_in_h handle, size_t nbytes,
                                     void *user_data)
{
    const void *buff = NULL;
    int error_code = AUDIO_IO_ERROR_NONE;

    /* Stream focus is lost and callback is invoked */
    if (g_focus_cb_invoked_async_record)
        return;

    if (nbytes > 0) {
        /* Retrieve buffer pointer from audio in buffer */
        error_code = audio_in_peek(handle, &buff, &nbytes);
        CHECK_ERROR_AND_RETURN("audio_in_peek", error_code);

        /* Store the recorded part in the file. */
        fwrite(buff, sizeof(char), nbytes, g_fp_w);

        /* Remove the obtained audio input data from the actual stream buff. */
        error_code = audio_in_drop(handle);
        CHECK_ERROR("audio_in_peek", error_code);
    }
}

/*
 * @brief A boolean variable that defines whether the asynchronous recording is ongoing
 * or not.
 */
static bool is_async_rec_ongoing = false;

/**
 * @brief Records the audio asynchronously.
 * @details Called when the "Asynchronous Recording" button is clicked.
 * @remarks This function matches the Evas_Smart_Cb() signature defined in the
 *          Evas_Legacy.h header file.
 *
 * @param data        The user data passed via void pointer. This argument is
 *                    not used in this case.
 * @param obj         A handle to the object on which the event occurred. In
 *                    this case it's a pointer to the button object. This
 *                    argument is not used in this case.
 * @param event_info  A pointer to a data which is totally dependent on the
 *                    smart object's implementation and semantic for the given
 *                    event. This argument is not used in this case.
 */
//static void start_recordtest_async(void *data, Evas_Object *obj, void *event_info)
void start_recordtest_async()
{
    int error_code = AUDIO_IO_ERROR_NONE;

    if (!is_async_rec_ongoing) {
        /*
         * Set a callback function that will be called asynchronously for every
         * single part of the captured voice data.
         */
        error_code = audio_in_set_stream_cb(g_input, _audio_io_stream_read_cb, NULL);
        CHECK_ERROR_AND_RETURN("audio_in_set_stream_cb", error_code);

        /* Open a file, where the recorded data will be stored. */
        g_fp_w = fopen(g_audio_io_file_path, "w");

        if (g_fp_w) {
            PRINT_MSG("Recording stored in %s file.", g_audio_io_file_path);
        } else {
            DLOG_PRINT_ERROR("fopen", g_fp_w);
            return;
        }

        /* Acquires the recording focus before starting the record */
        error_code = sound_manager_acquire_focus(g_stream_info_h, SOUND_STREAM_FOCUS_FOR_RECORDING,
                                                  SOUND_BEHAVIOR_NONE, "SampleAppAudioIO(Acquire)");
        if (SOUND_MANAGER_ERROR_NONE != error_code)
            dlog_print(DLOG_ERROR, LOG_TAG, "sound_manager_acquire_focus() failed! Error code = 0x%x", error_code);
        CHECK_ERROR_AND_RETURN("sound_manager_acquire_focus", error_code);
        g_current_state = ASYNC_RECORD;

        /* Prepare audio input (starts the hardware recording process). */
        error_code = audio_in_prepare(g_input);
        if (AUDIO_IO_ERROR_NONE != error_code) {
            DLOG_PRINT_ERROR("audio_in_prepare", error_code);
        } else {
            PRINT_MSG("Asynchronous recording started.");
            is_async_rec_ongoing = true;

            /* Disable buttons until the asynchronous recording finishes. */
            //elm_object_disabled_set(g_audio_async_play_button, EINA_TRUE);
            //elm_object_disabled_set(g_audio_sync_rec_button, EINA_TRUE);
        }

        //elm_object_text_set(g_audio_async_rec_button, "Stop Asynchronous Recording");
    } else {
        /* Stop the hardware recording process. */
        error_code = audio_in_unprepare(g_input);
        if (AUDIO_IO_ERROR_NONE != error_code) {
            DLOG_PRINT_ERROR("audio_in_unprepare", error_code);
        } else {
            PRINT_MSG("Asynchronous recording stopped.");
            is_async_rec_ongoing = false;

            /* Release the focus if callback is not invoked. */
            if (!g_focus_cb_invoked_async_record) {
                error_code = sound_manager_release_focus(g_stream_info_h, SOUND_STREAM_FOCUS_FOR_RECORDING,
                                                         SOUND_BEHAVIOR_NONE, "SampleAppAudioIO(Release)");
                if (SOUND_MANAGER_ERROR_NONE != error_code)
                    dlog_print(DLOG_ERROR, LOG_TAG, "sound_manager_release_focus() failed! Error code = 0x%x", error_code);
                CHECK_ERROR("sound_manager_release_focus", error_code);
            }
            g_current_state = NONE;

            g_focus_cb_invoked_async_record = false;
            /*
             * Enable buttons, because the current asynchronous recording is
             * finished.
             */
            //elm_object_disabled_set(g_audio_async_play_button, EINA_FALSE);
            //elm_object_disabled_set(g_audio_sync_rec_button, EINA_FALSE);

            /*
             * Unset the callback function used for asynchronous recording
             * process.
             */
            error_code = audio_in_unset_stream_cb(g_input);
            CHECK_ERROR("audio_in_unset_stream_cb", error_code);

            /* Close the file used for recording. */
            error_code = fclose(g_fp_w);
            CHECK_ERROR("fclose", error_code);

            //elm_object_text_set(g_audio_async_rec_button,"Start Asynchronous Recording");
        }
    }
}

