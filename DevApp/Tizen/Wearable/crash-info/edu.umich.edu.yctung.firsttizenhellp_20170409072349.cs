S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: firsttizenhello
PID: 6104
Date: 2017-04-09 07:23:49-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6104, uid 5000)

Register Information
r0   = 0x00000023, r1   = 0x00000000
r2   = 0x0cdb9d00, r3   = 0x0cdb9d00
r4   = 0xf5dc9934, r5   = 0xf79291d8
r6   = 0xf78f6a88, r7   = 0xffe0bf08
r8   = 0x00000000, r9   = 0xf795cfd0
r10  = 0xf795b7c8, fp   = 0x00000001
ip   = 0xf5e09084, sp   = 0xffe0bed0
lr   = 0xf5dc97b5, pc   = 0xf5dc97b8
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     16420 KB
Buffers:     38812 KB
Cached:     195844 KB
VmPeak:     114496 KB
VmSize:     114492 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31204 KB
VmRSS:       31200 KB
VmData:      43568 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25320 KB
VmPTE:         144 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6104 TID = 6104
6104 6181 6184 6185 6198 

Maps Information
f0a6f000 f126e000 rw-p [stack:6198]
f126e000 f1279000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1412000 f1414000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f141c000 f141d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1425000 f142d000 r-xp /usr/lib/libfeedback.so.0.1.4
f1446000 f1447000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1486000 f1c85000 rw-p [stack:6184]
f2087000 f2886000 rw-p [stack:6185]
f2c88000 f3487000 rw-p [stack:6181]
f3549000 f3560000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f356d000 f3572000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f357a000 f3585000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f38ad000 f399f000 r-xp /usr/lib/libCOREGL.so.4.0
f39b8000 f39bd000 r-xp /usr/lib/libsystem.so.0.0.0
f39c7000 f39c8000 r-xp /usr/lib/libresponse.so.0.2.96
f39d0000 f39d5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f39de000 f39e0000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f39e8000 f39ef000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f39f8000 f3a1a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3a23000 f3a2b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3a33000 f3a39000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3a42000 f3a47000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3a4f000 f3a70000 r-xp /usr/lib/libexif.so.12.3.3
f3a83000 f3a9c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3aa4000 f3aa9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3ab1000 f3ab7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3abf000 f3ac3000 r-xp /usr/lib/libogg.so.0.7.1
f3acb000 f3aed000 r-xp /usr/lib/libvorbis.so.0.4.3
f3af5000 f3af7000 r-xp /usr/lib/libttrace.so.1.1
f3aff000 f3b01000 r-xp /usr/lib/libdri2.so.0.0.0
f3b09000 f3b11000 r-xp /usr/lib/libdrm.so.2.4.0
f3b19000 f3b1a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3b23000 f3b26000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3b2e000 f3b3d000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3b46000 f3b8d000 r-xp /usr/lib/libsndfile.so.1.0.26
f3b99000 f3be2000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3beb000 f3bf0000 r-xp /usr/lib/libjson.so.0.0.1
f3bf8000 f3bfb000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3c03000 f3c09000 r-xp /usr/lib/libxcb-render.so.0.0.0
f3c11000 f3c12000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f3c1b000 f3c1f000 r-xp /usr/lib/libEGL.so.1.4
f3c2f000 f3c40000 r-xp /usr/lib/libGLESv2.so.2.0
f3c50000 f3c5b000 r-xp /usr/lib/libtbm.so.1.0.0
f3c63000 f3c86000 r-xp /usr/lib/libui-extension.so.0.1.0
f3c8f000 f3ca5000 r-xp /usr/lib/libtts.so
f3cae000 f3cf6000 r-xp /usr/lib/libmdm.so.1.2.62
f5588000 f568e000 r-xp /usr/lib/libicuuc.so.57.1
f56a4000 f582c000 r-xp /usr/lib/libicui18n.so.57.1
f583c000 f5849000 r-xp /usr/lib/libail.so.0.1.0
f5852000 f5855000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f585d000 f5895000 r-xp /usr/lib/libpulse.so.0.16.2
f5896000 f5899000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f58a1000 f5902000 r-xp /usr/lib/libasound.so.2.0.0
f590c000 f5922000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f592a000 f5931000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5939000 f593d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5945000 f5950000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f595d000 f5961000 r-xp /usr/lib/libmmfsession.so.0.0.0
f596a000 f5971000 r-xp /usr/lib/libminizip.so.1.0.0
f5979000 f5a31000 r-xp /usr/lib/libcairo.so.2.11200.14
f5a3c000 f5a4e000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5a56000 f5a5b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5a63000 f5a7a000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5a8c000 f5a91000 r-xp /usr/lib/libstorage.so.0.1
f5a99000 f5aba000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5ac2000 f5ac9000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f5ad4000 f5adf000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5c79000 f5c83000 r-xp /lib/libnss_files-2.13.so
f5c8c000 f5d5b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5d71000 f5d95000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5d9e000 f5da4000 r-xp /usr/lib/libappsvc.so.0.1.0
f5dac000 f5dae000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5db7000 f5dbb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5dc8000 f5dca000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
f5dda000 f5ddc000 r-xp /usr/lib/libiniparser.so.0
f5de5000 f5dea000 r-xp /usr/lib/libappcore-common.so.1.1
f5df3000 f5dfb000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5dfc000 f5e00000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5e0d000 f5e0f000 r-xp /usr/lib/libXau.so.6.0.0
f5e17000 f5e1e000 r-xp /lib/libcrypt-2.13.so
f5e4e000 f5e50000 r-xp /usr/lib/libiri.so
f5e59000 f6002000 r-xp /usr/lib/libcrypto.so.1.0.0
f6022000 f6069000 r-xp /usr/lib/libssl.so.1.0.0
f6075000 f60a3000 r-xp /usr/lib/libidn.so.11.5.44
f60ab000 f60b4000 r-xp /usr/lib/libcares.so.2.1.0
f60be000 f60d1000 r-xp /usr/lib/libxcb.so.1.1.0
f60da000 f60dc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f60e4000 f60e6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f60ef000 f61bb000 r-xp /usr/lib/libxml2.so.2.7.8
f61c8000 f61ca000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f61d3000 f61d8000 r-xp /usr/lib/libffi.so.5.0.10
f61e0000 f61e1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f61e9000 f61ec000 r-xp /lib/libattr.so.1.1.0
f61f4000 f6288000 r-xp /usr/lib/libstdc++.so.6.0.16
f629b000 f62b8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f62c2000 f62da000 r-xp /usr/lib/libpng12.so.0.50.0
f62e2000 f62f8000 r-xp /lib/libexpat.so.1.6.0
f6302000 f6346000 r-xp /usr/lib/libcurl.so.4.3.0
f634f000 f6359000 r-xp /usr/lib/libXext.so.6.4.0
f6362000 f6366000 r-xp /usr/lib/libXtst.so.6.1.0
f636e000 f6374000 r-xp /usr/lib/libXrender.so.1.3.0
f637c000 f6382000 r-xp /usr/lib/libXrandr.so.2.2.0
f638a000 f638b000 r-xp /usr/lib/libXinerama.so.1.0.0
f6394000 f639d000 r-xp /usr/lib/libXi.so.6.1.0
f63a5000 f63a8000 r-xp /usr/lib/libXfixes.so.3.1.0
f63b0000 f63b2000 r-xp /usr/lib/libXgesture.so.7.0.0
f63ba000 f63bc000 r-xp /usr/lib/libXcomposite.so.1.0.0
f63c4000 f63c6000 r-xp /usr/lib/libXdamage.so.1.1.0
f63ce000 f63d5000 r-xp /usr/lib/libXcursor.so.1.0.2
f63dd000 f63e0000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f63e8000 f63ec000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f63f5000 f63fa000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6403000 f64e4000 r-xp /usr/lib/libX11.so.6.3.0
f64ef000 f6512000 r-xp /usr/lib/libjpeg.so.8.0.2
f652a000 f6540000 r-xp /lib/libz.so.1.2.5
f6548000 f654a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6552000 f65c7000 r-xp /usr/lib/libsqlite3.so.0.8.6
f65d1000 f65eb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f65f3000 f6627000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6630000 f6703000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f670e000 f671e000 r-xp /lib/libresolv-2.13.so
f6722000 f673a000 r-xp /usr/lib/liblzma.so.5.0.3
f6742000 f6745000 r-xp /lib/libcap.so.2.21
f674d000 f677c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6784000 f6785000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f678d000 f6793000 r-xp /usr/lib/libecore_imf.so.1.7.99
f679b000 f67b2000 r-xp /usr/lib/liblua-5.1.so
f67bb000 f67c2000 r-xp /usr/lib/libembryo.so.1.7.99
f67ca000 f67d0000 r-xp /lib/librt-2.13.so
f67d9000 f682f000 r-xp /usr/lib/libpixman-1.so.0.28.2
f683c000 f6892000 r-xp /usr/lib/libfreetype.so.6.11.3
f689e000 f68c6000 r-xp /usr/lib/libfontconfig.so.1.8.0
f68c7000 f690c000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6915000 f6928000 r-xp /usr/lib/libfribidi.so.0.3.1
f6930000 f694a000 r-xp /usr/lib/libecore_con.so.1.7.99
f6953000 f695c000 r-xp /usr/lib/libedbus.so.1.7.99
f6964000 f69b4000 r-xp /usr/lib/libecore_x.so.1.7.99
f69b6000 f69bf000 r-xp /usr/lib/libvconf.so.0.2.45
f69c7000 f69d8000 r-xp /usr/lib/libecore_input.so.1.7.99
f69e0000 f69e5000 r-xp /usr/lib/libecore_file.so.1.7.99
f69ed000 f6a0f000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6a18000 f6a59000 r-xp /usr/lib/libeina.so.1.7.99
f6a62000 f6a7b000 r-xp /usr/lib/libeet.so.1.7.99
f6a8c000 f6af5000 r-xp /lib/libm-2.13.so
f6afe000 f6b04000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6b0d000 f6b0e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b16000 f6b39000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b41000 f6b46000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b4e000 f6b78000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b81000 f6b98000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ba0000 f6bab000 r-xp /lib/libunwind.so.8.0.1
f6bd8000 f6bf6000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c00000 f6d24000 r-xp /lib/libc-2.13.so
f6d32000 f6d3a000 r-xp /lib/libgcc_s-4.6.so.1
f6d3b000 f6d3f000 r-xp /usr/lib/libsmack.so.1.0.0
f6d48000 f6d4e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6d56000 f6e26000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e27000 f6e85000 r-xp /usr/lib/libedje.so.1.7.99
f6e8f000 f6ea6000 r-xp /usr/lib/libecore.so.1.7.99
f6ebd000 f6f8b000 r-xp /usr/lib/libevas.so.1.7.99
f6fb0000 f70ec000 r-xp /usr/lib/libelementary.so.1.7.99
f7103000 f7117000 r-xp /lib/libpthread-2.13.so
f7122000 f7124000 r-xp /usr/lib/libdlog.so.0.0.0
f712c000 f712f000 r-xp /usr/lib/libbundle.so.0.1.22
f7137000 f7139000 r-xp /lib/libdl-2.13.so
f7142000 f714f000 r-xp /usr/lib/libaul.so.0.1.0
f7160000 f7166000 r-xp /usr/lib/libappcore-efl.so.1.1
f716f000 f7173000 r-xp /usr/lib/libsys-assert.so
f717c000 f7199000 r-xp /lib/ld-2.13.so
f71a2000 f71a7000 r-xp /usr/bin/launchpad-loader
f77f6000 f7ed0000 rw-p [heap]
ffdec000 ffe0d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6104)
Call Stack Count: 17
 0: button_clicked_request_cb + 0x3b (0xf5dc97b8) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x17b8
 1: evas_object_smart_callback_call + 0x88 (0xf6ef25cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf6e6cf0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf6e70efd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf6e6d869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf6e6dc1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf6e6dd55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf6e9a3f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf6e97e53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf6e9b46b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf6e9b879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf7163b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf5dfe421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0xf5dc925f) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x125f
