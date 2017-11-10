S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: devapp
PID: 7286
Date: 2017-05-16 14:18:21-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 7286, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xff39f620
r2   = 0x00000010, r3   = 0x55000000
r4   = 0xf5cd8bfc, r5   = 0xf73e0c90
r6   = 0xf73aea50, r7   = 0x0000011b
r8   = 0x00000000, r9   = 0xf73fabb8
r10  = 0xf74100e8, fp   = 0x00000001
ip   = 0x00000000, sp   = 0xff39f520
lr   = 0xf7021aa4, pc   = 0xf7021ab4
cpsr = 0x80000010

Memory Information
MemTotal:   714608 KB
MemFree:      5228 KB
Buffers:     57960 KB
Cached:     172476 KB
VmPeak:     116780 KB
VmSize:     116776 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32684 KB
VmRSS:       32680 KB
VmData:      38936 KB
VmStk:        6964 KB
VmExe:          20 KB
VmLib:       25344 KB
VmPTE:         148 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7286 TID = 7286
7286 7363 7364 7366 7401 

Maps Information
f096f000 f116e000 rw-p [stack:7401]
f116e000 f1179000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f130e000 f1310000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1318000 f1319000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1321000 f1329000 r-xp /usr/lib/libfeedback.so.0.1.4
f1342000 f1343000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f134b000 f134c000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f1354000 f1357000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f1396000 f1b95000 rw-p [stack:7366]
f1f97000 f2796000 rw-p [stack:7364]
f2b98000 f3397000 rw-p [stack:7363]
f3459000 f3470000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f347d000 f3482000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f348a000 f3495000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f37bd000 f38af000 r-xp /usr/lib/libCOREGL.so.4.0
f38c8000 f38cd000 r-xp /usr/lib/libsystem.so.0.0.0
f38d7000 f38d8000 r-xp /usr/lib/libresponse.so.0.2.96
f38e0000 f38e5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f38ee000 f38f0000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f38f8000 f38ff000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3908000 f392a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3933000 f393b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3943000 f3949000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3952000 f3957000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f395f000 f3980000 r-xp /usr/lib/libexif.so.12.3.3
f3993000 f39ac000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f39b4000 f39b9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f39c1000 f39c7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f39cf000 f39d3000 r-xp /usr/lib/libogg.so.0.7.1
f39db000 f39fd000 r-xp /usr/lib/libvorbis.so.0.4.3
f3a05000 f3a07000 r-xp /usr/lib/libttrace.so.1.1
f3a0f000 f3a11000 r-xp /usr/lib/libdri2.so.0.0.0
f3a19000 f3a21000 r-xp /usr/lib/libdrm.so.2.4.0
f3a29000 f3a2a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3a33000 f3a36000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3a3e000 f3a4d000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3a56000 f3a9d000 r-xp /usr/lib/libsndfile.so.1.0.26
f3aa9000 f3af2000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3afb000 f3b00000 r-xp /usr/lib/libjson.so.0.0.1
f3b08000 f3b0b000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3b13000 f3b19000 r-xp /usr/lib/libxcb-render.so.0.0.0
f3b21000 f3b22000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f3b2b000 f3b2f000 r-xp /usr/lib/libEGL.so.1.4
f3b3f000 f3b50000 r-xp /usr/lib/libGLESv2.so.2.0
f3b60000 f3b6b000 r-xp /usr/lib/libtbm.so.1.0.0
f3b73000 f3b96000 r-xp /usr/lib/libui-extension.so.0.1.0
f3b9f000 f3bb5000 r-xp /usr/lib/libtts.so
f3bbe000 f3c06000 r-xp /usr/lib/libmdm.so.1.2.62
f5498000 f559e000 r-xp /usr/lib/libicuuc.so.57.1
f55b4000 f573c000 r-xp /usr/lib/libicui18n.so.57.1
f574c000 f5759000 r-xp /usr/lib/libail.so.0.1.0
f5762000 f5765000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f576d000 f57a5000 r-xp /usr/lib/libpulse.so.0.16.2
f57a6000 f57a9000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f57b1000 f5812000 r-xp /usr/lib/libasound.so.2.0.0
f581c000 f5832000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f583a000 f5841000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5849000 f584d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5855000 f5860000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f586d000 f5871000 r-xp /usr/lib/libmmfsession.so.0.0.0
f587a000 f5881000 r-xp /usr/lib/libminizip.so.1.0.0
f5889000 f5941000 r-xp /usr/lib/libcairo.so.2.11200.14
f594c000 f595e000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5966000 f596b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5973000 f598a000 r-xp /usr/lib/libmmfsound.so.0.1.0
f599c000 f59a1000 r-xp /usr/lib/libstorage.so.0.1
f59a9000 f59ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
f59d2000 f59d9000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f59e4000 f59ef000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5b89000 f5b93000 r-xp /lib/libnss_files-2.13.so
f5b9c000 f5c6b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5c81000 f5ca5000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5cae000 f5cb4000 r-xp /usr/lib/libappsvc.so.0.1.0
f5cbc000 f5cbe000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5cc7000 f5ccb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5cd6000 f5cda000 r-xp /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
f5cea000 f5cec000 r-xp /usr/lib/libiniparser.so.0
f5cf5000 f5cfa000 r-xp /usr/lib/libappcore-common.so.1.1
f5d03000 f5d0b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5d0c000 f5d10000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5d1d000 f5d1f000 r-xp /usr/lib/libXau.so.6.0.0
f5d27000 f5d2e000 r-xp /lib/libcrypt-2.13.so
f5d5e000 f5d60000 r-xp /usr/lib/libiri.so
f5d69000 f5f12000 r-xp /usr/lib/libcrypto.so.1.0.0
f5f32000 f5f79000 r-xp /usr/lib/libssl.so.1.0.0
f5f85000 f5fb3000 r-xp /usr/lib/libidn.so.11.5.44
f5fbb000 f5fc4000 r-xp /usr/lib/libcares.so.2.1.0
f5fce000 f5fe1000 r-xp /usr/lib/libxcb.so.1.1.0
f5fea000 f5fec000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f5ff4000 f5ff6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f5fff000 f60cb000 r-xp /usr/lib/libxml2.so.2.7.8
f60d8000 f60da000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f60e3000 f60e8000 r-xp /usr/lib/libffi.so.5.0.10
f60f0000 f60f1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f60f9000 f60fc000 r-xp /lib/libattr.so.1.1.0
f6104000 f6198000 r-xp /usr/lib/libstdc++.so.6.0.16
f61ab000 f61c8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f61d2000 f61ea000 r-xp /usr/lib/libpng12.so.0.50.0
f61f2000 f6208000 r-xp /lib/libexpat.so.1.6.0
f6212000 f6256000 r-xp /usr/lib/libcurl.so.4.3.0
f625f000 f6269000 r-xp /usr/lib/libXext.so.6.4.0
f6272000 f6276000 r-xp /usr/lib/libXtst.so.6.1.0
f627e000 f6284000 r-xp /usr/lib/libXrender.so.1.3.0
f628c000 f6292000 r-xp /usr/lib/libXrandr.so.2.2.0
f629a000 f629b000 r-xp /usr/lib/libXinerama.so.1.0.0
f62a4000 f62ad000 r-xp /usr/lib/libXi.so.6.1.0
f62b5000 f62b8000 r-xp /usr/lib/libXfixes.so.3.1.0
f62c0000 f62c2000 r-xp /usr/lib/libXgesture.so.7.0.0
f62ca000 f62cc000 r-xp /usr/lib/libXcomposite.so.1.0.0
f62d4000 f62d6000 r-xp /usr/lib/libXdamage.so.1.1.0
f62de000 f62e5000 r-xp /usr/lib/libXcursor.so.1.0.2
f62ed000 f62f0000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f62f8000 f62fc000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6305000 f630a000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6313000 f63f4000 r-xp /usr/lib/libX11.so.6.3.0
f63ff000 f6422000 r-xp /usr/lib/libjpeg.so.8.0.2
f643a000 f6450000 r-xp /lib/libz.so.1.2.5
f6458000 f645a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6462000 f64d7000 r-xp /usr/lib/libsqlite3.so.0.8.6
f64e1000 f64fb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6503000 f6537000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6540000 f6613000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f661e000 f662e000 r-xp /lib/libresolv-2.13.so
f6632000 f664a000 r-xp /usr/lib/liblzma.so.5.0.3
f6652000 f6655000 r-xp /lib/libcap.so.2.21
f665d000 f668c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6694000 f6695000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f669d000 f66a3000 r-xp /usr/lib/libecore_imf.so.1.7.99
f66ab000 f66c2000 r-xp /usr/lib/liblua-5.1.so
f66cb000 f66d2000 r-xp /usr/lib/libembryo.so.1.7.99
f66da000 f66e0000 r-xp /lib/librt-2.13.so
f66e9000 f673f000 r-xp /usr/lib/libpixman-1.so.0.28.2
f674c000 f67a2000 r-xp /usr/lib/libfreetype.so.6.11.3
f67ae000 f67d6000 r-xp /usr/lib/libfontconfig.so.1.8.0
f67d7000 f681c000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6825000 f6838000 r-xp /usr/lib/libfribidi.so.0.3.1
f6840000 f685a000 r-xp /usr/lib/libecore_con.so.1.7.99
f6863000 f686c000 r-xp /usr/lib/libedbus.so.1.7.99
f6874000 f68c4000 r-xp /usr/lib/libecore_x.so.1.7.99
f68c6000 f68cf000 r-xp /usr/lib/libvconf.so.0.2.45
f68d7000 f68e8000 r-xp /usr/lib/libecore_input.so.1.7.99
f68f0000 f68f5000 r-xp /usr/lib/libecore_file.so.1.7.99
f68fd000 f691f000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6928000 f6969000 r-xp /usr/lib/libeina.so.1.7.99
f6972000 f698b000 r-xp /usr/lib/libeet.so.1.7.99
f699c000 f6a05000 r-xp /lib/libm-2.13.so
f6a0e000 f6a14000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a1d000 f6a1e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a26000 f6a49000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a51000 f6a56000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a5e000 f6a88000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a91000 f6aa8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ab0000 f6abb000 r-xp /lib/libunwind.so.8.0.1
f6ae8000 f6b06000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b10000 f6c34000 r-xp /lib/libc-2.13.so
f6c42000 f6c4a000 r-xp /lib/libgcc_s-4.6.so.1
f6c4b000 f6c4f000 r-xp /usr/lib/libsmack.so.1.0.0
f6c58000 f6c5e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6c66000 f6d36000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d37000 f6d95000 r-xp /usr/lib/libedje.so.1.7.99
f6d9f000 f6db6000 r-xp /usr/lib/libecore.so.1.7.99
f6dcd000 f6e9b000 r-xp /usr/lib/libevas.so.1.7.99
f6ec0000 f6ffc000 r-xp /usr/lib/libelementary.so.1.7.99
f7013000 f7027000 r-xp /lib/libpthread-2.13.so
f7032000 f7034000 r-xp /usr/lib/libdlog.so.0.0.0
f703c000 f703f000 r-xp /usr/lib/libbundle.so.0.1.22
f7047000 f7049000 r-xp /lib/libdl-2.13.so
f7052000 f705f000 r-xp /usr/lib/libaul.so.0.1.0
f7070000 f7076000 r-xp /usr/lib/libappcore-efl.so.1.1
f707f000 f7083000 r-xp /usr/lib/libsys-assert.so
f708c000 f70a9000 r-xp /lib/ld-2.13.so
f70b2000 f70b7000 r-xp /usr/bin/launchpad-loader
f72ae000 f7502000 rw-p [heap]
ff393000 ffa5b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7286)
Call Stack Count: 19
 0: connect + 0x44 (0xf7021ab4) [/lib/libpthread.so.0] + 0xeab4
 1: connect_sensing_server + 0x9e (0xf5cd7df3) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1df3
 2: button_clicked_request_cb + 0x52 (0xf5cd7c97) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1c97
 3: evas_object_smart_callback_call + 0x88 (0xf6e025cd) [/usr/lib/libevas.so.1] + 0x355cd
 4: (0xf6d7cf0d) [/usr/lib/libedje.so.1] + 0x45f0d
 5: (0xf6d80efd) [/usr/lib/libedje.so.1] + 0x49efd
 6: (0xf6d7d869) [/usr/lib/libedje.so.1] + 0x46869
 7: (0xf6d7dc1b) [/usr/lib/libedje.so.1] + 0x46c1b
 8: (0xf6d7dd55) [/usr/lib/libedje.so.1] + 0x46d55
 9: (0xf6daa3f5) [/usr/lib/libecore.so.1] + 0xb3f5
