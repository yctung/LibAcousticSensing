S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: firsttizenhello
PID: 5777
Date: 2017-04-09 07:19:28-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5777, uid 5000)

Register Information
r0   = 0x00000023, r1   = 0x00000000
r2   = 0xf5db6c00, r3   = 0xf5db6c00
r4   = 0xf635d934, r5   = 0xf7901560
r6   = 0xf78cec30, r7   = 0xfff74698
r8   = 0x00000000, r9   = 0xf792e9a0
r10  = 0xf7933c30, fp   = 0x00000001
ip   = 0xf639d084, sp   = 0xfff74660
lr   = 0xf635d7b5, pc   = 0xf635d7b8
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     15032 KB
Buffers:     38580 KB
Cached:     203512 KB
VmPeak:     109344 KB
VmSize:     109340 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26244 KB
VmRSS:       26240 KB
VmData:      38416 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25320 KB
VmPTE:         120 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5777 TID = 5777
5777 5802 5804 5806 5808 

Maps Information
f1001000 f1800000 rw-p [stack:5808]
f1914000 f191f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1927000 f1929000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1931000 f1932000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f193a000 f1942000 r-xp /usr/lib/libfeedback.so.0.1.4
f195b000 f195c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1a1a000 f2219000 rw-p [stack:5804]
f261b000 f2e1a000 rw-p [stack:5806]
f321c000 f3a1b000 rw-p [stack:5802]
f3add000 f3af4000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3b01000 f3b06000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3b0e000 f3b19000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3e41000 f3f33000 r-xp /usr/lib/libCOREGL.so.4.0
f3f4c000 f3f51000 r-xp /usr/lib/libsystem.so.0.0.0
f3f5b000 f3f5c000 r-xp /usr/lib/libresponse.so.0.2.96
f3f64000 f3f69000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3f72000 f3f74000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3f7c000 f3f83000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3f8c000 f3fae000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3fb7000 f3fbf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3fc7000 f3fcd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3fd6000 f3fdb000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3fe3000 f4004000 r-xp /usr/lib/libexif.so.12.3.3
f4017000 f4030000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f4038000 f403d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f4045000 f404b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f4053000 f4057000 r-xp /usr/lib/libogg.so.0.7.1
f405f000 f4081000 r-xp /usr/lib/libvorbis.so.0.4.3
f4089000 f408b000 r-xp /usr/lib/libttrace.so.1.1
f4093000 f4095000 r-xp /usr/lib/libdri2.so.0.0.0
f409d000 f40a5000 r-xp /usr/lib/libdrm.so.2.4.0
f40ad000 f40ae000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f40b7000 f40ba000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f40c2000 f40d1000 r-xp /usr/lib/libmdm-common.so.1.1.22
f40da000 f4121000 r-xp /usr/lib/libsndfile.so.1.0.26
f412d000 f4176000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f417f000 f4184000 r-xp /usr/lib/libjson.so.0.0.1
f418c000 f418f000 r-xp /usr/lib/libtinycompress.so.0.0.0
f4197000 f419d000 r-xp /usr/lib/libxcb-render.so.0.0.0
f41a5000 f41a6000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f41af000 f41b3000 r-xp /usr/lib/libEGL.so.1.4
f41c3000 f41d4000 r-xp /usr/lib/libGLESv2.so.2.0
f41e4000 f41ef000 r-xp /usr/lib/libtbm.so.1.0.0
f41f7000 f421a000 r-xp /usr/lib/libui-extension.so.0.1.0
f4223000 f4239000 r-xp /usr/lib/libtts.so
f4242000 f428a000 r-xp /usr/lib/libmdm.so.1.2.62
f5b1c000 f5c22000 r-xp /usr/lib/libicuuc.so.57.1
f5c38000 f5dc0000 r-xp /usr/lib/libicui18n.so.57.1
f5dd0000 f5ddd000 r-xp /usr/lib/libail.so.0.1.0
f5de6000 f5de9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f5df1000 f5e29000 r-xp /usr/lib/libpulse.so.0.16.2
f5e2a000 f5e2d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5e35000 f5e96000 r-xp /usr/lib/libasound.so.2.0.0
f5ea0000 f5eb6000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5ebe000 f5ec5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5ecd000 f5ed1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5ed9000 f5ee4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5ef1000 f5ef5000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5efe000 f5f05000 r-xp /usr/lib/libminizip.so.1.0.0
f5f0d000 f5fc5000 r-xp /usr/lib/libcairo.so.2.11200.14
f5fd0000 f5fe2000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5fea000 f5fef000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5ff7000 f600e000 r-xp /usr/lib/libmmfsound.so.0.1.0
f6020000 f6025000 r-xp /usr/lib/libstorage.so.0.1
f602d000 f604e000 r-xp /usr/lib/libefl-extension.so.0.1.0
f6056000 f605d000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f6068000 f6073000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f620d000 f6217000 r-xp /lib/libnss_files-2.13.so
f6220000 f62ef000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f6305000 f6329000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f6332000 f6338000 r-xp /usr/lib/libappsvc.so.0.1.0
f6340000 f6342000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f634b000 f634f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f635c000 f635e000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
f636e000 f6370000 r-xp /usr/lib/libiniparser.so.0
f6379000 f637e000 r-xp /usr/lib/libappcore-common.so.1.1
f6387000 f638f000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f6390000 f6394000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f63a1000 f63a3000 r-xp /usr/lib/libXau.so.6.0.0
f63ab000 f63b2000 r-xp /lib/libcrypt-2.13.so
f63e2000 f63e4000 r-xp /usr/lib/libiri.so
f63ed000 f6596000 r-xp /usr/lib/libcrypto.so.1.0.0
f65b6000 f65fd000 r-xp /usr/lib/libssl.so.1.0.0
f6609000 f6637000 r-xp /usr/lib/libidn.so.11.5.44
f663f000 f6648000 r-xp /usr/lib/libcares.so.2.1.0
f6652000 f6665000 r-xp /usr/lib/libxcb.so.1.1.0
f666e000 f6670000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6678000 f667a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6683000 f674f000 r-xp /usr/lib/libxml2.so.2.7.8
f675c000 f675e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6767000 f676c000 r-xp /usr/lib/libffi.so.5.0.10
f6774000 f6775000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f677d000 f6780000 r-xp /lib/libattr.so.1.1.0
f6788000 f681c000 r-xp /usr/lib/libstdc++.so.6.0.16
f682f000 f684c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6856000 f686e000 r-xp /usr/lib/libpng12.so.0.50.0
f6876000 f688c000 r-xp /lib/libexpat.so.1.6.0
f6896000 f68da000 r-xp /usr/lib/libcurl.so.4.3.0
f68e3000 f68ed000 r-xp /usr/lib/libXext.so.6.4.0
f68f6000 f68fa000 r-xp /usr/lib/libXtst.so.6.1.0
f6902000 f6908000 r-xp /usr/lib/libXrender.so.1.3.0
f6910000 f6916000 r-xp /usr/lib/libXrandr.so.2.2.0
f691e000 f691f000 r-xp /usr/lib/libXinerama.so.1.0.0
f6928000 f6931000 r-xp /usr/lib/libXi.so.6.1.0
f6939000 f693c000 r-xp /usr/lib/libXfixes.so.3.1.0
f6944000 f6946000 r-xp /usr/lib/libXgesture.so.7.0.0
f694e000 f6950000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6958000 f695a000 r-xp /usr/lib/libXdamage.so.1.1.0
f6962000 f6969000 r-xp /usr/lib/libXcursor.so.1.0.2
f6971000 f6974000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f697c000 f6980000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6989000 f698e000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6997000 f6a78000 r-xp /usr/lib/libX11.so.6.3.0
f6a83000 f6aa6000 r-xp /usr/lib/libjpeg.so.8.0.2
f6abe000 f6ad4000 r-xp /lib/libz.so.1.2.5
f6adc000 f6ade000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ae6000 f6b5b000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b65000 f6b7f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b87000 f6bbb000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6bc4000 f6c97000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ca2000 f6cb2000 r-xp /lib/libresolv-2.13.so
f6cb6000 f6cce000 r-xp /usr/lib/liblzma.so.5.0.3
f6cd6000 f6cd9000 r-xp /lib/libcap.so.2.21
f6ce1000 f6d10000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d18000 f6d19000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6d21000 f6d27000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6d2f000 f6d46000 r-xp /usr/lib/liblua-5.1.so
f6d4f000 f6d56000 r-xp /usr/lib/libembryo.so.1.7.99
f6d5e000 f6d64000 r-xp /lib/librt-2.13.so
f6d6d000 f6dc3000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6dd0000 f6e26000 r-xp /usr/lib/libfreetype.so.6.11.3
f6e32000 f6e5a000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6e5b000 f6ea0000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6ea9000 f6ebc000 r-xp /usr/lib/libfribidi.so.0.3.1
f6ec4000 f6ede000 r-xp /usr/lib/libecore_con.so.1.7.99
f6ee7000 f6ef0000 r-xp /usr/lib/libedbus.so.1.7.99
f6ef8000 f6f48000 r-xp /usr/lib/libecore_x.so.1.7.99
f6f4a000 f6f53000 r-xp /usr/lib/libvconf.so.0.2.45
f6f5b000 f6f6c000 r-xp /usr/lib/libecore_input.so.1.7.99
f6f74000 f6f79000 r-xp /usr/lib/libecore_file.so.1.7.99
f6f81000 f6fa3000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6fac000 f6fed000 r-xp /usr/lib/libeina.so.1.7.99
f6ff6000 f700f000 r-xp /usr/lib/libeet.so.1.7.99
f7020000 f7089000 r-xp /lib/libm-2.13.so
f7092000 f7098000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70a1000 f70a2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70aa000 f70cd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70d5000 f70da000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70e2000 f710c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7115000 f712c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7134000 f713f000 r-xp /lib/libunwind.so.8.0.1
f716c000 f718a000 r-xp /usr/lib/libsystemd.so.0.4.0
f7194000 f72b8000 r-xp /lib/libc-2.13.so
f72c6000 f72ce000 r-xp /lib/libgcc_s-4.6.so.1
f72cf000 f72d3000 r-xp /usr/lib/libsmack.so.1.0.0
f72dc000 f72e2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f72ea000 f73ba000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73bb000 f7419000 r-xp /usr/lib/libedje.so.1.7.99
f7423000 f743a000 r-xp /usr/lib/libecore.so.1.7.99
f7451000 f751f000 r-xp /usr/lib/libevas.so.1.7.99
f7544000 f7680000 r-xp /usr/lib/libelementary.so.1.7.99
f7697000 f76ab000 r-xp /lib/libpthread-2.13.so
f76b6000 f76b8000 r-xp /usr/lib/libdlog.so.0.0.0
f76c0000 f76c3000 r-xp /usr/lib/libbundle.so.0.1.22
f76cb000 f76cd000 r-xp /lib/libdl-2.13.so
f76d6000 f76e3000 r-xp /usr/lib/libaul.so.0.1.0
f76f4000 f76fa000 r-xp /usr/lib/libappcore-efl.so.1.1
f7703000 f7707000 r-xp /usr/lib/libsys-assert.so
f7710000 f772d000 r-xp /lib/ld-2.13.so
f7736000 f773b000 r-xp /usr/bin/launchpad-loader
f77ce000 f79a2000 rw-p [heap]
fff55000 fff76000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5777)
Call Stack Count: 17
 0: button_clicked_request_cb + 0x3b (0xf635d7b8) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x17b8
 1: evas_object_smart_callback_call + 0x88 (0xf74865cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf7400f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf7404efd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf7401869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf7401c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf7401d55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf742e3f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf742be53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf742f46b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf742f879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf76f7b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf6392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0xf635d25f) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x125f
