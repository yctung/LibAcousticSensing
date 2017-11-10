S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: devapp
PID: 8047
Date: 2017-07-10 23:56:27-0700
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8047, uid 5000)

Register Information
r0   = 0x00000029, r1   = 0x00000001
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x00000029, r5   = 0xf5d72ff4
r6   = 0xf5b8f5c4, r7   = 0xf5d6ea00
r8   = 0x00000000, r9   = 0xf5d732e0
r10  = 0xf5d73288, fp   = 0x00000000
ip   = 0xf5b7de41, sp   = 0xf0d6c878
lr   = 0xf5d6bd91, pc   = 0xf5b7de52
cpsr = 0x20000030

Memory Information
MemTotal:   714608 KB
MemFree:    144644 KB
Buffers:     35912 KB
Cached:     139132 KB
VmPeak:     143680 KB
VmSize:     140984 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36040 KB
VmRSS:       36040 KB
VmData:      66828 KB
VmStk:        6952 KB
VmExe:          20 KB
VmLib:       25328 KB
VmPTE:         156 KB
VmSwap:          0 KB

Threads Information
Threads: 7
PID = 8047 TID = 8130
8047 8123 8129 8130 8131 8133 8137 

Maps Information
ef0ef000 ef8ee000 rw-p [stack:8133]
efcf0000 f04ef000 rw-p [stack:8131]
f056f000 f0d6e000 rw-p [stack:8130]
f0d6f000 f156e000 rw-p [stack:8129]
f156e000 f1579000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1707000 f1709000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1711000 f1712000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f171a000 f1722000 r-xp /usr/lib/libfeedback.so.0.1.4
f173b000 f173c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f2381000 f2b80000 rw-p [stack:8137]
f2f82000 f3781000 rw-p [stack:8123]
f3843000 f385a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3867000 f386c000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3874000 f387f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3ba7000 f3c99000 r-xp /usr/lib/libCOREGL.so.4.0
f3cb2000 f3cb7000 r-xp /usr/lib/libsystem.so.0.0.0
f3cc1000 f3cc2000 r-xp /usr/lib/libresponse.so.0.2.96
f3cca000 f3ccf000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3cd8000 f3cda000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3ce2000 f3ce9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3cf2000 f3d14000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3d1d000 f3d25000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3d2d000 f3d33000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3d3c000 f3d41000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3d49000 f3d6a000 r-xp /usr/lib/libexif.so.12.3.3
f3d7d000 f3d96000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3d9e000 f3da3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3dab000 f3db1000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3db9000 f3dbd000 r-xp /usr/lib/libogg.so.0.7.1
f3dc5000 f3de7000 r-xp /usr/lib/libvorbis.so.0.4.3
f3def000 f3df1000 r-xp /usr/lib/libttrace.so.1.1
f3df9000 f3dfb000 r-xp /usr/lib/libdri2.so.0.0.0
f3e03000 f3e0b000 r-xp /usr/lib/libdrm.so.2.4.0
f3e13000 f3e14000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3e1d000 f3e20000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3e28000 f3e37000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3e40000 f3e87000 r-xp /usr/lib/libsndfile.so.1.0.26
f3e93000 f3edc000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3ee5000 f3eea000 r-xp /usr/lib/libjson.so.0.0.1
f3ef2000 f3ef5000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3efd000 f3f03000 r-xp /usr/lib/libxcb-render.so.0.0.0
f3f0b000 f3f0c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f3f15000 f3f19000 r-xp /usr/lib/libEGL.so.1.4
f3f29000 f3f3a000 r-xp /usr/lib/libGLESv2.so.2.0
f3f4a000 f3f55000 r-xp /usr/lib/libtbm.so.1.0.0
f3f5d000 f3f80000 r-xp /usr/lib/libui-extension.so.0.1.0
f3f89000 f3f9f000 r-xp /usr/lib/libtts.so
f3fa8000 f3ff0000 r-xp /usr/lib/libmdm.so.1.2.62
f5882000 f5988000 r-xp /usr/lib/libicuuc.so.57.1
f599e000 f5b26000 r-xp /usr/lib/libicui18n.so.57.1
f5b36000 f5b43000 r-xp /usr/lib/libail.so.0.1.0
f5b4c000 f5b4f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f5b57000 f5b8f000 r-xp /usr/lib/libpulse.so.0.16.2
f5b90000 f5b93000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5b9b000 f5bfc000 r-xp /usr/lib/libasound.so.2.0.0
f5c06000 f5c1c000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5c24000 f5c2b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5c33000 f5c37000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5c3f000 f5c4a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5c57000 f5c5b000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5c64000 f5c6b000 r-xp /usr/lib/libminizip.so.1.0.0
f5c73000 f5d2b000 r-xp /usr/lib/libcairo.so.2.11200.14
f5d36000 f5d48000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5d50000 f5d55000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5d5d000 f5d74000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5d86000 f5d8b000 r-xp /usr/lib/libstorage.so.0.1
f5d93000 f5db4000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5dbc000 f5dc3000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f5dce000 f5dd9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5f73000 f5f7d000 r-xp /lib/libnss_files-2.13.so
f5f86000 f6055000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f606b000 f608f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f6098000 f609e000 r-xp /usr/lib/libappsvc.so.0.1.0
f60a6000 f60a8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f60b1000 f60b5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f60c0000 f60c4000 r-xp /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
f60d4000 f60d6000 r-xp /usr/lib/libiniparser.so.0
f60df000 f60e4000 r-xp /usr/lib/libappcore-common.so.1.1
f60ed000 f60f5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f60f6000 f60fa000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6107000 f6109000 r-xp /usr/lib/libXau.so.6.0.0
f6111000 f6118000 r-xp /lib/libcrypt-2.13.so
f6148000 f614a000 r-xp /usr/lib/libiri.so
f6153000 f62fc000 r-xp /usr/lib/libcrypto.so.1.0.0
f631c000 f6363000 r-xp /usr/lib/libssl.so.1.0.0
f636f000 f639d000 r-xp /usr/lib/libidn.so.11.5.44
f63a5000 f63ae000 r-xp /usr/lib/libcares.so.2.1.0
f63b8000 f63cb000 r-xp /usr/lib/libxcb.so.1.1.0
f63d4000 f63d6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f63de000 f63e0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f63e9000 f64b5000 r-xp /usr/lib/libxml2.so.2.7.8
f64c2000 f64c4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f64cd000 f64d2000 r-xp /usr/lib/libffi.so.5.0.10
f64da000 f64db000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f64e3000 f64e6000 r-xp /lib/libattr.so.1.1.0
f64ee000 f6582000 r-xp /usr/lib/libstdc++.so.6.0.16
f6595000 f65b2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65bc000 f65d4000 r-xp /usr/lib/libpng12.so.0.50.0
f65dc000 f65f2000 r-xp /lib/libexpat.so.1.6.0
f65fc000 f6640000 r-xp /usr/lib/libcurl.so.4.3.0
f6649000 f6653000 r-xp /usr/lib/libXext.so.6.4.0
f665c000 f6660000 r-xp /usr/lib/libXtst.so.6.1.0
f6668000 f666e000 r-xp /usr/lib/libXrender.so.1.3.0
f6676000 f667c000 r-xp /usr/lib/libXrandr.so.2.2.0
f6684000 f6685000 r-xp /usr/lib/libXinerama.so.1.0.0
f668e000 f6697000 r-xp /usr/lib/libXi.so.6.1.0
f669f000 f66a2000 r-xp /usr/lib/libXfixes.so.3.1.0
f66aa000 f66ac000 r-xp /usr/lib/libXgesture.so.7.0.0
f66b4000 f66b6000 r-xp /usr/lib/libXcomposite.so.1.0.0
f66be000 f66c0000 r-xp /usr/lib/libXdamage.so.1.1.0
f66c8000 f66cf000 r-xp /usr/lib/libXcursor.so.1.0.2
f66d7000 f66da000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f66e2000 f66e6000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f66ef000 f66f4000 r-xp /usr/lib/libecore_fb.so.1.7.99
f66fd000 f67de000 r-xp /usr/lib/libX11.so.6.3.0
f67e9000 f680c000 r-xp /usr/lib/libjpeg.so.8.0.2
f6824000 f683a000 r-xp /lib/libz.so.1.2.5
f6842000 f6844000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f684c000 f68c1000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68cb000 f68e5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68ed000 f6921000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f692a000 f69fd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a08000 f6a18000 r-xp /lib/libresolv-2.13.so
f6a1c000 f6a34000 r-xp /usr/lib/liblzma.so.5.0.3
f6a3c000 f6a3f000 r-xp /lib/libcap.so.2.21
f6a47000 f6a76000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a7e000 f6a7f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6a87000 f6a8d000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6a95000 f6aac000 r-xp /usr/lib/liblua-5.1.so
f6ab5000 f6abc000 r-xp /usr/lib/libembryo.so.1.7.99
f6ac4000 f6aca000 r-xp /lib/librt-2.13.so
f6ad3000 f6b29000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b36000 f6b8c000 r-xp /usr/lib/libfreetype.so.6.11.3
f6b98000 f6bc0000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6bc1000 f6c06000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c0f000 f6c22000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c2a000 f6c44000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c4d000 f6c56000 r-xp /usr/lib/libedbus.so.1.7.99
f6c5e000 f6cae000 r-xp /usr/lib/libecore_x.so.1.7.99
f6cb0000 f6cb9000 r-xp /usr/lib/libvconf.so.0.2.45
f6cc1000 f6cd2000 r-xp /usr/lib/libecore_input.so.1.7.99
f6cda000 f6cdf000 r-xp /usr/lib/libecore_file.so.1.7.99
f6ce7000 f6d09000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6d12000 f6d53000 r-xp /usr/lib/libeina.so.1.7.99
f6d5c000 f6d75000 r-xp /usr/lib/libeet.so.1.7.99
f6d86000 f6def000 r-xp /lib/libm-2.13.so
f6df8000 f6dfe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e07000 f6e08000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e10000 f6e33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e3b000 f6e40000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e48000 f6e72000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e7b000 f6e92000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e9a000 f6ea5000 r-xp /lib/libunwind.so.8.0.1
f6ed2000 f6ef0000 r-xp /usr/lib/libsystemd.so.0.4.0
f6efa000 f701e000 r-xp /lib/libc-2.13.so
f702c000 f7034000 r-xp /lib/libgcc_s-4.6.so.1
f7035000 f7039000 r-xp /usr/lib/libsmack.so.1.0.0
f7042000 f7048000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f7050000 f7120000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7121000 f717f000 r-xp /usr/lib/libedje.so.1.7.99
f7189000 f71a0000 r-xp /usr/lib/libecore.so.1.7.99
f71b7000 f7285000 r-xp /usr/lib/libevas.so.1.7.99
f72aa000 f73e6000 r-xp /usr/lib/libelementary.so.1.7.99
f73fd000 f7411000 r-xp /lib/libpthread-2.13.so
f741c000 f741e000 r-xp /usr/lib/libdlog.so.0.0.0
f7426000 f7429000 r-xp /usr/lib/libbundle.so.0.1.22
f7431000 f7433000 r-xp /lib/libdl-2.13.so
f743c000 f7449000 r-xp /usr/lib/libaul.so.0.1.0
f745a000 f7460000 r-xp /usr/lib/libappcore-efl.so.1.1
f7469000 f746d000 r-xp /usr/lib/libsys-assert.so
f7476000 f7493000 r-xp /lib/ld-2.13.so
f749c000 f74a1000 r-xp /usr/bin/launchpad-loader
f7771000 f7bf9000 rw-p [heap]
ff285000 ff94e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8047)
Call Stack Count: 8
 0: pa_stream_disconnect + 0x11 (0xf5b7de52) [/usr/lib/libpulse.so.0] + 0x26e52
 1: (0xf5d6bd91) [/usr/lib/libmmfsound.so.0] + 0xed91
 2: mm_sound_pcm_play_close_async + 0xe6 (0xf5d6d567) [/usr/lib/libmmfsound.so.0] + 0x10567
 3: audio_out_set_callback_private + 0x1c (0xf5dbee35) [/usr/lib/libcapi-media-audio-io.so.0] + 0x2e35
 4: stop_audio_playing + 0x60 (0xf60c2a1d) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x2a1d
 5: _keep_reading_socket + 0x13a (0xf60c23ab) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x23ab
 6: (0xf7198831) [/usr/lib/libecore.so.1] + 0xf831
 7: (0xf7403b8c) [/lib/libpthread.so.0] + 0x6b8c