10: (0xf6da7e53) [/usr/lib/libecore.so.1] + 0x8e53
11: (0xf6dab46b) [/usr/lib/libecore.so.1] + 0xc46b
12: ecore_main_loop_begin + 0x30 (0xf6dab879) [/usr/lib/libecore.so.1] + 0xc879
13: appcore_efl_main + 0x332 (0xf7073b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
14: ui_app_main + 0xb0 (0xf5d0e421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
15: main + 0x124 (0xf5cd77d1) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x17d1
16: create_base_gui + 0x14e (0xf70b3a53) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1a53
17: __libc_start_main + 0x114 (0xf6b2785c) [/lib/libc.so.6] + 0x1785c
18: connect_sensing_server + 0xb7 (0xf70b3e0c) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1e0c
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
clock-viewer.c: __clock_viewer_clock_changed_timer_cb(191) >  clock changed timer
05-16 14:17:59.661-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: _clock_viewer_send_clock_changed(1069) >  clock changed <<
05-16 14:17:59.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:17:59.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:00.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:00.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:00.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:00.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:00.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:01.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:01.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:01.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:01.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:01.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:02.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:02.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:02.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:02.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:02.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:03.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:03.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:03.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:03.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:03.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:04.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:04.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:04.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:04.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:04.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:05.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:05.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:05.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:05.651-0400 W/W_HOME  ( 2715): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-16 14:18:05.651-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-16 14:18:05.651-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-16 14:18:05.651-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_enable(138) > 1
05-16 14:18:05.651-0400 W/W_HOME  ( 2715): event_manager.c: _lcd_off_cb(736) > lcd state: 0
05-16 14:18:05.651-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:05.651-0400 W/STARTER ( 2681): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
05-16 14:18:05.651-0400 W/STARTER ( 2681): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
05-16 14:18:05.651-0400 E/STARTER ( 2681): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-16 14:18:05.651-0400 W/STARTER ( 2681): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
05-16 14:18:05.651-0400 W/STARTER ( 2681): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
05-16 14:18:05.661-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: __clock_viewer_lcdoff_cb(554) >  event pre lcdoff[1]
05-16 14:18:05.661-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(413) >  enabled[1] status[0] setup[0] darkscreen[0]
05-16 14:18:05.661-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: __clock_viewer_lcdoff_cb(578) >  Skip if wear off status and send ALPMLCDOff
05-16 14:18:05.661-0400 W/WATCH_CORE( 2792): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
05-16 14:18:05.661-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -147092724[0;m
05-16 14:18:05.661-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
05-16 14:18:05.661-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-16 14:18:05.671-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-16 14:18:05.671-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-16 14:18:05.671-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-16 14:18:05.671-0400 I/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
05-16 14:18:05.691-0400 I/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-16 14:18:05.691-0400 W/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-16 14:18:05.691-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
05-16 14:18:05.691-0400 I/HIGEAR  ( 3170): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
05-16 14:18:05.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:05.851-0400 W/SHealthCommon( 2844): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
05-16 14:18:05.861-0400 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
05-16 14:18:05.861-0400 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-16 14:18:05.901-0400 W/W_INDICATOR( 2682): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
05-16 14:18:05.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:06.101-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1499.382800] layer(0x525210) now usable
05-16 14:18:06.101-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1499.382861] layer[0x524d60]zpos[1]
05-16 14:18:06.101-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1499.382914] layer(0x525260) now usable
05-16 14:18:06.101-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1499.382933] layer[0x524e80]zpos[2]
05-16 14:18:06.101-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [1499.383179] dpms[0 -> 3]sync[1]
05-16 14:18:06.101-0400 I/TDM     ( 1956): 
05-16 14:18:06.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:06.231-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [1499.511336] dpms[3 -> 3]done
05-16 14:18:06.231-0400 I/TDM     ( 1956): 
05-16 14:18:06.261-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(668) >  event lcdoff completed[1][0]
05-16 14:18:06.261-0400 W/W_INDICATOR( 2682): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
05-16 14:18:06.261-0400 W/W_INDICATOR( 2682): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
05-16 14:18:06.261-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(413) >  enabled[1] status[0] setup[0] darkscreen[0]
05-16 14:18:06.261-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(688) >  Skip if wear off status
05-16 14:18:06.261-0400 W/W_INDICATOR( 2682): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
05-16 14:18:06.261-0400 W/STARTER ( 2681): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
05-16 14:18:06.261-0400 W/STARTER ( 2681): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[1]
05-16 14:18:06.261-0400 W/STARTER ( 2681): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
05-16 14:18:06.261-0400 W/STARTER ( 2681): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
05-16 14:18:06.261-0400 E/ALARM_MANAGER( 2681): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(16-5-2017, 14:18:26), repeat(1), interval(20), type(-1073741822)
05-16 14:18:06.271-0400 I/APP_CORE( 7286): appcore-efl.c: __do_app(453) > [APP 7286] Event: PAUSE State: RUNNING
05-16 14:18:06.271-0400 I/CAPI_APPFW_APPLICATION( 7286): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-16 14:18:06.271-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2681].
05-16 14:18:06.271-0400 W/APP_CORE( 7286): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3000002] -> redirected win[60935f] for edu.umich.edu.yctung.devapp[7286]
05-16 14:18:06.311-0400 E/ALARM_MANAGER( 2401): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 355620730, next duetime: 1494958706
05-16 14:18:06.311-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(355620730)
05-16 14:18:06.311-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1494959905), due_time(1494958706)
05-16 14:18:06.321-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-16 14:18:06.331-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-16 14:18:06.331-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 16-5-2017, 18:18:26 (UTC).
05-16 14:18:06.331-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-16 14:18:06.331-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __save_module_log(1778) > The file is not ready.
05-16 14:18:06.341-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-16 14:18:06.341-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __save_module_log(1778) > The file is not ready.
05-16 14:18:06.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:06.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:06.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:06.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:07.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:07.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:07.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:07.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:07.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:08.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:08.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:08.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:08.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:08.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:09.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:09.241-0400 W/WATCH_CORE( 2792): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
05-16 14:18:09.241-0400 I/WATCH_CORE( 2792): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-16 14:18:09.241-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -144261320[0;m
05-16 14:18:09.241-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
05-16 14:18:09.241-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-16 14:18:09.241-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:09.251-0400 W/W_HOME  ( 2715): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-16 14:18:09.251-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-16 14:18:09.251-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [1502.534269] dpms[3 -> 0]sync[0]
05-16 14:18:09.251-0400 I/TDM     ( 1956): 
05-16 14:18:09.251-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [1502.534478] dpms[0 -> 0]done
05-16 14:18:09.251-0400 I/TDM     ( 1956): 
05-16 14:18:09.251-0400 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-16 14:18:09.251-0400 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-16 14:18:09.251-0400 W/SHealthCommon( 2844): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
05-16 14:18:09.261-0400 I/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-16 14:18:09.271-0400 W/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-16 14:18:09.271-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-16 14:18:09.281-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-16 14:18:09.281-0400 W/W_HOME  ( 2715): gesture.c: _widget_updated_cb(188) > widget updated
05-16 14:18:09.281-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-16 14:18:09.281-0400 W/W_HOME  ( 2715): gesture.c: _manual_render(182) > 
05-16 14:18:09.291-0400 W/wnotibp ( 3241): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
05-16 14:18:09.291-0400 I/wnotibp ( 3241): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
05-16 14:18:09.291-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: __clock_viewer_lcdon_cb(463) >  event lcdon[1][0]
05-16 14:18:09.291-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer-self.c: clock_viewer_self_show_fake_hands(1083) >  Show fake hands default[0]
05-16 14:18:09.291-0400 E/W_CLOCK_VIEWER( 2723): clock-viewer-self.c: __rotate(1038) >  hand geo[161,-1][40x360]
05-16 14:18:09.291-0400 E/W_CLOCK_VIEWER( 2723): clock-viewer-self.c: __rotate(1038) >  hand geo[161,-1][40x360]
05-16 14:18:09.291-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: __clock_viewer_lcdon_cb(493) >  lcdon by [gesture] time[3648]
05-16 14:18:09.291-0400 W/WATCH_CORE( 2792): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
05-16 14:18:09.291-0400 I/WATCH_CORE( 2792): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
05-16 14:18:09.301-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:09.301-0400 I/WATCH_CORE( 2792): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
05-16 14:18:09.301-0400 W/W_HOME  ( 2715): gesture.c: _manual_render(182) > 
05-16 14:18:09.311-0400 W/STARTER ( 2681): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [3648]ms
05-16 14:18:09.311-0400 W/STARTER ( 2681): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[1]
05-16 14:18:09.321-0400 I/APP_CORE( 7286): appcore-efl.c: __do_app(453) > [APP 7286] Event: RESUME State: PAUSED
05-16 14:18:09.321-0400 I/CAPI_APPFW_APPLICATION( 7286): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-16 14:18:09.321-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [1502.602551] layer(0x525210) not usable
05-16 14:18:09.321-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [1502.602601] layer(0x525210) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-16 14:18:09.321-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [1502.602632] layer[0x524d60]zpos[1]
05-16 14:18:09.321-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [1502.602729] layer(0x525260) not usable
05-16 14:18:09.321-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [1502.602752] layer(0x525260) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
05-16 14:18:09.321-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [1502.602778] layer[0x524e80]zpos[2]
05-16 14:18:09.321-0400 W/W_INDICATOR( 2682): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
05-16 14:18:09.321-0400 W/W_INDICATOR( 2682): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
05-16 14:18:09.331-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2681].
05-16 14:18:09.331-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(355620730)
05-16 14:18:09.331-0400 E/ALARM_MANAGER( 2401): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1850700647) is OVER.
05-16 14:18:09.341-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_enable(138) > 0
05-16 14:18:09.361-0400 W/W_HOME  ( 2715): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-16 14:18:09.361-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_disable_timer_set(167) > timer set
05-16 14:18:09.361-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-16 14:18:09.361-0400 W/W_HOME  ( 2715): gesture.c: _apps_status_get(128) > apps status:0
05-16 14:18:09.361-0400 W/W_HOME  ( 2715): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:3648
05-16 14:18:09.361-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-16 14:18:09.361-0400 W/W_HOME  ( 2715): event_manager.c: _lcd_on_cb(728) > lcd state: 1
05-16 14:18:09.361-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:09.361-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-16 14:18:09.361-0400 I/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-16 14:18:09.371-0400 W/W_HOME  ( 2715): gesture.c: _widget_updated_cb(188) > widget updated
05-16 14:18:09.371-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-16 14:18:09.371-0400 W/W_HOME  ( 2715): gesture.c: _manual_render(182) > 
05-16 14:18:09.371-0400 W/W_HOME  ( 2715): gesture.c: _manual_render_enable(138) > 0
05-16 14:18:09.371-0400 I/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-16 14:18:09.371-0400 W/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-16 14:18:09.371-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-16 14:18:09.371-0400 I/HIGEAR  ( 3170): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-16 14:18:09.371-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -147092724[0;m
05-16 14:18:09.371-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-16 14:18:09.371-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-16 14:18:09.381-0400 I/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-16 14:18:09.381-0400 W/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-16 14:18:09.381-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
05-16 14:18:09.381-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
05-16 14:18:09.381-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_boolean(1173) > preference_get_boolean(3091) : test_healthy_pace error
05-16 14:18:09.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:09.401-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-16 14:18:09.401-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
05-16 14:18:09.401-0400 E/WAKEUP-SERVICE( 3170): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-16 14:18:09.401-0400 W/SHealthCommon( 3091): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1494892800000.000000[0;m
05-16 14:18:09.411-0400 I/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-16 14:18:09.411-0400 I/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-16 14:18:09.411-0400 W/TIZEN_N_SOUND_MANAGER( 3170): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-16 14:18:09.411-0400 W/WAKEUP-SERVICE( 3170): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-16 14:18:09.411-0400 I/HIGEAR  ( 3170): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-16 14:18:09.451-0400 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (651436)]][0;m
05-16 14:18:09.481-0400 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
05-16 14:18:09.481-0400 W/SHealthWidget( 2844): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (651436), msgName: timeline_summary_updated[0;m
05-16 14:18:09.481-0400 W/SHealthCommon( 2844): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
05-16 14:18:09.481-0400 W/SHealthWidget( 2844): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
05-16 14:18:09.481-0400 W/WSLib   ( 2844): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1494944289493.000000, pattern:[HH:mm][0;m
05-16 14:18:09.481-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2844): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-16 14:18:09.481-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2844): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-16 14:18:09.481-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2844): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-16 14:18:09.481-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2844): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-16 14:18:09.491-0400 E/WSLib   ( 2844): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
05-16 14:18:09.491-0400 W/WSLib   ( 2844): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:18][0;m
05-16 14:18:09.491-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2844): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-16 14:18:09.491-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2844): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-16 14:18:09.491-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2844): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-16 14:18:09.491-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2844): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-16 14:18:09.491-0400 I/CAPI_WIDGET_APPLICATION( 2844): widget_app.c: __provider_update_cb(281) > received updating signal
05-16 14:18:09.531-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: __clock_viewer_lcdon_completed_cb(518) >  event lcdon completed[1]
05-16 14:18:09.531-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer-self.c: clock_viewer_self_hide(1066) >  ===== HIDE =====
05-16 14:18:09.531-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: clock_viewer_hide(1452) >  reservied[0], gesture[0], clock visible[0]
05-16 14:18:09.531-0400 W/W_CLOCK_VIEWER( 2723): clock-viewer.c: _clock_viewer_send_clock_changed(1069) >  clock changed <<
05-16 14:18:09.541-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
05-16 14:18:09.541-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-16 14:18:09.541-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 16-5-2017, 18:38:25 (UTC).
05-16 14:18:09.541-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-16 14:18:09.541-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __save_module_log(1778) > The file is not ready.
05-16 14:18:09.561-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
05-16 14:18:09.561-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[355620730] is removed.
05-16 14:18:09.561-0400 E/ALARM_MANAGER( 2401): alarm-manager.c: __save_module_log(1778) > The file is not ready.
05-16 14:18:09.561-0400 W/STARTER ( 2681): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
05-16 14:18:09.561-0400 W/STARTER ( 2681): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[1]
05-16 14:18:09.581-0400 I/HealthDataService( 2910): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-16 14:18:09.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:09.601-0400 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-16 14:18:09.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:09.951-0400 E/EFL     ( 7286): ecore_x<7286> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1503238 button=1
05-16 14:18:09.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:10.091-0400 E/EFL     ( 7286): ecore_x<7286> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1503371 button=1
05-16 14:18:10.171-0400 D/devapp  ( 7286): button is clicked
05-16 14:18:10.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:10.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:10.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:10.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:10.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:11.091-0400 E/EFL     ( 2304): ecore_x<2304> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3000002 time=1503371
05-16 14:18:11.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:11.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:11.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:11.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:11.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:12.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:12.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:12.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:12.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:12.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:13.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:13.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:13.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:13.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:13.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:14.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:14.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:14.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:14.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:14.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:15.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:15.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:15.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:15.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:15.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:16.181-0400 D/chronograph( 2792): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(124) > [0;32mBEGIN >>>>[0;m
05-16 14:18:16.191-0400 D/chronograph( 2792): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(137) > mSweep60SStartValue[16.148001] mCurrentValue[16.195999]
05-16 14:18:16.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:16.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:16.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:16.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:16.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:17.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:17.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:17.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:17.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:17.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:18.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:18.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:18.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:18.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:18.851-0400 E/WMS     ( 2403): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-16 14:18:18.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:19.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:19.331-0400 E/WMS     ( 2403): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
05-16 14:18:19.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:19.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:19.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:19.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:20.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:20.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:20.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:20.791-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:20.991-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:21.091-0400 E/PROCESSMGR( 2304): e_mod_processmgr.c: _e_mod_processmgr_dbus_msg_send(315) > [PROCESSMGR] pointed_win=0x3000002 Send kill command to the ResourceD! PID=7286 Name=edu.umich.edu.yctung.devapp
05-16 14:18:21.101-0400 E/RESOURCED( 2557): proc-monitor.c: proc_dbus_watchdog_handler(838) > Receive watchdog signal to pid: 7286(devapp)
05-16 14:18:21.101-0400 E/RESOURCED( 2557): proc-monitor.c: proc_dbus_watchdog_handler(854) > just kill watchdog process when debug enabled pid: 7286(devapp)
05-16 14:18:21.191-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:21.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:21.391-0400 W/WATCH_CORE( 2792): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-16 14:18:21.391-0400 I/WATCH_CORE( 2792): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-16 14:18:21.391-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:21.391-0400 W/STARTER ( 2681): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2715] goes to (3)
05-16 14:18:21.391-0400 E/STARTER ( 2681): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2715)'s state(3)
05-16 14:18:21.391-0400 W/AUL_AMD ( 2429): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-16 14:18:21.391-0400 W/AUL_AMD ( 2429): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-16 14:18:21.391-0400 W/AUL     ( 2429): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2715) status(fg) type(uiapp)
05-16 14:18:21.441-0400 W/AUL_PAD ( 3240): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7286 pgid = 7286
05-16 14:18:21.441-0400 W/AUL_PAD ( 3240): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 6
05-16 14:18:21.441-0400 W/PROCESSMGR( 2304): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-16 14:18:21.461-0400 W/W_HOME  ( 2715): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
05-16 14:18:21.461-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:21.461-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:21.461-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:21.461-0400 W/W_HOME  ( 2715): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
05-16 14:18:21.461-0400 W/W_INDICATOR( 2682): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
05-16 14:18:21.481-0400 W/W_HOME  ( 2715): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(0)
05-16 14:18:21.481-0400 W/W_HOME  ( 2715): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
05-16 14:18:21.481-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:21.481-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:21.491-0400 W/W_HOME  ( 2715): main.c: _window_visibility_cb(964) > Window [0x2000003] is now visible(0)
05-16 14:18:21.491-0400 I/APP_CORE( 2715): appcore-efl.c: __do_app(453) > [APP 2715] Event: RESUME State: PAUSED
05-16 14:18:21.491-0400 I/CAPI_APPFW_APPLICATION( 2715): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-16 14:18:21.491-0400 W/W_HOME  ( 2715): main.c: _appcore_resume_cb(479) > appcore resume
05-16 14:18:21.491-0400 W/W_HOME  ( 2715): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
05-16 14:18:21.491-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:21.491-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:21.491-0400 W/W_HOME  ( 2715): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
05-16 14:18:21.491-0400 W/W_HOME  ( 2715): main.c: home_resume(531) > clock/widget resumed
05-16 14:18:21.491-0400 W/W_HOME  ( 2715): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-16 14:18:21.491-0400 I/wnotib  ( 2715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
05-16 14:18:21.501-0400 E/wnotib  ( 2715): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-16 14:18:21.501-0400 W/wnotib  ( 2715): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-16 14:18:21.521-0400 W/W_INDICATOR( 2682): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
05-16 14:18:21.531-0400 W/W_INDICATOR( 2682): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
05-16 14:18:21.531-0400 W/W_INDICATOR( 2682): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
05-16 14:18:21.531-0400 W/W_INDICATOR( 2682): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
05-16 14:18:21.531-0400 W/W_INDICATOR( 2682): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(74), length(2)
05-16 14:18:21.531-0400 W/W_INDICATOR( 2682): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 74%
05-16 14:18:21.541-0400 W/W_INDICATOR( 2682): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 74, isCharging: 0
05-16 14:18:21.541-0400 W/W_INDICATOR( 2682): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_75
05-16 14:18:21.541-0400 W/W_INDICATOR( 2682): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
05-16 14:18:21.571-0400 W/AUL_PAD ( 3240): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-16 14:18:21.571-0400 I/AUL_AMD ( 2429): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7286
05-16 14:18:21.571-0400 W/AUL     ( 2429): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7286)
05-16 14:18:21.581-0400 W/WATCH_CORE( 2792): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-16 14:18:21.581-0400 I/WATCH_CORE( 2792): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-16 14:18:21.581-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:21.591-0400 I/CAPI_WATCH_APPLICATION( 2792): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-16 14:18:21.621-0400 W/CRASH_MANAGER( 7403): worker.c: worker_job(1199) > 0607286646576149495870
