S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: firsttizenhello
PID: 5655
Date: 2017-04-09 07:19:24-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5655, uid 5000)

Register Information
r0   = 0x00000023, r1   = 0x00000000
r2   = 0xab776b00, r3   = 0xab776b00
r4   = 0xf5e57934, r5   = 0xf7897018
r6   = 0xf7864c78, r7   = 0xffe0ed38
r8   = 0x00000000, r9   = 0xf78cb020
r10  = 0xf78c9830, fp   = 0x00000001
ip   = 0xf5e97084, sp   = 0xffe0ed00
lr   = 0xf5e577b5, pc   = 0xf5e577b8
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     11776 KB
Buffers:     38472 KB
Cached:     203048 KB
VmPeak:     110568 KB
VmSize:     110564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27968 KB
VmRSS:       27964 KB
VmData:      39564 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25336 KB
VmPTE:         132 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5655 TID = 5655
5655 5772 5775 5776 5786 

Maps Information
f0901000 f1100000 rw-p [stack:5786]
f12ed000 f12f8000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f140d000 f140f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1417000 f1418000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1420000 f1428000 r-xp /usr/lib/libfeedback.so.0.1.4
f1441000 f1442000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f144a000 f144b000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f1453000 f1456000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f1514000 f1d13000 rw-p [stack:5775]
f2115000 f2914000 rw-p [stack:5776]
f2d16000 f3515000 rw-p [stack:5772]
f35d7000 f35ee000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f35fb000 f3600000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3608000 f3613000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f393b000 f3a2d000 r-xp /usr/lib/libCOREGL.so.4.0
f3a46000 f3a4b000 r-xp /usr/lib/libsystem.so.0.0.0
f3a55000 f3a56000 r-xp /usr/lib/libresponse.so.0.2.96
f3a5e000 f3a63000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3a6c000 f3a6e000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3a76000 f3a7d000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3a86000 f3aa8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3ab1000 f3ab9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3ac1000 f3ac7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3ad0000 f3ad5000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3add000 f3afe000 r-xp /usr/lib/libexif.so.12.3.3
f3b11000 f3b2a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3b32000 f3b37000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3b3f000 f3b45000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3b4d000 f3b51000 r-xp /usr/lib/libogg.so.0.7.1
f3b59000 f3b7b000 r-xp /usr/lib/libvorbis.so.0.4.3
f3b83000 f3b85000 r-xp /usr/lib/libttrace.so.1.1
f3b8d000 f3b8f000 r-xp /usr/lib/libdri2.so.0.0.0
f3b97000 f3b9f000 r-xp /usr/lib/libdrm.so.2.4.0
f3ba7000 f3ba8000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3bb1000 f3bb4000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3bbc000 f3bcb000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3bd4000 f3c1b000 r-xp /usr/lib/libsndfile.so.1.0.26
f3c27000 f3c70000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3c79000 f3c7e000 r-xp /usr/lib/libjson.so.0.0.1
f3c86000 f3c89000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3c91000 f3c97000 r-xp /usr/lib/libxcb-render.so.0.0.0
f3c9f000 f3ca0000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f3ca9000 f3cad000 r-xp /usr/lib/libEGL.so.1.4
f3cbd000 f3cce000 r-xp /usr/lib/libGLESv2.so.2.0
f3cde000 f3ce9000 r-xp /usr/lib/libtbm.so.1.0.0
f3cf1000 f3d14000 r-xp /usr/lib/libui-extension.so.0.1.0
f3d1d000 f3d33000 r-xp /usr/lib/libtts.so
f3d3c000 f3d84000 r-xp /usr/lib/libmdm.so.1.2.62
f5616000 f571c000 r-xp /usr/lib/libicuuc.so.57.1
f5732000 f58ba000 r-xp /usr/lib/libicui18n.so.57.1
f58ca000 f58d7000 r-xp /usr/lib/libail.so.0.1.0
f58e0000 f58e3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f58eb000 f5923000 r-xp /usr/lib/libpulse.so.0.16.2
f5924000 f5927000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f592f000 f5990000 r-xp /usr/lib/libasound.so.2.0.0
f599a000 f59b0000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f59b8000 f59bf000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f59c7000 f59cb000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f59d3000 f59de000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f59eb000 f59ef000 r-xp /usr/lib/libmmfsession.so.0.0.0
f59f8000 f59ff000 r-xp /usr/lib/libminizip.so.1.0.0
f5a07000 f5abf000 r-xp /usr/lib/libcairo.so.2.11200.14
f5aca000 f5adc000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5ae4000 f5ae9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5af1000 f5b08000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5b1a000 f5b1f000 r-xp /usr/lib/libstorage.so.0.1
f5b27000 f5b48000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5b50000 f5b57000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f5b62000 f5b6d000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5d07000 f5d11000 r-xp /lib/libnss_files-2.13.so
f5d1a000 f5de9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5dff000 f5e23000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5e2c000 f5e32000 r-xp /usr/lib/libappsvc.so.0.1.0
f5e3a000 f5e3c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5e45000 f5e49000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5e56000 f5e58000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
f5e68000 f5e6a000 r-xp /usr/lib/libiniparser.so.0
f5e73000 f5e78000 r-xp /usr/lib/libappcore-common.so.1.1
f5e81000 f5e89000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5e8a000 f5e8e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5e9b000 f5e9d000 r-xp /usr/lib/libXau.so.6.0.0
f5ea5000 f5eac000 r-xp /lib/libcrypt-2.13.so
f5edc000 f5ede000 r-xp /usr/lib/libiri.so
f5ee7000 f6090000 r-xp /usr/lib/libcrypto.so.1.0.0
f60b0000 f60f7000 r-xp /usr/lib/libssl.so.1.0.0
f6103000 f6131000 r-xp /usr/lib/libidn.so.11.5.44
f6139000 f6142000 r-xp /usr/lib/libcares.so.2.1.0
f614c000 f615f000 r-xp /usr/lib/libxcb.so.1.1.0
f6168000 f616a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6172000 f6174000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f617d000 f6249000 r-xp /usr/lib/libxml2.so.2.7.8
f6256000 f6258000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6261000 f6266000 r-xp /usr/lib/libffi.so.5.0.10
f626e000 f626f000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6277000 f627a000 r-xp /lib/libattr.so.1.1.0
f6282000 f6316000 r-xp /usr/lib/libstdc++.so.6.0.16
f6329000 f6346000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6350000 f6368000 r-xp /usr/lib/libpng12.so.0.50.0
f6370000 f6386000 r-xp /lib/libexpat.so.1.6.0
f6390000 f63d4000 r-xp /usr/lib/libcurl.so.4.3.0
f63dd000 f63e7000 r-xp /usr/lib/libXext.so.6.4.0
f63f0000 f63f4000 r-xp /usr/lib/libXtst.so.6.1.0
f63fc000 f6402000 r-xp /usr/lib/libXrender.so.1.3.0
f640a000 f6410000 r-xp /usr/lib/libXrandr.so.2.2.0
f6418000 f6419000 r-xp /usr/lib/libXinerama.so.1.0.0
f6422000 f642b000 r-xp /usr/lib/libXi.so.6.1.0
f6433000 f6436000 r-xp /usr/lib/libXfixes.so.3.1.0
f643e000 f6440000 r-xp /usr/lib/libXgesture.so.7.0.0
f6448000 f644a000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6452000 f6454000 r-xp /usr/lib/libXdamage.so.1.1.0
f645c000 f6463000 r-xp /usr/lib/libXcursor.so.1.0.2
f646b000 f646e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6476000 f647a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6483000 f6488000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6491000 f6572000 r-xp /usr/lib/libX11.so.6.3.0
f657d000 f65a0000 r-xp /usr/lib/libjpeg.so.8.0.2
f65b8000 f65ce000 r-xp /lib/libz.so.1.2.5
f65d6000 f65d8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f65e0000 f6655000 r-xp /usr/lib/libsqlite3.so.0.8.6
f665f000 f6679000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6681000 f66b5000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f66be000 f6791000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f679c000 f67ac000 r-xp /lib/libresolv-2.13.so
f67b0000 f67c8000 r-xp /usr/lib/liblzma.so.5.0.3
f67d0000 f67d3000 r-xp /lib/libcap.so.2.21
f67db000 f680a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6812000 f6813000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f681b000 f6821000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6829000 f6840000 r-xp /usr/lib/liblua-5.1.so
f6849000 f6850000 r-xp /usr/lib/libembryo.so.1.7.99
f6858000 f685e000 r-xp /lib/librt-2.13.so
f6867000 f68bd000 r-xp /usr/lib/libpixman-1.so.0.28.2
f68ca000 f6920000 r-xp /usr/lib/libfreetype.so.6.11.3
f692c000 f6954000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6955000 f699a000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f69a3000 f69b6000 r-xp /usr/lib/libfribidi.so.0.3.1
f69be000 f69d8000 r-xp /usr/lib/libecore_con.so.1.7.99
f69e1000 f69ea000 r-xp /usr/lib/libedbus.so.1.7.99
f69f2000 f6a42000 r-xp /usr/lib/libecore_x.so.1.7.99
f6a44000 f6a4d000 r-xp /usr/lib/libvconf.so.0.2.45
f6a55000 f6a66000 r-xp /usr/lib/libecore_input.so.1.7.99
f6a6e000 f6a73000 r-xp /usr/lib/libecore_file.so.1.7.99
f6a7b000 f6a9d000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6aa6000 f6ae7000 r-xp /usr/lib/libeina.so.1.7.99
f6af0000 f6b09000 r-xp /usr/lib/libeet.so.1.7.99
f6b1a000 f6b83000 r-xp /lib/libm-2.13.so
f6b8c000 f6b92000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6b9b000 f6b9c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ba4000 f6bc7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bcf000 f6bd4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bdc000 f6c06000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c0f000 f6c26000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c2e000 f6c39000 r-xp /lib/libunwind.so.8.0.1
f6c66000 f6c84000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c8e000 f6db2000 r-xp /lib/libc-2.13.so
f6dc0000 f6dc8000 r-xp /lib/libgcc_s-4.6.so.1
f6dc9000 f6dcd000 r-xp /usr/lib/libsmack.so.1.0.0
f6dd6000 f6ddc000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6de4000 f6eb4000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eb5000 f6f13000 r-xp /usr/lib/libedje.so.1.7.99
f6f1d000 f6f34000 r-xp /usr/lib/libecore.so.1.7.99
f6f4b000 f7019000 r-xp /usr/lib/libevas.so.1.7.99
f703e000 f717a000 r-xp /usr/lib/libelementary.so.1.7.99
f7191000 f71a5000 r-xp /lib/libpthread-2.13.so
f71b0000 f71b2000 r-xp /usr/lib/libdlog.so.0.0.0
f71ba000 f71bd000 r-xp /usr/lib/libbundle.so.0.1.22
f71c5000 f71c7000 r-xp /lib/libdl-2.13.so
f71d0000 f71dd000 r-xp /usr/lib/libaul.so.0.1.0
f71ee000 f71f4000 r-xp /usr/lib/libappcore-efl.so.1.1
f71fd000 f7201000 r-xp /usr/lib/libsys-assert.so
f720a000 f7227000 r-xp /lib/ld-2.13.so
f7230000 f7235000 r-xp /usr/bin/launchpad-loader
f7764000 f794d000 rw-p [heap]
ffdef000 ffe10000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5655)
Call Stack Count: 17
 0: button_clicked_request_cb + 0x3b (0xf5e577b8) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x17b8
 1: evas_object_smart_callback_call + 0x88 (0xf6f805cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf6efaf0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf6efeefd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf6efb869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf6efbc1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf6efbd55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf6f283f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf6f25e53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf6f2946b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf6f29879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf71f1b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf5e8c421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0xf5e5725f) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x125f