14: (0xf71a3a53) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1a53
15: __libc_start_main + 0x114 (0xf6c1785c) [/lib/libc.so.6] + 0x1785c
16: (0xf71a3e0c) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1e0c
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
000000) : core fw error(0x0)
04-09 07:23:49.742-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.742-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.742-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.752-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.752-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.752-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.752-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.752-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.752-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.752-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.752-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.752-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.752-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.752-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.752-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.752-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.752-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.762-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.762-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.762-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.762-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.762-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.762-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.762-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.762-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.772-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.772-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.772-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.772-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.772-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.772-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.772-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.772-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.772-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.772-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.772-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.772-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.772-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.782-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.782-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.782-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.782-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.782-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.782-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.782-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.782-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.782-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.782-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.782-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.782-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.782-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.782-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.792-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.792-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.792-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.792-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.792-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.792-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.792-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:23:49.802-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.802-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.802-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.802-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.802-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.802-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.802-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.802-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.802-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.802-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.802-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.802-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.812-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.812-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.822-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.822-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.822-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.822-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.822-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.822-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.822-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.832-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.832-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.832-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.832-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.832-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.832-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.832-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.842-0400 D/firsttizenhello( 6104): button is clicked
04-09 07:23:49.842-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.842-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.842-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.842-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.842-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.842-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.842-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.852-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.852-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.852-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.852-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.852-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.852-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.852-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.862-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.862-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.862-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.862-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.862-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.862-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.862-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.872-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.872-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.872-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.872-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.872-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.872-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.872-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.882-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.882-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.882-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.882-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.882-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.882-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.882-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.892-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.892-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.892-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.892-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.892-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.892-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.892-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.902-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.902-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.902-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.902-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.902-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.902-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.902-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.902-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.902-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.902-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.902-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.902-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.902-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.902-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.912-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.912-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.912-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.912-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.912-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.912-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.912-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.922-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.922-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.922-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.922-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.922-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.922-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.922-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.932-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.932-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.932-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.932-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.932-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.932-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.932-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.942-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.942-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.942-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.942-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.942-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.942-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.942-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.942-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.942-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.942-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.942-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.942-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.952-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.952-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.952-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.952-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.952-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.952-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.952-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.962-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.962-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.972-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.972-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.972-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.972-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.972-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.972-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.972-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.972-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.972-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.972-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.972-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.972-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.982-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.982-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.982-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.982-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.982-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.982-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.982-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.982-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.982-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:49.992-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:49.992-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:49.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:23:49.992-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:49.992-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:49.992-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:49.992-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:49.992-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.002-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.002-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.002-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.002-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.002-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.002-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.002-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.012-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.012-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.012-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.012-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.012-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.012-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.012-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.022-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.022-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.022-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.022-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.022-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.022-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.022-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.032-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.032-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.032-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.032-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.032-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.032-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.032-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.042-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.042-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.042-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.042-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.042-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.042-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.042-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.052-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.052-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.052-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.052-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.052-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.052-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.052-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.062-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.062-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.062-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.062-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.062-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.062-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.062-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.072-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.072-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.072-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.072-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.072-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.072-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.072-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.082-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:23:50.082-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf13005a8], buffer[0xf288482c], length[-225949640])
04-09 07:23:50.082-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:23:50.082-0400 E/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:23:50.082-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf1301600, nbytes:4194146, handle->stream_userdata:0xf79965c0)
04-09 07:23:50.082-0400 I/TIZEN_N_AUDIO_IO( 6104): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf1301600, nbytes=4194146, userdata=0xf79965c0
04-09 07:23:50.082-0400 D/firsttizenhello( 6104): stream_read_cb is called, nbytes = 4194146
04-09 07:23:50.132-0400 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2717] goes to (3)
04-09 07:23:50.132-0400 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2717)'s state(3)
04-09 07:23:50.132-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-09 07:23:50.132-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-09 07:23:50.132-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:23:50.132-0400 W/AUL_AMD ( 2480): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-09 07:23:50.132-0400 W/AUL_AMD ( 2480): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-09 07:23:50.132-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2717) status(fg) type(uiapp)
04-09 07:23:50.132-0400 E/RESOURCED( 2594): block-monitor.c: block_logging(123) > pid 6104(edu.umich.edu.yctung.firsttizenhellp) accessed /opt/usr/media/Sounds/yctung_pcm_w.raw
04-09 07:23:50.182-0400 W/PROCESSMGR( 2304): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-09 07:23:50.182-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-09 07:23:50.182-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-09 07:23:50.182-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:23:50.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:23:50.202-0400 W/W_HOME  ( 2717): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
04-09 07:23:50.202-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:23:50.202-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:23:50.202-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:23:50.202-0400 W/W_HOME  ( 2717): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-09 07:23:50.202-0400 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-09 07:23:50.222-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6104 pgid = 6104
04-09 07:23:50.222-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(0)
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): main.c: _window_visibility_cb(964) > Window [0x2000003] is now visible(0)
04-09 07:23:50.252-0400 I/APP_CORE( 2717): appcore-efl.c: __do_app(453) > [APP 2717] Event: RESUME State: PAUSED
04-09 07:23:50.252-0400 I/CAPI_APPFW_APPLICATION( 2717): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): main.c: _appcore_resume_cb(479) > appcore resume
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): main.c: home_resume(531) > clock/widget resumed
04-09 07:23:50.252-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:23:50.252-0400 I/wnotib  ( 2717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
04-09 07:23:50.252-0400 E/wnotib  ( 2717): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-09 07:23:50.252-0400 W/wnotib  ( 2717): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-09 07:23:50.262-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-09 07:23:50.272-0400 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
04-09 07:23:50.292-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
04-09 07:23:50.292-0400 W/W_INDICATOR( 2651): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-09 07:23:50.312-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-09 07:23:50.312-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(28), length(2)
04-09 07:23:50.322-0400 I/AUL_AMD ( 2480): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6104
04-09 07:23:50.322-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6104)
04-09 07:23:50.332-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 28%
04-09 07:23:50.332-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 28, isCharging: 0
04-09 07:23:50.332-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
04-09 07:23:50.342-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
04-09 07:23:50.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:23:50.392-0400 W/CRASH_MANAGER( 6200): worker.c: worker_job(1199) > 1106104666972149173702
