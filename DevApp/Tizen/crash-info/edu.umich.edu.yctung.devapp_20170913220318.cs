S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: devapp
PID: 5195
Date: 2017-09-13 22:03:18-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
Signal: 6
      (SIGABRT)
      si_code: 0
      signal sent by kill (sent by pid 2582, uid 0)

Register Information
r0   = 0xff934a7c, r1   = 0xaabe03f8
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xaac1a830, r5   = 0xaabe03f8
r6   = 0xaab501a8, r7   = 0xff9347a0
r8   = 0x00000000, r9   = 0xaac14848
r10  = 0xaac142f8, fp   = 0x00000001
ip   = 0xaabe03f8, sp   = 0xff934768
lr   = 0xff934a7c, pc   = 0xaaaabbd2
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:      5800 KB
Buffers:     41216 KB
Cached:     199760 KB
VmPeak:      83424 KB
VmSize:      83420 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32056 KB
VmRSS:       32052 KB
VmData:      13504 KB
VmStk:        6964 KB
VmExe:          16 KB
VmLib:       25288 KB
VmPTE:         116 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5195 TID = 5195
5195 5202 

Maps Information
aaaaa000 aaaae000 r-xp /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
aaabe000 aac57000 rw-p [heap]
f3199000 f3998000 rw-p [stack:5202]
f3998000 f399a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f39a2000 f39a3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f39ab000 f39b3000 r-xp /usr/lib/libfeedback.so.0.1.4
f39cc000 f39cd000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f3b98000 f3baf000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3d52000 f3d57000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3d5f000 f3d6a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f4092000 f409c000 r-xp /lib/libnss_files-2.13.so
f40a5000 f4174000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f418a000 f41ae000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f41b7000 f42a9000 r-xp /usr/lib/libCOREGL.so.4.0
f42c9000 f42ce000 r-xp /usr/lib/libsystem.so.0.0.0
f42d8000 f42d9000 r-xp /usr/lib/libresponse.so.0.2.96
f42e1000 f42e6000 r-xp /usr/lib/libproc-stat.so.0.2.96
f42ef000 f42f1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f42fa000 f4301000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f430a000 f432c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f4335000 f4338000 r-xp /lib/libattr.so.1.1.0
f4340000 f4348000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4350000 f4356000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f4360000 f4365000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f436d000 f438e000 r-xp /usr/lib/libexif.so.12.3.3
f43a1000 f43a8000 r-xp /lib/libcrypt-2.13.so
f43d8000 f43db000 r-xp /lib/libcap.so.2.21
f43e3000 f43e5000 r-xp /usr/lib/libiri.so
f43ee000 f4407000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f440f000 f4414000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f441c000 f4422000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f442a000 f4447000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f4451000 f4455000 r-xp /usr/lib/libogg.so.0.7.1
f445d000 f447f000 r-xp /usr/lib/libvorbis.so.0.4.3
f4487000 f4489000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f4491000 f44bf000 r-xp /usr/lib/libidn.so.11.5.44
f44c7000 f44d0000 r-xp /usr/lib/libcares.so.2.1.0
f44da000 f44dc000 r-xp /usr/lib/libXau.so.6.0.0
f44e4000 f44e6000 r-xp /usr/lib/libttrace.so.1.1
f44ee000 f44f0000 r-xp /usr/lib/libdri2.so.0.0.0
f44f8000 f4500000 r-xp /usr/lib/libdrm.so.2.4.0
f4509000 f450a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f4513000 f4516000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f451e000 f452d000 r-xp /usr/lib/libmdm-common.so.1.1.22
f4536000 f45ca000 r-xp /usr/lib/libstdc++.so.6.0.16
f45de000 f45e2000 r-xp /usr/lib/libsmack.so.1.0.0
f45eb000 f4794000 r-xp /usr/lib/libcrypto.so.1.0.0
f47b4000 f47fb000 r-xp /usr/lib/libssl.so.1.0.0
f4807000 f4836000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f483e000 f4885000 r-xp /usr/lib/libsndfile.so.1.0.26
f4892000 f48db000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f48e4000 f48e9000 r-xp /usr/lib/libjson.so.0.0.1
f48f1000 f48f4000 r-xp /usr/lib/libtinycompress.so.0.0.0
f48fc000 f48fe000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f4907000 f4917000 r-xp /lib/libresolv-2.13.so
f491b000 f4933000 r-xp /usr/lib/liblzma.so.5.0.3
f493b000 f493d000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f4945000 f4a18000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f4a23000 f4a28000 r-xp /usr/lib/libffi.so.5.0.10
f4a31000 f4a75000 r-xp /usr/lib/libcurl.so.4.3.0
f4a7e000 f4aa1000 r-xp /usr/lib/libjpeg.so.8.0.2
f4ab9000 f4acc000 r-xp /usr/lib/libxcb.so.1.1.0
f4ad5000 f4adb000 r-xp /usr/lib/libxcb-render.so.0.0.0
f4ae4000 f4ae5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f4aee000 f4b06000 r-xp /usr/lib/libpng12.so.0.50.0
f4b0e000 f4b12000 r-xp /usr/lib/libEGL.so.1.4
f4b22000 f4b33000 r-xp /usr/lib/libGLESv2.so.2.0
f4b43000 f4b44000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f4b4d000 f4b64000 r-xp /usr/lib/liblua-5.1.so
f4b6d000 f4b74000 r-xp /usr/lib/libembryo.so.1.7.99
f4b7c000 f4b87000 r-xp /usr/lib/libtbm.so.1.0.0
f4b8f000 f4bb2000 r-xp /usr/lib/libui-extension.so.0.1.0
f4bbb000 f4bd1000 r-xp /usr/lib/libtts.so
f4bdb000 f4bf1000 r-xp /lib/libz.so.1.2.5
f4bf9000 f4c0f000 r-xp /lib/libexpat.so.1.6.0
f4c19000 f4c1c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f4c24000 f4c28000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f4c31000 f4c36000 r-xp /usr/lib/libecore_fb.so.1.7.99
f4c40000 f4c4a000 r-xp /usr/lib/libXext.so.6.4.0
f4c53000 f4c57000 r-xp /usr/lib/libXtst.so.6.1.0
f4c5f000 f4c65000 r-xp /usr/lib/libXrender.so.1.3.0
f4c6d000 f4c73000 r-xp /usr/lib/libXrandr.so.2.2.0
f4c7b000 f4c7c000 r-xp /usr/lib/libXinerama.so.1.0.0
f4c85000 f4c88000 r-xp /usr/lib/libXfixes.so.3.1.0
f4c91000 f4c93000 r-xp /usr/lib/libXgesture.so.7.0.0
f4c9b000 f4c9d000 r-xp /usr/lib/libXcomposite.so.1.0.0
f4ca5000 f4ca7000 r-xp /usr/lib/libXdamage.so.1.1.0
f4caf000 f4cb6000 r-xp /usr/lib/libXcursor.so.1.0.2
f4cbe000 f4d06000 r-xp /usr/lib/libmdm.so.1.2.62
f6599000 f669f000 r-xp /usr/lib/libicuuc.so.57.1
f66b5000 f683d000 r-xp /usr/lib/libicui18n.so.57.1
f684d000 f684f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6858000 f6865000 r-xp /usr/lib/libail.so.0.1.0
f686e000 f6871000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f687a000 f68b2000 r-xp /usr/lib/libpulse.so.0.16.2
f68b3000 f68b6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f68be000 f691f000 r-xp /usr/lib/libasound.so.2.0.0
f6929000 f693f000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f6947000 f694e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f6957000 f695b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f6963000 f6964000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f696c000 f6977000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f6984000 f698a000 r-xp /lib/librt-2.13.so
f6993000 f6a08000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a13000 f6a2d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a35000 f6a53000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a5d000 f6a5e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a66000 f6a6b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a73000 f6a8a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a93000 f6a95000 r-xp /usr/lib/libiniparser.so.0
f6a9e000 f6ad2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6adb000 f6ae1000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6ae9000 f6aec000 r-xp /usr/lib/libbundle.so.0.1.22
f6af4000 f6afa000 r-xp /usr/lib/libappsvc.so.0.1.0
f6b03000 f6b0a000 r-xp /usr/lib/libminizip.so.1.0.0
f6b12000 f6b68000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b75000 f6bcb000 r-xp /usr/lib/libfreetype.so.6.11.3
f6bd7000 f6c1c000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c25000 f6c38000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c41000 f6c5b000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c64000 f6c8e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c97000 f6ca0000 r-xp /usr/lib/libedbus.so.1.7.99
f6ca8000 f6cb9000 r-xp /usr/lib/libecore_input.so.1.7.99
f6cc1000 f6cc6000 r-xp /usr/lib/libecore_file.so.1.7.99
f6cce000 f6ce7000 r-xp /usr/lib/libeet.so.1.7.99
f6cf9000 f6d02000 r-xp /usr/lib/libXi.so.6.1.0
f6d0a000 f6deb000 r-xp /usr/lib/libX11.so.6.3.0
f6df6000 f6eae000 r-xp /usr/lib/libcairo.so.2.11200.14
f6eb9000 f6f17000 r-xp /usr/lib/libedje.so.1.7.99
f6f21000 f6f38000 r-xp /usr/lib/libecore.so.1.7.99
f6f50000 f6fb9000 r-xp /lib/libm-2.13.so
f6fc2000 f6fd4000 r-xp /usr/lib/libefl-assist.so.0.1.0
f6fdc000 f70ac000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70ad000 f7179000 r-xp /usr/lib/libxml2.so.2.7.8
f7186000 f71ae000 r-xp /usr/lib/libfontconfig.so.1.8.0
f71af000 f71d1000 r-xp /usr/lib/libecore_evas.so.1.7.99
f71da000 f722a000 r-xp /usr/lib/libecore_x.so.1.7.99
f722c000 f7235000 r-xp /usr/lib/libvconf.so.0.2.45
f723d000 f7241000 r-xp /usr/lib/libmmfsession.so.0.0.0
f724a000 f724f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7257000 f726e000 r-xp /usr/lib/libmmfsound.so.0.1.0
f7280000 f7294000 r-xp /lib/libpthread-2.13.so
f729f000 f72e0000 r-xp /usr/lib/libeina.so.1.7.99
f72e9000 f730c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7314000 f7321000 r-xp /usr/lib/libaul.so.0.1.0
f732b000 f7330000 r-xp /usr/lib/libappcore-common.so.1.1
f7338000 f733e000 r-xp /usr/lib/libappcore-efl.so.1.1
f7346000 f7348000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7351000 f7355000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f735e000 f7360000 r-xp /lib/libdl-2.13.so
f7369000 f7374000 r-xp /lib/libunwind.so.8.0.1
f73a1000 f73a9000 r-xp /lib/libgcc_s-4.6.so.1
f73aa000 f74ce000 r-xp /lib/libc-2.13.so
f74dc000 f74e1000 r-xp /usr/lib/libstorage.so.0.1
f74e9000 f75b7000 r-xp /usr/lib/libevas.so.1.7.99
f75dc000 f7718000 r-xp /usr/lib/libelementary.so.1.7.99
f772f000 f7750000 r-xp /usr/lib/libefl-extension.so.0.1.0
f7758000 f775a000 r-xp /usr/lib/libdlog.so.0.0.0
f7762000 f776a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f776b000 f7776000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f777e000 f7785000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f778d000 f7793000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f779c000 f77a0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f77aa000 f77b5000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f77be000 f77c2000 r-xp /usr/lib/libsys-assert.so
f77cb000 f77e8000 r-xp /lib/ld-2.13.so
ff928000 ffff0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5195)
Call Stack Count: 16
 0: button_clicked_test_cb + 0x11 (0xaaaabbd2) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1bd2
 1: evas_object_smart_callback_call + 0x88 (0xf751e5cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf6efef0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf6f02efd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf6eff869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf6effc1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf6effd55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf6f2c3f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf6f29e53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf6f2d46b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf6f2d879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf733bb47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf779e421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x124 (0xaaaab865) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1865
14: __libc_start_main + 0x114 (0xf73c185c) [/lib/libc.so.6] + 0x1785c
15: (0xaaaab360) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1360
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
watch_core_time_tick
09-13 22:02:14.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:15.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:15.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:15.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:15.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:15.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:16.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:16.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:16.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:16.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:16.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:17.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:17.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:17.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:17.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:17.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:18.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:18.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:18.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:18.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:18.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:19.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:19.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:19.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:19.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:19.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:20.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:20.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:20.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:20.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:20.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:21.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:21.301-0400 E/CAPI_SYSTEM_INFO( 3821): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
09-13 22:02:21.301-0400 E/CAPI_SYSTEM_INFO( 3821): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
09-13 22:02:21.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:21.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:21.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:21.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:22.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:22.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:22.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:22.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:22.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:23.151-0400 E/PKGMGR_SERVER( 5141): pkgmgr-server.c: main(2227) > package manager server start
09-13 22:02:23.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:23.271-0400 E/PKGMGR_SERVER( 5141): pkgmgr-server.c: req_cb(1134) > KILL_APP start 
09-13 22:02:23.291-0400 W/AUL_AMD ( 2474): amd_request.c: __request_handler(669) > __request_handler: 14
09-13 22:02:23.301-0400 W/AUL_AMD ( 2474): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
09-13 22:02:23.301-0400 E/PKGMGR_SERVER( 5141): pkgmgr-server.c: req_cb(1153) > CHECK_KILL_APP done[return = 0] 
09-13 22:02:23.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:23.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:23.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:23.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:24.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:24.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:24.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:24.721-0400 W/AUL     ( 5193): launch.c: app_request_to_launchpad(284) > request cmd(0) to(edu.umich.edu.yctung.devapp)
09-13 22:02:24.721-0400 W/AUL_AMD ( 2474): amd_request.c: __request_handler(669) > __request_handler: 0
09-13 22:02:24.741-0400 I/AUL_AMD ( 2474): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
09-13 22:02:24.761-0400 I/AUL_AMD ( 2474): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
09-13 22:02:24.761-0400 E/AUL_AMD ( 2474): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-13 22:02:24.761-0400 W/AUL_AMD ( 2474): amd_launch.c: _start_app(1782) > caller pid : 5193
09-13 22:02:24.781-0400 W/AUL_AMD ( 2474): amd_launch.c: _start_app(2218) > pad pid(-4)
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: main(1382) > revents : 0x0, 0x1
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: main(1400) > pfds[LAUNCHPAD_FD].revents & POLLIN
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_SDK__, value: DEBUG
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: DEBUG, value: __DLP_DEBUG_ARG__
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __DLP_DEBUG_ARG__, value: :26109
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_STARTTIME__, value: 1505354544/733813
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_PKG_NAME__, value: edu.umich.edu.yctung.devapp
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_CALLER_PID__, value: 5193
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_HWACC__, value: SYS
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_TASKMANAGE__, value: true
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_EXEC__, value: /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_PACKAGETYPE__, value: rpm
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_INTERNAL_POOL__, value: false
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_PKGID_, value: edu.umich.edu.yctung.devapp
09-13 22:02:24.781-0400 E/DBG_PAD ( 3809): launchpad.c: prt_recvd_bundle(1134) > recvd - key: __AUL_HIGHPRIORITY__, value: false
09-13 22:02:24.781-0400 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data edu.umich.edu.yctung.devapp, table num : 4
09-13 22:02:24.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:24.791-0400 E/DBG_PAD ( 3809): launchpad.c: __prepare_fork(1013) > set DBG_LAUNCH_FLAG access label failed due to "Is a directory"
09-13 22:02:24.911-0400 W/AUL     ( 2474): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(edu.umich.edu.yctung.devapp) pid(5195) type(uiapp) bg(0)
09-13 22:02:24.911-0400 W/AUL     ( 5193): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5195)
09-13 22:02:24.931-0400 W/STARTER ( 2659): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [5195]
09-13 22:02:24.941-0400 W/AUL_AMD ( 2474): amd_request.c: __request_handler(669) > __request_handler: 14
09-13 22:02:24.961-0400 W/AUL_AMD ( 2474): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5195
09-13 22:02:24.961-0400 W/AUL_AMD ( 2474): amd_request.c: __request_handler(669) > __request_handler: 12
09-13 22:02:24.971-0400 W/AUL_AMD ( 2474): amd_request.c: __request_handler(669) > __request_handler: 14
09-13 22:02:24.991-0400 W/AUL_AMD ( 2474): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5195
09-13 22:02:24.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:24.991-0400 W/AUL_AMD ( 2474): amd_request.c: __request_handler(669) > __request_handler: 12
09-13 22:02:25.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:25.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:25.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:25.741-0400 E/PKGMGR_SERVER( 5141): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
09-13 22:02:25.741-0400 E/PKGMGR_SERVER( 5141): pkgmgr-server.c: main(2281) > package manager server terminated.
09-13 22:02:25.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:25.921-0400 W/AUL_AMD ( 2474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-13 22:02:25.921-0400 W/AUL_AMD ( 2474): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-13 22:02:25.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:26.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:26.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:26.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:26.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:26.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:27.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:27.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:27.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:27.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:27.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:28.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:28.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:28.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:28.591-0400 I/efl-extension( 5195): efl_extension.c: eext_mod_init(40) > Init
09-13 22:02:28.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:28.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:29.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:29.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:29.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:29.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:29.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:30.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:30.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:30.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:30.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:30.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:31.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:31.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:31.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:31.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:31.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:32.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:32.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:32.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:32.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:32.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:33.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:33.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:33.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:33.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:33.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:34.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:34.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:34.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:34.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:34.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:35.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:35.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:35.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:35.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:35.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:36.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:36.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:36.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:36.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:36.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:37.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:37.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:37.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:37.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:37.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:38.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:38.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:38.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:38.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:38.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:39.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:39.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:39.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:39.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:39.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:40.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:40.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:40.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:40.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:40.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:41.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:41.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:41.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:41.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:41.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:42.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:42.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:42.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:42.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:42.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:43.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:43.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:43.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:43.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:43.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:44.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:44.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:44.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:44.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:44.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:45.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:45.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:45.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:45.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:45.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:46.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:46.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:46.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:46.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:46.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:47.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:47.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:47.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:47.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:47.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:48.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:48.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:48.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:48.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:48.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:49.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:49.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:49.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:49.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:49.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:50.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:50.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:50.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:50.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:50.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:51.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:51.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:51.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:51.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:51.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:52.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:52.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:52.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:52.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:52.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:53.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:53.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:53.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:53.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:53.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:54.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:54.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:54.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:54.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:54.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:55.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:55.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:55.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:55.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:55.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:56.021-0400 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1505260800000.000000[0;m
09-13 22:02:56.041-0400 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (253052)]][0;m
09-13 22:02:56.081-0400 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
09-13 22:02:56.091-0400 W/SHealthWidget( 3402): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (253052), msgName: timeline_summary_updated[0;m
09-13 22:02:56.091-0400 W/SHealthCommon( 3402): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
09-13 22:02:56.091-0400 W/SHealthWidget( 3402): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
09-13 22:02:56.091-0400 W/WSLib   ( 3402): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1505340176099.000000, pattern:[HH:mm][0;m
09-13 22:02:56.091-0400 E/TIZEN_N_SYSTEM_SETTINGS( 3402): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-13 22:02:56.091-0400 E/TIZEN_N_SYSTEM_SETTINGS( 3402): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-13 22:02:56.091-0400 E/TIZEN_N_SYSTEM_SETTINGS( 3402): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-13 22:02:56.091-0400 E/TIZEN_N_SYSTEM_SETTINGS( 3402): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-13 22:02:56.091-0400 E/WSLib   ( 3402): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
09-13 22:02:56.091-0400 W/WSLib   ( 3402): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[22:02][0;m
09-13 22:02:56.091-0400 E/TIZEN_N_SYSTEM_SETTINGS( 3402): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
09-13 22:02:56.091-0400 E/TIZEN_N_SYSTEM_SETTINGS( 3402): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-13 22:02:56.091-0400 E/TIZEN_N_SYSTEM_SETTINGS( 3402): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
09-13 22:02:56.091-0400 E/TIZEN_N_SYSTEM_SETTINGS( 3402): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
09-13 22:02:56.091-0400 I/CAPI_WIDGET_APPLICATION( 3402): widget_app.c: __provider_update_cb(281) > received updating signal
09-13 22:02:56.101-0400 I/HealthDataService( 3005): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
09-13 22:02:56.121-0400 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
09-13 22:02:56.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:56.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:56.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:56.791-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:56.991-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:57.041-0400 I/CAPI_APPFW_APPLICATION( 5195): app_main.c: ui_app_main(704) > app_efl_main
09-13 22:02:57.101-0400 I/UXT     ( 5195): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
09-13 22:02:57.191-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:57.331-0400 W/AUL_AMD ( 2474): amd_status.c: __socket_monitor_cb(1277) > (5195) was created
09-13 22:02:57.331-0400 I/CAPI_APPFW_APPLICATION( 5195): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
09-13 22:02:57.391-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:57.531-0400 E/EFL     ( 5195): ecore_evas<5195> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
09-13 22:02:57.581-0400 D/devapp  ( 5195): label is added
09-13 22:02:57.591-0400 I/CAPI_WATCH_APPLICATION( 3088): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-13 22:02:57.601-0400 D/devapp  ( 5195): button is added
09-13 22:02:57.601-0400 I/APP_CORE( 5195): appcore-efl.c: __do_app(453) > [APP 5195] Event: RESET State: CREATED
09-13 22:02:57.601-0400 I/CAPI_APPFW_APPLICATION( 5195): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
09-13 22:02:57.621-0400 D/chronograph( 3088): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(124) > [0;32mBEGIN >>>>[0;m
09-13 22:02:57.621-0400 D/chronograph( 3088): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(137) > mSweep60SStartValue[57.566002] mCurrentValue[57.626999]
09-13 22:02:57.621-0400 D/chronograph( 3088): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(178) > speed up/down by 0.365982 degree in 60 seconds
09-13 22:02:57.631-0400 I/APP_CORE( 5195): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
09-13 22:02:57.631-0400 I/APP_CORE( 5195): appcore-efl.c: __do_app(524) > [APP 5195] Initial Launching, call the resume_cb
09-13 22:02:57.631-0400 I/CAPI_APPFW_APPLICATION( 5195): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
09-13 22:02:57.641-0400 W/W_HOME  ( 2933): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
09-13 22:02:57.641-0400 W/W_HOME  ( 2933): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-13 22:02:57.641-0400 W/W_HOME  ( 2933): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-13 22:02:57.641-0400 W/W_HOME  ( 2933): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-13 22:02:57.641-0400 W/W_HOME  ( 2933): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
09-13 22:02:57.641-0400 W/W_INDICATOR( 2660): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
09-13 22:02:57.641-0400 W/W_INDICATOR( 2660): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
09-13 22:02:57.651-0400 W/APP_CORE( 5195): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2600002
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): event_manager.c: _window_visibility_cb(473) > Window [0x1200003] is now visible(1)
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-13 22:02:57.701-0400 I/APP_CORE( 5195): appcore-efl.c: __do_app(453) > [APP 5195] Event: RESUME State: RUNNING
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): main.c: _window_visibility_cb(964) > Window [0x1200003] is now visible(1)
09-13 22:02:57.701-0400 I/APP_CORE( 2933): appcore-efl.c: __do_app(453) > [APP 2933] Event: PAUSE State: RUNNING
09-13 22:02:57.701-0400 I/CAPI_APPFW_APPLICATION( 2933): app_main.c: app_appcore_pause(202) > app_appcore_pause
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): main.c: _appcore_pause_cb(488) > appcore pause
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): main.c: home_pause(547) > clock/widget paused
09-13 22:02:57.701-0400 W/W_HOME  ( 2933): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-13 22:02:57.701-0400 W/W_INDICATOR( 2660): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
09-13 22:02:57.701-0400 W/W_INDICATOR( 2660): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
09-13 22:02:57.701-0400 I/MESSAGE_PORT( 2464): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-13 22:02:57.701-0400 I/MESSAGE_PORT( 2464): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-13 22:02:57.701-0400 I/MESSAGE_PORT( 2464): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-13 22:02:57.701-0400 I/MESSAGE_PORT( 2464): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-13 22:02:57.701-0400 I/MESSAGE_PORT( 2464): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-13 22:02:57.701-0400 I/MESSAGE_PORT( 2464): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-13 22:02:57.701-0400 I/MESSAGE_PORT( 2464): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-13 22:02:57.701-0400 I/MESSAGE_PORT( 2464): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-13 22:02:57.701-0400 W/AUL     ( 2474): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2933) status(bg) type(uiapp)
09-13 22:02:57.711-0400 W/STARTER ( 2659): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2933] goes to (4)
09-13 22:02:57.711-0400 E/STARTER ( 2659): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2933)'s state(4)
09-13 22:02:57.711-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1247.971365] layer(0x410f48) now usable
09-13 22:02:57.711-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1247.971387] layer[0x4109e8]zpos[0]
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-13 22:02:57.711-0400 I/MESSAGE_PORT( 2464): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-13 22:02:57.711-0400 I/wnotib  ( 2933): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
09-13 22:02:57.711-0400 E/wnotib  ( 2933): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-13 22:02:57.711-0400 W/wnotib  ( 2933): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [1].
09-13 22:02:57.711-0400 W/STARTER ( 2659): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[5195] goes to (3)
09-13 22:02:57.711-0400 W/AUL_AMD ( 2474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-13 22:02:57.711-0400 W/AUL_AMD ( 2474): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
09-13 22:02:57.711-0400 W/AUL     ( 2474): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(edu.umich.edu.yctung.devapp) pid(5195) status(fg) type(uiapp)
09-13 22:02:57.721-0400 W/WATCH_CORE( 3088): appcore-watch.c: __widget_pause(1113) > widget_pause
09-13 22:02:57.721-0400 W/AUL     ( 3088): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(3088) status(bg) type(watchapp)
09-13 22:02:57.721-0400 D/chronograph( 3088): ChronographApp.cpp: _appPause(150) > [0;34m>>>HIT<<<[0;m
09-13 22:02:57.721-0400 W/chronograph( 3088): ChronographViewController.cpp: onPause(183) > [0;35mState is Pause[isPaused=1], StopwatchState=0[0;m
09-13 22:02:57.721-0400 W/chronograph( 3088): ChronographSweepSecond.cpp: resetSweepSecond(103) > [0;35mresetSweepSecond >>>>[0;m
09-13 22:02:57.721-0400 D/chronograph( 3088): ChronographSweepSecond.cpp: resetSweepSecond(107) > Stop and Clear sweepAnimation !!
09-13 22:02:57.721-0400 D/chronograph-common( 3088): ChronographSensor.cpp: disableAcceleormeter(52) > [0;32mBEGIN >>>>[0;m
09-13 22:02:57.721-0400 D/chronograph-common( 3088): ChronographSensor.cpp: _stopAccelerometer(129) > [0;32mBEGIN >>>>[0;m
09-13 22:02:57.731-0400 E/CAPI_APPFW_APP_CONTROL( 3391): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
09-13 22:02:57.741-0400 W/MUSIC_CONTROL_SERVICE( 3391): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3391]   [com.samsung.w-home]register msg port [false][0m
09-13 22:02:58.091-0400 E/AUL     ( 2474): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-13 22:02:58.211-0400 I/APP_CORE( 2933): appcore-efl.c: __do_app(453) > [APP 2933] Event: MEM_FLUSH State: PAUSED
09-13 22:03:00.521-0400 E/EFL     ( 5195): ecore_x<5195> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1250786 button=1
09-13 22:03:00.631-0400 E/EFL     ( 5195): ecore_x<5195> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1250891 button=1
09-13 22:03:01.631-0400 E/EFL     ( 2312): ecore_x<2312> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2600002 time=1250891
09-13 22:03:02.711-0400 I/APP_CORE( 2933): appcore-efl.c: __do_app(453) > [APP 2933] Event: MEM_FLUSH State: PAUSED
09-13 22:03:11.641-0400 E/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_dbus_msg_send(315) > [PROCESSMGR] pointed_win=0x2600002 Send kill command to the ResourceD! PID=5195 Name=edu.umich.edu.yctung.devapp
09-13 22:03:11.641-0400 E/RESOURCED( 2582): proc-monitor.c: proc_dbus_watchdog_handler(838) > Receive watchdog signal to pid: 5195(devapp)
09-13 22:03:11.641-0400 E/RESOURCED( 2582): proc-monitor.c: proc_dbus_watchdog_handler(854) > just kill watchdog process when debug enabled pid: 5195(devapp)
09-13 22:03:18.761-0400 W/CRASH_MANAGER( 5206): worker.c: worker_job(1199) > 0605195646576150535459