14: (0xf7231a53) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1a53
15: __libc_start_main + 0x114 (0xf6ca585c) [/lib/libc.so.6] + 0x1785c
16: (0xf7231e0c) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1e0c
End of Call Stack

Package Information
Package Name: edu.umich.edu.yctung.firsttizenhellp
Package ID : edu.umich.edu.yctung.firsttizenhellp
Version: 1.0.0
Package Type: rpm
App Name: firsttizenhello
App ID: edu.umich.edu.yctung.firsttizenhellp
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1223776, handle->stream_userdata:0xf7904608)
04-09 07:19:25.022-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1224288, userdata=0xf7904608
04-09 07:19:25.022-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1224288
04-09 07:19:25.032-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.032-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.032-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.032-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.032-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1224288, handle->stream_userdata:0xf7904608)
04-09 07:19:25.032-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1224464, userdata=0xf7904608
04-09 07:19:25.032-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1224464
04-09 07:19:25.042-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.042-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.042-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.042-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.042-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1224464, handle->stream_userdata:0xf7904608)
04-09 07:19:25.042-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1224976, userdata=0xf7904608
04-09 07:19:25.042-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1224976
04-09 07:19:25.052-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.052-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.052-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.052-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.052-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1224976, handle->stream_userdata:0xf7904608)
04-09 07:19:25.052-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1225154, userdata=0xf7904608
04-09 07:19:25.052-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1225154
04-09 07:19:25.052-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.052-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.052-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.052-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.052-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1225154, handle->stream_userdata:0xf7904608)
04-09 07:19:25.052-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1225666, userdata=0xf7904608
04-09 07:19:25.052-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1225666
04-09 07:19:25.062-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.062-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.062-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.062-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.062-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1225666, handle->stream_userdata:0xf7904608)
04-09 07:19:25.062-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1225842, userdata=0xf7904608
04-09 07:19:25.062-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1225842
04-09 07:19:25.062-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.062-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.062-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.062-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.062-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1225842, handle->stream_userdata:0xf7904608)
04-09 07:19:25.062-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1226354, userdata=0xf7904608
04-09 07:19:25.062-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1226354
04-09 07:19:25.072-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.072-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.072-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.072-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.072-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1226354, handle->stream_userdata:0xf7904608)
04-09 07:19:25.072-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1226532, userdata=0xf7904608
04-09 07:19:25.072-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1226532
04-09 07:19:25.072-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.072-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.072-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.072-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.072-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1226532, handle->stream_userdata:0xf7904608)
04-09 07:19:25.082-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1227044, userdata=0xf7904608
04-09 07:19:25.082-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1227044
04-09 07:19:25.082-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.082-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.082-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.082-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.082-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1227044, handle->stream_userdata:0xf7904608)
04-09 07:19:25.082-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1227220, userdata=0xf7904608
04-09 07:19:25.082-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1227220
04-09 07:19:25.092-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.092-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.092-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.092-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.092-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1227220, handle->stream_userdata:0xf7904608)
04-09 07:19:25.092-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1227732, userdata=0xf7904608
04-09 07:19:25.092-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1227732
04-09 07:19:25.092-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.092-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.092-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.092-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.092-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1227732, handle->stream_userdata:0xf7904608)
04-09 07:19:25.092-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1227910, userdata=0xf7904608
04-09 07:19:25.092-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1227910
04-09 07:19:25.102-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.102-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.102-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.102-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.102-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1227910, handle->stream_userdata:0xf7904608)
04-09 07:19:25.102-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1228422, userdata=0xf7904608
04-09 07:19:25.102-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1228422
04-09 07:19:25.102-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.102-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.102-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.102-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.102-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1228422, handle->stream_userdata:0xf7904608)
04-09 07:19:25.102-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1228598, userdata=0xf7904608
04-09 07:19:25.102-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1228598
04-09 07:19:25.112-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.112-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.112-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.112-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.112-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1228598, handle->stream_userdata:0xf7904608)
04-09 07:19:25.112-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1229110, userdata=0xf7904608
04-09 07:19:25.112-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1229110
04-09 07:19:25.122-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.122-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.122-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.122-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.122-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1229110, handle->stream_userdata:0xf7904608)
04-09 07:19:25.122-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1229288, userdata=0xf7904608
04-09 07:19:25.122-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1229288
04-09 07:19:25.122-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.122-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.122-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.122-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.122-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1229288, handle->stream_userdata:0xf7904608)
04-09 07:19:25.122-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1229800, userdata=0xf7904608
04-09 07:19:25.122-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1229800
04-09 07:19:25.132-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.132-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.132-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.132-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.132-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1229800, handle->stream_userdata:0xf7904608)
04-09 07:19:25.132-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1229976, userdata=0xf7904608
04-09 07:19:25.132-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1229976
04-09 07:19:25.132-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.132-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.132-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.132-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.132-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1229976, handle->stream_userdata:0xf7904608)
04-09 07:19:25.132-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1230488, userdata=0xf7904608
04-09 07:19:25.132-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1230488
04-09 07:19:25.142-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.142-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.142-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.142-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.142-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1230488, handle->stream_userdata:0xf7904608)
04-09 07:19:25.142-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1230666, userdata=0xf7904608
04-09 07:19:25.142-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1230666
04-09 07:19:25.142-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.142-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.142-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.142-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.142-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1230666, handle->stream_userdata:0xf7904608)
04-09 07:19:25.142-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1231178, userdata=0xf7904608
04-09 07:19:25.142-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1231178
04-09 07:19:25.152-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.152-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.152-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.152-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.152-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1231178, handle->stream_userdata:0xf7904608)
04-09 07:19:25.152-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1231354, userdata=0xf7904608
04-09 07:19:25.152-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1231354
04-09 07:19:25.152-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.152-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.152-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.152-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.152-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1231354, handle->stream_userdata:0xf7904608)
04-09 07:19:25.162-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1231866, userdata=0xf7904608
04-09 07:19:25.162-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1231866
04-09 07:19:25.162-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.162-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.162-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.162-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.162-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1231866, handle->stream_userdata:0xf7904608)
04-09 07:19:25.162-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1232044, userdata=0xf7904608
04-09 07:19:25.162-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1232044
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.172-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1232044, handle->stream_userdata:0xf7904608)
04-09 07:19:25.172-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1232556, userdata=0xf7904608
04-09 07:19:25.172-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1232556
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.172-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1232556, handle->stream_userdata:0xf7904608)
04-09 07:19:25.172-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1232734, userdata=0xf7904608
04-09 07:19:25.172-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1232734
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.172-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.172-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1232734, handle->stream_userdata:0xf7904608)
04-09 07:19:25.182-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1233246, userdata=0xf7904608
04-09 07:19:25.182-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1233246
04-09 07:19:25.182-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.182-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.182-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.182-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.182-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1233246, handle->stream_userdata:0xf7904608)
04-09 07:19:25.182-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1233422, userdata=0xf7904608
04-09 07:19:25.182-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1233422
04-09 07:19:25.192-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.192-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.192-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.192-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.192-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1233422, handle->stream_userdata:0xf7904608)
04-09 07:19:25.192-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1233934, userdata=0xf7904608
04-09 07:19:25.192-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1233934
04-09 07:19:25.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:19:25.192-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.192-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.192-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.192-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.192-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1233934, handle->stream_userdata:0xf7904608)
04-09 07:19:25.192-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1234112, userdata=0xf7904608
04-09 07:19:25.192-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1234112
04-09 07:19:25.202-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.202-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.202-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.202-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.202-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1234112, handle->stream_userdata:0xf7904608)
04-09 07:19:25.202-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1234624, userdata=0xf7904608
04-09 07:19:25.202-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1234624
04-09 07:19:25.202-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.202-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.202-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.202-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.202-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1234624, handle->stream_userdata:0xf7904608)
04-09 07:19:25.212-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1234800, userdata=0xf7904608
04-09 07:19:25.212-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1234800
04-09 07:19:25.212-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.212-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.212-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.212-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.212-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1234800, handle->stream_userdata:0xf7904608)
04-09 07:19:25.212-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1235312, userdata=0xf7904608
04-09 07:19:25.212-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1235312
04-09 07:19:25.222-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.222-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.222-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.222-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.222-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1235312, handle->stream_userdata:0xf7904608)
04-09 07:19:25.222-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1235490, userdata=0xf7904608
04-09 07:19:25.222-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1235490
04-09 07:19:25.222-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.222-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.222-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.222-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.222-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1235490, handle->stream_userdata:0xf7904608)
04-09 07:19:25.232-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1236002, userdata=0xf7904608
04-09 07:19:25.232-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1236002
04-09 07:19:25.232-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.232-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.232-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.232-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.232-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1236002, handle->stream_userdata:0xf7904608)
04-09 07:19:25.232-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1236178, userdata=0xf7904608
04-09 07:19:25.232-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1236178
04-09 07:19:25.242-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.242-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.242-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.242-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.242-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1236178, handle->stream_userdata:0xf7904608)
04-09 07:19:25.242-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1236690, userdata=0xf7904608
04-09 07:19:25.242-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1236690
04-09 07:19:25.252-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.252-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.252-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.252-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.252-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1236690, handle->stream_userdata:0xf7904608)
04-09 07:19:25.252-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1236868, userdata=0xf7904608
04-09 07:19:25.252-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1236868
04-09 07:19:25.252-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.252-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.252-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.252-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.252-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1236868, handle->stream_userdata:0xf7904608)
04-09 07:19:25.252-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1237380, userdata=0xf7904608
04-09 07:19:25.252-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1237380
04-09 07:19:25.262-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.262-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.262-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.262-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.262-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1237380, handle->stream_userdata:0xf7904608)
04-09 07:19:25.262-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1237556, userdata=0xf7904608
04-09 07:19:25.262-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1237556
04-09 07:19:25.262-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.262-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.262-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.262-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.262-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1237556, handle->stream_userdata:0xf7904608)
04-09 07:19:25.272-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1238068, userdata=0xf7904608
04-09 07:19:25.272-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1238068
04-09 07:19:25.272-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.272-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.272-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.272-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.272-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1238068, handle->stream_userdata:0xf7904608)
04-09 07:19:25.272-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1238246, userdata=0xf7904608
04-09 07:19:25.272-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1238246
04-09 07:19:25.282-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.282-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.282-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.282-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.282-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1238246, handle->stream_userdata:0xf7904608)
04-09 07:19:25.282-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1238758, userdata=0xf7904608
04-09 07:19:25.282-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1238758
04-09 07:19:25.292-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.292-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.292-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.292-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.292-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1238758, handle->stream_userdata:0xf7904608)
04-09 07:19:25.292-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1238934, userdata=0xf7904608
04-09 07:19:25.292-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1238934
04-09 07:19:25.292-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:25.292-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7909b50], buffer[0xf2912830], length[-225368008])
04-09 07:19:25.292-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:25.292-0400 E/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:25.292-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf78fa9c0, nbytes:1238934, handle->stream_userdata:0xf7904608)
04-09 07:19:25.292-0400 I/TIZEN_N_AUDIO_IO( 5655): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf78fa9c0, nbytes=1239446, userdata=0xf7904608
04-09 07:19:25.292-0400 D/firsttizenhello( 5655): stream_read_cb is called, nbytes = 1239446
04-09 07:19:25.312-0400 E/RESOURCED( 2594): block-monitor.c: block_logging(123) > pid 5655(edu.umich.edu.yctung.firsttizenhellp) accessed /opt/usr/media/Sounds/yctung_pcm_w.raw
04-09 07:19:25.312-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5655 pgid = 5655
04-09 07:19:25.312-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-09 07:19:25.352-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-09 07:19:25.352-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-09 07:19:25.352-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:19:25.362-0400 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2717] goes to (3)
04-09 07:19:25.362-0400 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2717)'s state(3)
04-09 07:19:25.362-0400 W/AUL_AMD ( 2480): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-09 07:19:25.362-0400 W/AUL_AMD ( 2480): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-09 07:19:25.362-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2717) status(fg) type(uiapp)
04-09 07:19:25.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:19:25.462-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-09 07:19:25.472-0400 I/AUL_AMD ( 2480): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5655
04-09 07:19:25.472-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5655)
04-09 07:19:25.542-0400 W/PROCESSMGR( 2304): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-09 07:19:25.542-0400 W/W_HOME  ( 2717): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
04-09 07:19:25.542-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-09 07:19:25.542-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-09 07:19:25.542-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-09 07:19:25.542-0400 W/W_HOME  ( 2717): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-09 07:19:25.552-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-09 07:19:25.552-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-09 07:19:25.552-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:19:25.562-0400 W/CRASH_MANAGER( 5789): worker.c: worker_job(1199) > 1105655666972149173676