14: (0xf7737a53) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1a53
15: __libc_start_main + 0x114 (0xf71ab85c) [/lib/libc.so.6] + 0x1785c
16: (0xf7737e0c) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1e0c
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
rdata=0xf796e940
04-09 07:19:28.842-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 42546
04-09 07:19:28.842-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.842-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.842-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.842-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.842-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:42546, handle->stream_userdata:0xf796e940)
04-09 07:19:28.842-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=42722, userdata=0xf796e940
04-09 07:19:28.842-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 42722
04-09 07:19:28.852-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.852-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.852-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.852-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.852-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:42722, handle->stream_userdata:0xf796e940)
04-09 07:19:28.852-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=43234, userdata=0xf796e940
04-09 07:19:28.862-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 43234
04-09 07:19:28.862-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.862-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.862-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.862-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.862-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:43234, handle->stream_userdata:0xf796e940)
04-09 07:19:28.872-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=43412, userdata=0xf796e940
04-09 07:19:28.872-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 43412
04-09 07:19:28.872-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.872-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.872-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.872-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.872-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:43412, handle->stream_userdata:0xf796e940)
04-09 07:19:28.872-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=43924, userdata=0xf796e940
04-09 07:19:28.872-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 43924
04-09 07:19:28.882-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.882-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.882-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.882-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.882-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:43924, handle->stream_userdata:0xf796e940)
04-09 07:19:28.882-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=44100, userdata=0xf796e940
04-09 07:19:28.882-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 44100
04-09 07:19:28.882-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.882-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.882-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.882-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.882-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:44100, handle->stream_userdata:0xf796e940)
04-09 07:19:28.882-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=44612, userdata=0xf796e940
04-09 07:19:28.882-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 44612
04-09 07:19:28.892-0400 D/firsttizenhello( 5777): button is clicked
04-09 07:19:28.902-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.902-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.902-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.902-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.902-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:44612, handle->stream_userdata:0xf796e940)
04-09 07:19:28.902-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=44790, userdata=0xf796e940
04-09 07:19:28.902-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 44790
04-09 07:19:28.902-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.902-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.902-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.902-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.902-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:44790, handle->stream_userdata:0xf796e940)
04-09 07:19:28.902-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=45302, userdata=0xf796e940
04-09 07:19:28.902-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 45302
04-09 07:19:28.912-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.912-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.912-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.912-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.912-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:45302, handle->stream_userdata:0xf796e940)
04-09 07:19:28.912-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=45478, userdata=0xf796e940
04-09 07:19:28.912-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 45478
04-09 07:19:28.912-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.912-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.922-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.922-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.922-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:45478, handle->stream_userdata:0xf796e940)
04-09 07:19:28.922-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=45990, userdata=0xf796e940
04-09 07:19:28.922-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 45990
04-09 07:19:28.922-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.922-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.922-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.922-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.922-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:45990, handle->stream_userdata:0xf796e940)
04-09 07:19:28.922-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=46168, userdata=0xf796e940
04-09 07:19:28.922-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 46168
04-09 07:19:28.932-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.932-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.932-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.932-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.932-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:46168, handle->stream_userdata:0xf796e940)
04-09 07:19:28.932-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=46680, userdata=0xf796e940
04-09 07:19:28.932-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 46680
04-09 07:19:28.942-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.942-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.942-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.942-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.942-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:46680, handle->stream_userdata:0xf796e940)
04-09 07:19:28.942-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=46856, userdata=0xf796e940
04-09 07:19:28.942-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 46856
04-09 07:19:28.942-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.942-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.942-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.942-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.942-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:46856, handle->stream_userdata:0xf796e940)
04-09 07:19:28.942-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=47368, userdata=0xf796e940
04-09 07:19:28.952-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 47368
04-09 07:19:28.952-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.952-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.952-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.952-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.952-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:47368, handle->stream_userdata:0xf796e940)
04-09 07:19:28.962-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=47546, userdata=0xf796e940
04-09 07:19:28.962-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 47546
04-09 07:19:28.962-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.962-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.962-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.962-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.962-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:47546, handle->stream_userdata:0xf796e940)
04-09 07:19:28.962-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=48058, userdata=0xf796e940
04-09 07:19:28.962-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 48058
04-09 07:19:28.972-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.972-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.972-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.972-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.972-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:48058, handle->stream_userdata:0xf796e940)
04-09 07:19:28.972-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=48234, userdata=0xf796e940
04-09 07:19:28.972-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 48234
04-09 07:19:28.972-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.972-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.972-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.972-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.972-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:48234, handle->stream_userdata:0xf796e940)
04-09 07:19:28.972-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=48746, userdata=0xf796e940
04-09 07:19:28.982-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 48746
04-09 07:19:28.982-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.982-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.982-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.982-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.982-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:48746, handle->stream_userdata:0xf796e940)
04-09 07:19:28.992-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=48924, userdata=0xf796e940
04-09 07:19:28.992-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 48924
04-09 07:19:28.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:19:28.992-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:28.992-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:28.992-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:28.992-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:28.992-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:48924, handle->stream_userdata:0xf796e940)
04-09 07:19:28.992-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=49436, userdata=0xf796e940
04-09 07:19:28.992-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 49436
04-09 07:19:29.002-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.002-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.002-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.002-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.002-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:49436, handle->stream_userdata:0xf796e940)
04-09 07:19:29.002-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=49612, userdata=0xf796e940
04-09 07:19:29.002-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 49612
04-09 07:19:29.012-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.012-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.012-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.012-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.012-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:49612, handle->stream_userdata:0xf796e940)
04-09 07:19:29.012-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=50124, userdata=0xf796e940
04-09 07:19:29.012-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 50124
04-09 07:19:29.032-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.032-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.032-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.032-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.032-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:50124, handle->stream_userdata:0xf796e940)
04-09 07:19:29.032-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=50302, userdata=0xf796e940
04-09 07:19:29.032-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 50302
04-09 07:19:29.032-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.032-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.032-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.032-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.032-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:50302, handle->stream_userdata:0xf796e940)
04-09 07:19:29.042-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=50814, userdata=0xf796e940
04-09 07:19:29.042-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 50814
04-09 07:19:29.042-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.052-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.052-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.052-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.052-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:50814, handle->stream_userdata:0xf796e940)
04-09 07:19:29.052-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=50990, userdata=0xf796e940
04-09 07:19:29.052-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 50990
04-09 07:19:29.062-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.062-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.062-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.062-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.062-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:50990, handle->stream_userdata:0xf796e940)
04-09 07:19:29.072-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=51502, userdata=0xf796e940
04-09 07:19:29.072-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 51502
04-09 07:19:29.072-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.072-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.072-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.072-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.072-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:51502, handle->stream_userdata:0xf796e940)
04-09 07:19:29.072-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=51680, userdata=0xf796e940
04-09 07:19:29.072-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 51680
04-09 07:19:29.092-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.092-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.092-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.092-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.092-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:51680, handle->stream_userdata:0xf796e940)
04-09 07:19:29.092-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=52192, userdata=0xf796e940
04-09 07:19:29.092-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 52192
04-09 07:19:29.102-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.102-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.102-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.102-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.102-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:52192, handle->stream_userdata:0xf796e940)
04-09 07:19:29.102-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=52368, userdata=0xf796e940
04-09 07:19:29.102-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 52368
04-09 07:19:29.112-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.112-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.112-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.112-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.112-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:52368, handle->stream_userdata:0xf796e940)
04-09 07:19:29.112-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=52880, userdata=0xf796e940
04-09 07:19:29.122-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 52880
04-09 07:19:29.122-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.122-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.122-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.122-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.122-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:52880, handle->stream_userdata:0xf796e940)
04-09 07:19:29.122-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=53058, userdata=0xf796e940
04-09 07:19:29.122-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 53058
04-09 07:19:29.132-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.132-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.132-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.132-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.132-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:53058, handle->stream_userdata:0xf796e940)
04-09 07:19:29.132-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=53570, userdata=0xf796e940
04-09 07:19:29.132-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 53570
04-09 07:19:29.152-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.152-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.152-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.152-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.152-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:53570, handle->stream_userdata:0xf796e940)
04-09 07:19:29.152-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=53748, userdata=0xf796e940
04-09 07:19:29.152-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 53748
04-09 07:19:29.152-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.152-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.152-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.152-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.152-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:53748, handle->stream_userdata:0xf796e940)
04-09 07:19:29.152-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=54260, userdata=0xf796e940
04-09 07:19:29.152-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 54260
04-09 07:19:29.162-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.162-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.162-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.162-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.162-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:54260, handle->stream_userdata:0xf796e940)
04-09 07:19:29.172-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=54436, userdata=0xf796e940
04-09 07:19:29.172-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 54436
04-09 07:19:29.172-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.172-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.172-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.172-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.172-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:54436, handle->stream_userdata:0xf796e940)
04-09 07:19:29.172-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=54948, userdata=0xf796e940
04-09 07:19:29.172-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 54948
04-09 07:19:29.182-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.182-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.182-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.182-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.182-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:54948, handle->stream_userdata:0xf796e940)
04-09 07:19:29.182-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=55126, userdata=0xf796e940
04-09 07:19:29.182-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 55126
04-09 07:19:29.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:19:29.192-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.192-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.192-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.192-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.192-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:55126, handle->stream_userdata:0xf796e940)
04-09 07:19:29.192-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=55638, userdata=0xf796e940
04-09 07:19:29.192-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 55638
04-09 07:19:29.202-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.202-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.202-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.202-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.202-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:55638, handle->stream_userdata:0xf796e940)
04-09 07:19:29.202-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=55814, userdata=0xf796e940
04-09 07:19:29.202-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 55814
04-09 07:19:29.222-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.222-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.222-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.222-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.222-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:55814, handle->stream_userdata:0xf796e940)
04-09 07:19:29.222-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=56326, userdata=0xf796e940
04-09 07:19:29.222-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 56326
04-09 07:19:29.222-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.222-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.222-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.222-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.222-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:56326, handle->stream_userdata:0xf796e940)
04-09 07:19:29.222-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=56504, userdata=0xf796e940
04-09 07:19:29.222-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 56504
04-09 07:19:29.232-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.232-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.232-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.232-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.232-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:56504, handle->stream_userdata:0xf796e940)
04-09 07:19:29.242-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=57016, userdata=0xf796e940
04-09 07:19:29.242-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 57016
04-09 07:19:29.242-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.242-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.242-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.242-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.242-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:57016, handle->stream_userdata:0xf796e940)
04-09 07:19:29.242-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=57192, userdata=0xf796e940
04-09 07:19:29.242-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 57192
04-09 07:19:29.252-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.252-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.252-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.252-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.252-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:57192, handle->stream_userdata:0xf796e940)
04-09 07:19:29.252-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=57704, userdata=0xf796e940
04-09 07:19:29.252-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 57704
04-09 07:19:29.272-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.272-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.272-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.272-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.272-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:57704, handle->stream_userdata:0xf796e940)
04-09 07:19:29.272-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=57882, userdata=0xf796e940
04-09 07:19:29.272-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 57882
04-09 07:19:29.282-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.282-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.282-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.282-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.282-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:57882, handle->stream_userdata:0xf796e940)
04-09 07:19:29.282-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=58394, userdata=0xf796e940
04-09 07:19:29.282-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 58394
04-09 07:19:29.292-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.292-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.292-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.292-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.292-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:58394, handle->stream_userdata:0xf796e940)
04-09 07:19:29.292-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=58570, userdata=0xf796e940
04-09 07:19:29.292-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 58570
04-09 07:19:29.302-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(303) > handle->is_async : 1
04-09 07:19:29.302-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(309) > before mm_sound_pcm_capture_peek(handle[0xf7973ed0], buffer[0xf2e18830], length[-220100552])
04-09 07:19:29.302-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io.c: audio_in_peek(311) > after mm_sound_pcm_capture_peek() ret[0]
04-09 07:19:29.302-0400 E/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __convert_audio_io_error_code(98) > [audio_in_peek] AUDIO_IO_ERROR_NONE(0x00000000) : core fw error(0x0)
04-09 07:19:29.302-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(228) > << handle->stream_cb(handle:0xf79646b0, nbytes:58570, handle->stream_userdata:0xf796e940)
04-09 07:19:29.302-0400 I/TIZEN_N_AUDIO_IO( 5777): audio_io_private.c: __audio_in_stream_cb(224) > << p=0xf79646b0, nbytes=59082, userdata=0xf796e940
04-09 07:19:29.302-0400 D/firsttizenhello( 5777): stream_read_cb is called, nbytes = 59082
04-09 07:19:29.302-0400 W/CRASH_MANAGER( 5789): worker.c: worker_job(1199) > 1105777666972149173676