End of Call Stack

Package Information
Package Name: edu.umich.edu.yctung.devapp
Package ID : edu.umich.edu.yctung.devapp
Version: 1.0.0
Package Type: rpm
App Name: DevApp
App ID: edu.umich.edu.yctung.devapp
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
instead
07-10 23:56:27.301-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.311-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.311-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.311-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.311-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.311-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.311-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.321-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.321-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.321-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.321-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.331-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.331-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.331-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.331-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.331-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.331-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.341-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.341-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.341-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.341-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.351-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.351-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.351-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.351-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.351-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.351-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.361-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.361-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.361-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.361-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.371-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.371-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.371-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.371-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.371-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.371-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.381-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.381-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.381-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.381-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.391-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.391-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.391-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.391-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.391-0700 I/CAPI_WATCH_APPLICATION( 2794): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 23:56:27.391-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.391-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.401-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.401-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.401-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.401-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.411-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.411-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.411-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.411-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.421-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.421-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.421-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.421-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.431-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.431-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.431-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.431-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.431-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.431-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.441-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.441-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.441-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.441-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.451-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.451-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.451-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.451-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.461-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.461-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.461-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.461-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.461-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.461-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.471-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.471-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.471-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.471-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.481-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.481-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.481-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.481-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.481-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.481-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.491-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.491-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.491-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.491-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.501-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.501-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.501-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.501-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.501-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.501-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.511-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.511-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.511-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.511-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.521-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.521-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.521-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.521-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.531-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.531-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.531-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.531-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.531-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.531-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.541-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.541-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.541-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.541-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.551-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.551-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.551-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.551-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.561-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.561-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.561-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.561-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.571-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.571-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.571-0700 D/devapp  ( 8047): n = 1, reaction = 4
07-10 23:56:27.571-0700 D/devapp  ( 8047): reaction == LIBAS_REACTION_STOP_SENSING
07-10 23:56:27.571-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.571-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.571-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.571-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.581-0700 I/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_unprepare(122) > [audio_in_unprepare] mm_sound_pcm_capture_stop() success
07-10 23:56:27.581-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.581-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.591-0700 I/CAPI_WATCH_APPLICATION( 2794): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 23:56:27.601-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.601-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.601-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.601-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.611-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.611-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.611-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.611-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.611-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.611-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.621-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.621-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.621-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.621-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.631-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.631-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.651-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.651-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.651-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.651-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.661-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.661-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.671-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.671-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.671-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.671-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.691-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.691-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.701-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.701-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.701-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.701-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.711-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.711-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.711-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.711-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.721-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.721-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.731-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.731-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.731-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.731-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.741-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.741-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.741-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.741-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.751-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.751-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.761-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.761-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.761-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.761-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.771-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.771-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.771-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.771-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.781-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.781-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.791-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.791-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.791-0700 I/CAPI_WATCH_APPLICATION( 2794): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 23:56:27.801-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.801-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.801-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.801-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.811-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.811-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.811-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.811-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.821-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.821-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.821-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.821-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.831-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.831-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.831-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.831-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.841-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.841-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.841-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.841-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.841-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.841-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.851-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.851-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.851-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.851-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.861-0700 I/TIZEN_N_AUDIO_IO( 8047): audio_io_private.c: audio_in_set_callback_private(367) > mm_sound_pcm_capture_open_ex() success
07-10 23:56:27.861-0700 D/devapp  ( 8047): stop_audio_playing is called
07-10 23:56:27.861-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_out_unprepare] AUDIO_IO_ERROR_INVALID_OPERATION(0xffffffda) : core fw error(0x80000226)
07-10 23:56:27.861-0700 E/devapp  ( 8047): unable to unprepare audio input
07-10 23:56:27.861-0700 E/devapp  ( 8047): Function not implemented
07-10 23:56:27.861-0700 E/RESOURCED( 2585): block-monitor.c: block_logging(123) > pid 8047(edu.umich.edu.yctung.devapp) accessed /opt/usr/media/Sounds/yctung_w.pcm
07-10 23:56:27.861-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.861-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.871-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.871-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.871-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.871-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.881-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.881-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.881-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.881-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.891-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.891-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.891-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.891-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.901-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.901-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.901-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.901-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.901-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.901-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.911-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.911-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.911-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.911-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.921-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.921-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.921-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.921-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.931-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.931-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.931-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.931-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.931-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.931-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.941-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.941-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.941-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.941-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.951-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.951-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.951-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.951-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.961-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.961-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.961-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.961-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.971-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.971-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.971-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.971-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.971-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.971-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.981-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.981-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.981-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.981-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.991-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.991-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.991-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:27.991-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:27.991-0700 I/CAPI_WATCH_APPLICATION( 2794): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 23:56:28.001-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.001-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.001-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.001-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.011-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.011-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.011-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.011-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.011-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.011-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.021-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.021-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.031-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.031-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.031-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.031-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.041-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.041-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.041-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.041-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.041-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.041-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.051-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.051-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.051-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.051-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.061-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.061-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.071-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.071-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.071-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.071-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.081-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.081-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.081-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.081-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.091-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.091-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.091-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.091-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.101-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.101-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.101-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.101-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.111-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.111-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.111-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.111-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.121-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.121-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.121-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.121-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.131-0700 E/TIZEN_N_AUDIO_IO( 8047): audio_io.c: audio_in_read(138) > audio_in_read doesn't operate in async mode!!!, use audio_in_peek/audio_in_drop instead
07-10 23:56:28.131-0700 D/devapp  ( 8047): bytes_number being recorded = -38
07-10 23:56:28.131-0700 W/WATCH_CORE( 2794): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
07-10 23:56:28.131-0700 I/WATCH_CORE( 2794): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-10 23:56:28.131-0700 I/CAPI_WATCH_APPLICATION( 2794): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 23:56:28.131-0700 W/WECONN  ( 2457): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-10 23:56:28.131-0700 W/WECONN  ( 2457): <__wc_device_on_wear_onoff_changed_cb:353> { state=WC_FEATURE_STATE_ON
07-10 23:56:28.131-0700 W/WECONN  ( 2457): <__wc_device_on_wear_onoff_changed_cb:368> Disconnected manually : 1
07-10 23:56:28.131-0700 W/WECONN  ( 2457): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected by auto switch : 1
07-10 23:56:28.131-0700 W/WECONN  ( 2457): <wc_manager_get_bearer_state:962> type : 1
07-10 23:56:28.131-0700 E/wnoti-service( 2932): wnoti-db-utility.c: context_wearonoff_status_cb(2092) > status changed from 2 to 1 
07-10 23:56:28.131-0700 E/wnoti-service( 2932): wnoti-native-client.c: handle_cache_notification(629) > >>
07-10 23:56:28.131-0700 E/WMS     ( 2411): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23450) > wear_monitor_status update[0] = 2 -> 1
07-10 23:56:28.141-0700 W/W_CLOCK_VIEWER( 2736): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_monitor_cb(183) >  wearonoff_monitor_cb called error[0], context[45], data[{ "Time" : 1499756188138, "Reason" : 1, "Status" : 1 }], req_id[1]
07-10 23:56:28.141-0700 W/W_CLOCK_VIEWER( 2736): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_monitor_cb(199) >  status[1] Wear ON, enabled[1]
07-10 23:56:28.141-0700 W/W_CLOCK_VIEWER( 2736): clock-viewer-smart-lcdoff.c: __clock_viewer_smart_lcdoff_wear_status_changed_cb(101) >  status[1], alarm[0], started[0]
07-10 23:56:28.141-0700 E/ALARM_MANAGER( 2457): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(10-7-2017, 23:56:33), repeat(0), interval(0), type(-1073741822)
07-10 23:56:28.141-0700 E/ALARM_MANAGER( 2402): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2457].
07-10 23:56:28.151-0700 I/AUL     ( 2402): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 23:56:28.151-0700 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 15
07-10 23:56:28.161-0700 I/AUL_AMD ( 2476): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 23:56:28.171-0700 I/AUL_AMD ( 2476): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 23:56:28.171-0700 E/ALARM_MANAGER( 2402): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499756193, Mon Jul 10 23:56:33 2017
07-10 23:56:28.171-0700 E/ALARM_MANAGER( 2402): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1172920188, next duetime: 1499756193
07-10 23:56:28.171-0700 E/ALARM_MANAGER( 2402): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1172920188)
07-10 23:56:28.171-0700 E/ALARM_MANAGER( 2402): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499756400), due_time(1499756193)
07-10 23:56:28.181-0700 E/ALARM_MANAGER( 2402): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-10 23:56:28.191-0700 I/CAPI_WATCH_APPLICATION( 2794): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 23:56:28.201-0700 E/ALARM_MANAGER( 2402): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-10 23:56:28.201-0700 E/ALARM_MANAGER( 2402): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 11-7-2017, 06:56:33 (UTC).
07-10 23:56:28.201-0700 E/ALARM_MANAGER( 2402): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-10 23:56:28.201-0700 W/SHealthService( 3030): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-10 23:56:28.201-0700 E/ALARM_MANAGER( 2402): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-10 23:56:28.221-0700 W/WECONN  ( 2457): <__wc_device_on_wear_onoff_changed_cb:384> }
07-10 23:56:28.221-0700 W/WECONN  ( 2457): <__wc_feature_wearonoff_monitor_cb:531> }
07-10 23:56:28.251-0700 W/WATCH_CORE( 2794): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
07-10 23:56:28.251-0700 I/WATCH_CORE( 2794): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
07-10 23:56:28.251-0700 I/CAPI_WATCH_APPLICATION( 2794): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 23:56:28.251-0700 W/STARTER ( 2632): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2724] goes to (3)
07-10 23:56:28.251-0700 E/STARTER ( 2632): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2724)'s state(3)
07-10 23:56:28.251-0700 W/AUL_AMD ( 2476): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-10 23:56:28.251-0700 W/AUL_AMD ( 2476): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-10 23:56:28.251-0700 W/AUL     ( 2476): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2724) status(fg) type(uiapp)
07-10 23:56:28.271-0700 W/AUL_PAD ( 3225): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8047 pgid = 8047
07-10 23:56:28.271-0700 W/AUL_PAD ( 3225): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-10 23:56:28.301-0700 W/AUL_PAD ( 3225): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 23:56:28.301-0700 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8047
07-10 23:56:28.301-0700 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8047)
07-10 23:56:28.341-0700 W/CRASH_MANAGER( 8140): worker.c: worker_job(1199) > 1108047646576149975618
