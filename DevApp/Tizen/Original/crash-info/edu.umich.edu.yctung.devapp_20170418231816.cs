S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: devapp
PID: 7146
Date: 2017-04-18 23:18:16-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7146, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000002
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xf75b26e0, r5   = 0xf70229d8
r6   = 0xf0bec100, r7   = 0xf0beba48
r8   = 0xf70229e8, r9   = 0xf75b2768
r10  = 0xf70229e8, fp   = 0x00000000
ip   = 0xf0bec184, sp   = 0xf0beb9a0
lr   = 0xf5f3cf35, pc   = 0xf5f3cf38
cpsr = 0x00000030

Memory Information
MemTotal:   714608 KB
MemFree:     24668 KB
Buffers:     39252 KB
Cached:     222268 KB
VmPeak:     124880 KB
VmSize:     124876 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32580 KB
VmRSS:       32580 KB
VmData:      46624 KB
VmStk:        6952 KB
VmExe:          20 KB
VmLib:       25324 KB
VmPTE:         148 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 7146 TID = 7248
7146 7237 7238 7240 7247 7248 

Maps Information
f03ee000 f0bed000 rw-p [stack:7248]
f0bee000 f13ed000 rw-p [stack:7247]
f13ed000 f13f8000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1507000 f1509000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1511000 f1512000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f151a000 f1522000 r-xp /usr/lib/libfeedback.so.0.1.4
f153b000 f153c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f15fa000 f1df9000 rw-p [stack:7240]
f21fb000 f29fa000 rw-p [stack:7238]
f2dfc000 f35fb000 rw-p [stack:7237]
f36bd000 f36d4000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f36e1000 f36e6000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f36ee000 f36f9000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3a21000 f3b13000 r-xp /usr/lib/libCOREGL.so.4.0
f3b2c000 f3b31000 r-xp /usr/lib/libsystem.so.0.0.0
f3b3b000 f3b3c000 r-xp /usr/lib/libresponse.so.0.2.96
f3b44000 f3b49000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3b52000 f3b54000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3b5c000 f3b63000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3b6c000 f3b8e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3b97000 f3b9f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3ba7000 f3bad000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3bb6000 f3bbb000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3bc3000 f3be4000 r-xp /usr/lib/libexif.so.12.3.3
f3bf7000 f3c10000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3c18000 f3c1d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3c25000 f3c2b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3c33000 f3c37000 r-xp /usr/lib/libogg.so.0.7.1
f3c3f000 f3c61000 r-xp /usr/lib/libvorbis.so.0.4.3
f3c69000 f3c6b000 r-xp /usr/lib/libttrace.so.1.1
f3c73000 f3c75000 r-xp /usr/lib/libdri2.so.0.0.0
f3c7d000 f3c85000 r-xp /usr/lib/libdrm.so.2.4.0
f3c8d000 f3c8e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3c97000 f3c9a000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3ca2000 f3cb1000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3cba000 f3d01000 r-xp /usr/lib/libsndfile.so.1.0.26
f3d0d000 f3d56000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3d5f000 f3d64000 r-xp /usr/lib/libjson.so.0.0.1
f3d6c000 f3d6f000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3d77000 f3d7d000 r-xp /usr/lib/libxcb-render.so.0.0.0
f3d85000 f3d86000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f3d8f000 f3d93000 r-xp /usr/lib/libEGL.so.1.4
f3da3000 f3db4000 r-xp /usr/lib/libGLESv2.so.2.0
f3dc4000 f3dcf000 r-xp /usr/lib/libtbm.so.1.0.0
f3dd7000 f3dfa000 r-xp /usr/lib/libui-extension.so.0.1.0
f3e03000 f3e19000 r-xp /usr/lib/libtts.so
f3e22000 f3e6a000 r-xp /usr/lib/libmdm.so.1.2.62
f56fc000 f5802000 r-xp /usr/lib/libicuuc.so.57.1
f5818000 f59a0000 r-xp /usr/lib/libicui18n.so.57.1
f59b0000 f59bd000 r-xp /usr/lib/libail.so.0.1.0
f59c6000 f59c9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f59d1000 f5a09000 r-xp /usr/lib/libpulse.so.0.16.2
f5a0a000 f5a0d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5a15000 f5a76000 r-xp /usr/lib/libasound.so.2.0.0
f5a80000 f5a96000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5a9e000 f5aa5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5aad000 f5ab1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5ab9000 f5ac4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5ad1000 f5ad5000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5ade000 f5ae5000 r-xp /usr/lib/libminizip.so.1.0.0
f5aed000 f5ba5000 r-xp /usr/lib/libcairo.so.2.11200.14
f5bb0000 f5bc2000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5bca000 f5bcf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5bd7000 f5bee000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5c00000 f5c05000 r-xp /usr/lib/libstorage.so.0.1
f5c0d000 f5c2e000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5c36000 f5c3d000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f5c48000 f5c53000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5ded000 f5df7000 r-xp /lib/libnss_files-2.13.so
f5e00000 f5ecf000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5ee5000 f5f09000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5f12000 f5f18000 r-xp /usr/lib/libappsvc.so.0.1.0
f5f20000 f5f22000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5f2b000 f5f2f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5f3b000 f5f3e000 r-xp /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
f5f4e000 f5f50000 r-xp /usr/lib/libiniparser.so.0
f5f59000 f5f5e000 r-xp /usr/lib/libappcore-common.so.1.1
f5f67000 f5f6f000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5f70000 f5f74000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5f81000 f5f83000 r-xp /usr/lib/libXau.so.6.0.0
f5f8b000 f5f92000 r-xp /lib/libcrypt-2.13.so
f5fc2000 f5fc4000 r-xp /usr/lib/libiri.so
f5fcd000 f6176000 r-xp /usr/lib/libcrypto.so.1.0.0
f6196000 f61dd000 r-xp /usr/lib/libssl.so.1.0.0
f61e9000 f6217000 r-xp /usr/lib/libidn.so.11.5.44
f621f000 f6228000 r-xp /usr/lib/libcares.so.2.1.0
f6232000 f6245000 r-xp /usr/lib/libxcb.so.1.1.0
f624e000 f6250000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6258000 f625a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6263000 f632f000 r-xp /usr/lib/libxml2.so.2.7.8
f633c000 f633e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6347000 f634c000 r-xp /usr/lib/libffi.so.5.0.10
f6354000 f6355000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f635d000 f6360000 r-xp /lib/libattr.so.1.1.0
f6368000 f63fc000 r-xp /usr/lib/libstdc++.so.6.0.16
f640f000 f642c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6436000 f644e000 r-xp /usr/lib/libpng12.so.0.50.0
f6456000 f646c000 r-xp /lib/libexpat.so.1.6.0
f6476000 f64ba000 r-xp /usr/lib/libcurl.so.4.3.0
f64c3000 f64cd000 r-xp /usr/lib/libXext.so.6.4.0
f64d6000 f64da000 r-xp /usr/lib/libXtst.so.6.1.0
f64e2000 f64e8000 r-xp /usr/lib/libXrender.so.1.3.0
f64f0000 f64f6000 r-xp /usr/lib/libXrandr.so.2.2.0
f64fe000 f64ff000 r-xp /usr/lib/libXinerama.so.1.0.0
f6508000 f6511000 r-xp /usr/lib/libXi.so.6.1.0
f6519000 f651c000 r-xp /usr/lib/libXfixes.so.3.1.0
f6524000 f6526000 r-xp /usr/lib/libXgesture.so.7.0.0
f652e000 f6530000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6538000 f653a000 r-xp /usr/lib/libXdamage.so.1.1.0
f6542000 f6549000 r-xp /usr/lib/libXcursor.so.1.0.2
f6551000 f6554000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f655c000 f6560000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6569000 f656e000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6577000 f6658000 r-xp /usr/lib/libX11.so.6.3.0
f6663000 f6686000 r-xp /usr/lib/libjpeg.so.8.0.2
f669e000 f66b4000 r-xp /lib/libz.so.1.2.5
f66bc000 f66be000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66c6000 f673b000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6745000 f675f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6767000 f679b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f67a4000 f6877000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6882000 f6892000 r-xp /lib/libresolv-2.13.so
f6896000 f68ae000 r-xp /usr/lib/liblzma.so.5.0.3
f68b6000 f68b9000 r-xp /lib/libcap.so.2.21
f68c1000 f68f0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68f8000 f68f9000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6901000 f6907000 r-xp /usr/lib/libecore_imf.so.1.7.99
f690f000 f6926000 r-xp /usr/lib/liblua-5.1.so
f692f000 f6936000 r-xp /usr/lib/libembryo.so.1.7.99
f693e000 f6944000 r-xp /lib/librt-2.13.so
f694d000 f69a3000 r-xp /usr/lib/libpixman-1.so.0.28.2
f69b0000 f6a06000 r-xp /usr/lib/libfreetype.so.6.11.3
f6a12000 f6a3a000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6a3b000 f6a80000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6a89000 f6a9c000 r-xp /usr/lib/libfribidi.so.0.3.1
f6aa4000 f6abe000 r-xp /usr/lib/libecore_con.so.1.7.99
f6ac7000 f6ad0000 r-xp /usr/lib/libedbus.so.1.7.99
f6ad8000 f6b28000 r-xp /usr/lib/libecore_x.so.1.7.99
f6b2a000 f6b33000 r-xp /usr/lib/libvconf.so.0.2.45
f6b3b000 f6b4c000 r-xp /usr/lib/libecore_input.so.1.7.99
f6b54000 f6b59000 r-xp /usr/lib/libecore_file.so.1.7.99
f6b61000 f6b83000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6b8c000 f6bcd000 r-xp /usr/lib/libeina.so.1.7.99
f6bd6000 f6bef000 r-xp /usr/lib/libeet.so.1.7.99
f6c00000 f6c69000 r-xp /lib/libm-2.13.so
f6c72000 f6c78000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c81000 f6c82000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c8a000 f6cad000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cb5000 f6cba000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cc2000 f6cec000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cf5000 f6d0c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d14000 f6d1f000 r-xp /lib/libunwind.so.8.0.1
f6d4c000 f6d6a000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d74000 f6e98000 r-xp /lib/libc-2.13.so
f6ea6000 f6eae000 r-xp /lib/libgcc_s-4.6.so.1
f6eaf000 f6eb3000 r-xp /usr/lib/libsmack.so.1.0.0
f6ebc000 f6ec2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6eca000 f6f9a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f9b000 f6ff9000 r-xp /usr/lib/libedje.so.1.7.99
f7003000 f701a000 r-xp /usr/lib/libecore.so.1.7.99
f7031000 f70ff000 r-xp /usr/lib/libevas.so.1.7.99
f7124000 f7260000 r-xp /usr/lib/libelementary.so.1.7.99
f7277000 f728b000 r-xp /lib/libpthread-2.13.so
f7296000 f7298000 r-xp /usr/lib/libdlog.so.0.0.0
f72a0000 f72a3000 r-xp /usr/lib/libbundle.so.0.1.22
f72ab000 f72ad000 r-xp /lib/libdl-2.13.so
f72b6000 f72c3000 r-xp /usr/lib/libaul.so.0.1.0
f72d4000 f72da000 r-xp /usr/lib/libappcore-efl.so.1.1
f72e3000 f72e7000 r-xp /usr/lib/libsys-assert.so
f72f0000 f730d000 r-xp /lib/ld-2.13.so
f7316000 f731b000 r-xp /usr/bin/launchpad-loader
f7480000 f7656000 rw-p [heap]
ff794000 ffe5d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7146)
Call Stack Count: 1
 0: _keep_reading_socket + 0x233 (0xf5f3cf38) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1f38
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
endMessage(138) > MessagePort SendMessage
04-18 23:18:02.529-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-18 23:18:02.529-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-18 23:18:02.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:02.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:02.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:03.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:03.279-0400 W/KEYROUTER( 2304): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x2000003
04-18 23:18:03.279-0400 W/KEYROUTER( 2304): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x1000002
04-18 23:18:03.279-0400 E/EFL     ( 2706): ecore_x<2706> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=6477632
04-18 23:18:03.279-0400 W/STARTER ( 2598): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
04-18 23:18:03.279-0400 W/STARTER ( 2598): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
04-18 23:18:03.279-0400 W/STARTER ( 2598): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
04-18 23:18:03.279-0400 W/W_HOME  ( 2706): main.c: _direct_home_key_cb(1447) > was_win_on_top:1
04-18 23:18:03.279-0400 E/STARTER ( 2598): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
04-18 23:18:03.279-0400 W/STARTER ( 2598): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
04-18 23:18:03.279-0400 W/STARTER ( 2598): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
04-18 23:18:03.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:03.449-0400 W/KEYROUTER( 2304): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1000002
04-18 23:18:03.449-0400 W/KEYROUTER( 2304): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x2000003
04-18 23:18:03.459-0400 W/STARTER ( 2598): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
04-18 23:18:03.459-0400 E/EFL     ( 2706): ecore_x<2706> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=6477808
04-18 23:18:03.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:03.709-0400 W/STARTER ( 2598): hw_key.c: _powerkey_timer_cb(922) > [_powerkey_timer_cb:922] _powerkey_timer_cb, powerkey count[1]
04-18 23:18:03.709-0400 W/STARTER ( 2598): hw_key.c: _powerkey_timer_cb(1132) > [_powerkey_timer_cb:1132] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
04-18 23:18:03.719-0400 E/STARTER ( 2598): dbus-util.c: dbus_request_cpu_boost(292) > [dbus_request_cpu_boost:292] failed to _invoke_dbus_method_sync
04-18 23:18:03.719-0400 W/AUL     ( 2598): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
04-18 23:18:03.719-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-18 23:18:03.719-0400 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 2598
04-18 23:18:03.719-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2706) type(uiapp) bg(0)
04-18 23:18:03.729-0400 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2706
04-18 23:18:03.729-0400 I/APP_CORE( 2706): appcore-efl.c: __do_app(453) > [APP 2706] Event: RESET State: RUNNING
04-18 23:18:03.729-0400 I/CAPI_APPFW_APPLICATION( 2706): app_main.c: app_appcore_reset(245) > app_appcore_reset
04-18 23:18:03.729-0400 W/CAPI_APPFW_APP_CONTROL( 2706): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-18 23:18:03.729-0400 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(17), pid(2706), cmd(0)
04-18 23:18:03.729-0400 W/AUL     ( 2598): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2706)
04-18 23:18:03.729-0400 W/STARTER ( 2598): pkg-monitor.c: _app_mgr_status_cb(415) > [_app_mgr_status_cb:415] Resume request [2706]
04-18 23:18:03.729-0400 W/W_HOME  ( 2706): main.c: _app_control_progress(1571) > Service value : powerkey
04-18 23:18:03.729-0400 W/wnotib  ( 2706): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40001
04-18 23:18:03.729-0400 E/wnotib  ( 2706): w-notification-board-action.c: wnb_action_is_popup_shown(4738) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-18 23:18:03.729-0400 E/wnotib  ( 2706): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-18 23:18:03.729-0400 W/wnotib  ( 2706): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
04-18 23:18:03.729-0400 W/W_HOME  ( 2706): noti_broker.c: _noti_broker_home_cb(779) > continue the home key execution
04-18 23:18:03.729-0400 E/W_HOME  ( 2706): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
04-18 23:18:03.729-0400 W/W_HOME  ( 2706): main.c: _home_key_cb(1469) > Home Key operation tutorial:0 window:1 clock:1 apps:0 is_app_resumed:1
04-18 23:18:03.729-0400 W/W_HOME  ( 2706): move.c: move_move_to_apps(216) > move to apps
04-18 23:18:03.729-0400 W/W_HOME  ( 2706): rotary.c: rotary_attach(138) > rotary_attach:0xf85ad1c8
04-18 23:18:03.729-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf85ad1c8, elm_layout, _activated_obj : 0xf838cc90, activated : 1
04-18 23:18:03.729-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-18 23:18:03.729-0400 W/W_HOME  ( 2706): event_manager.c: _move_module_anim_start_cb(673) > state: 0 -> 1
04-18 23:18:03.729-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-18 23:18:03.729-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-18 23:18:03.729-0400 W/APPS    ( 2706): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-18 23:18:03.729-0400 E/AUL     ( 2478): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-18 23:18:03.729-0400 W/W_INDICATOR( 2601): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-18 23:18:03.729-0400 W/W_INDICATOR( 2601): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-18 23:18:03.739-0400 I/APP_CORE( 2706): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
04-18 23:18:03.739-0400 W/W_HOME  ( 2706): event_manager.c: _apptray_visibility_cb(611) > apps,show,start
04-18 23:18:03.739-0400 W/W_HOME  ( 2706): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 0
04-18 23:18:03.739-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-18 23:18:03.749-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-18 23:18:03.749-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-18 23:18:03.749-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-18 23:18:03.749-0400 W/W_HOME  ( 2706): clock_manager.c: _compositing_set(205) > hwc:0
04-18 23:18:03.749-0400 W/W_HOME  ( 2706): noti_broker.c: _apptray_visibility_cb(786) > apps,show,start
04-18 23:18:03.749-0400 W/W_HOME  ( 2706): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80002
04-18 23:18:03.749-0400 W/wnotib  ( 2706): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80002
04-18 23:18:03.749-0400 I/wnotib  ( 2706): w-notification-board-broker-main.c: _wnotib_view_event_handler(1418) > Unhandled type: 0x80002
04-18 23:18:03.749-0400 E/AUL     ( 2598): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-18 23:18:03.749-0400 W/W_INDICATOR( 2601): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-18 23:18:03.749-0400 W/W_INDICATOR( 2601): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-18 23:18:03.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:03.839-0400 W/W_HOME  ( 2706): clock_manager.c: _hwc_disabled_timer_cb(125) > hwc disabled
04-18 23:18:03.849-0400 I/TDM     ( 1955): tdm_display.c: tdm_layer_unset_buffer(1602) > [6478.201791] layer(0x6bb1a0) now usable
04-18 23:18:03.849-0400 I/TDM     ( 1955): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [6478.201815] layer[0x6bac40]zpos[0]
04-18 23:18:03.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): event_manager.c: _move_module_anim_end_cb(687) > state: 1 -> 0
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): rotary.c: rotary_deattach(156) > rotary_deattach:0xf85ad1c8
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf85ad1c8, elm_layout, func : 0xf768252d
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf838cc90, elm_box, _activated_obj : 0xf85ad1c8, activated : 1
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-18 23:18:04.019-0400 E/wnotib  ( 2706): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-18 23:18:04.019-0400 I/wnotib  ( 2706): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): event_manager.c: _apptray_visibility_cb(611) > apps,show
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 1
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:04.019-0400 W/W_INDICATOR( 2601): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): main.c: home_pause(547) > clock/widget paused
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:04.019-0400 W/APPS    ( 2706): apps_main.c: _time_changed_cb(308) >  date : 18->18
04-18 23:18:04.019-0400 W/APPS    ( 2706): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-18 23:18:04.019-0400 W/W_HOME  ( 2706): rotary.c: rotary_attach(138) > rotary_attach:0xf844dba0
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf844dba0, elm_layout, _activated_obj : 0xf838cc90, activated : 1
04-18 23:18:04.019-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-18 23:18:04.029-0400 W/W_INDICATOR( 2601): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-18 23:18:04.029-0400 W/W_HOME  ( 2706): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-18 23:18:04.029-0400 W/W_HOME  ( 2706): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-18 23:18:04.029-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:04.029-0400 W/W_HOME  ( 2706): noti_broker.c: _apptray_visibility_cb(786) > apps,show
04-18 23:18:04.029-0400 W/W_HOME  ( 2706): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80000
04-18 23:18:04.029-0400 W/wnotib  ( 2706): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80000
04-18 23:18:04.029-0400 I/wnotib  ( 2706): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
04-18 23:18:04.029-0400 W/wnotib  ( 2706): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-18 23:18:04.029-0400 E/APPS    ( 2706): apps_main.c: apps_main_resume(1003) >  resumed already
04-18 23:18:04.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:04.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:04.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:04.729-0400 W/AUL_AMD ( 2478): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-18 23:18:04.729-0400 W/AUL_AMD ( 2478): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
04-18 23:18:04.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:04.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:05.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:05.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:05.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:05.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:05.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:06.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:06.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:06.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:06.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:06.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:07.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:07.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:07.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:07.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:07.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:08.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:08.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:08.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:08.679-0400 E/PKGMGR_SERVER( 7187): pkgmgr-server.c: main(2227) > package manager server start
04-18 23:18:08.759-0400 E/PKGMGR_SERVER( 7187): pkgmgr-server.c: req_cb(1134) > KILL_APP start 
04-18 23:18:08.779-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-18 23:18:08.789-0400 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7042
04-18 23:18:08.789-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-18 23:18:08.789-0400 W/AUL     ( 7187): launch.c: app_request_to_launchpad(284) > request cmd(5) to(7042)
04-18 23:18:08.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:08.789-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 5
04-18 23:18:08.789-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(edu.umich.edu.yctung.devapp) pid(7042) type(uiapp)
04-18 23:18:08.789-0400 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(17), pid(7042), cmd(4)
04-18 23:18:08.789-0400 I/APP_CORE( 7042): appcore-efl.c: __do_app(453) > [APP 7042] Event: TERMINATE State: PAUSED
04-18 23:18:08.789-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-18 23:18:08.789-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-18 23:18:08.799-0400 W/APP_CORE( 7042): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-18 23:18:08.799-0400 W/AUL     ( 7187): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
04-18 23:18:08.799-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-18 23:18:08.809-0400 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7042
04-18 23:18:08.809-0400 W/APP_CORE( 7042): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3000002] -> redirected win[60f276] for edu.umich.edu.yctung.devapp[7042]
04-18 23:18:08.839-0400 I/APP_CORE( 7042): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-18 23:18:08.839-0400 I/CAPI_APPFW_APPLICATION( 7042): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-18 23:18:08.839-0400 I/APP_CORE( 7042): appcore-efl.c: __after_loop(1243) > [APP 7042] After terminate() callback
04-18 23:18:08.889-0400 I/UXT     ( 7042): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-18 23:18:08.909-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-18 23:18:08.919-0400 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7042
04-18 23:18:08.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:08.999-0400 I/efl-extension( 7042): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-18 23:18:09.009-0400 W/AUL_PAD ( 7042): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-18 23:18:09.019-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-18 23:18:09.039-0400 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-18 23:18:09.039-0400 E/PKGMGR_SERVER( 7187): pkgmgr-server.c: req_cb(1153) > CHECK_KILL_APP done[return = 0] 
04-18 23:18:09.039-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7042 pgid = 7042
04-18 23:18:09.039-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-18 23:18:09.119-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-18 23:18:09.139-0400 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7042
04-18 23:18:09.139-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7042)
04-18 23:18:09.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:09.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:09.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:09.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:09.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:09.999-0400 W/AUL     ( 7236): launch.c: app_request_to_launchpad(284) > request cmd(0) to(edu.umich.edu.yctung.devapp)
04-18 23:18:09.999-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-18 23:18:10.009-0400 I/AUL_AMD ( 2478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
04-18 23:18:10.019-0400 I/AUL_AMD ( 2478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
04-18 23:18:10.019-0400 E/AUL_AMD ( 2478): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
04-18 23:18:10.019-0400 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 7236
04-18 23:18:10.029-0400 W/AUL_AMD ( 2478): amd_launch.c: _start_app(2218) > pad pid(-5)
04-18 23:18:10.029-0400 W/AUL_PAD ( 3282): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
04-18 23:18:10.029-0400 W/AUL_PAD ( 3282): launchpad.c: __send_result_to_caller(272) > Check app launching
04-18 23:18:10.039-0400 W/AUL_PAD ( 7146): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
04-18 23:18:10.039-0400 W/AUL_PAD ( 7146): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
04-18 23:18:10.039-0400 W/AUL_PAD ( 7146): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
04-18 23:18:10.039-0400 W/AUL_PAD ( 7146): launchpad_loader.c: main(680) > [candidate] dlopen(edu.umich.edu.yctung.devapp)
04-18 23:18:10.039-0400 E/RESOURCED( 2593): block.c: block_prelaunch_state(138) > insert data edu.umich.edu.yctung.devapp, table num : 1
04-18 23:18:10.099-0400 I/efl-extension( 7146): efl_extension.c: eext_mod_init(40) > Init
04-18 23:18:10.099-0400 I/UXT     ( 7146): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-18 23:18:10.099-0400 W/AUL_PAD ( 7146): launchpad_loader.c: main(690) > [candidate] dlsym
04-18 23:18:10.099-0400 W/AUL_PAD ( 7146): launchpad_loader.c: main(694) > [candidate] dl_main(edu.umich.edu.yctung.devapp)
04-18 23:18:10.119-0400 I/CAPI_APPFW_APPLICATION( 7146): app_main.c: ui_app_main(704) > app_efl_main
04-18 23:18:10.119-0400 I/CAPI_APPFW_APPLICATION( 7146): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-18 23:18:10.139-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(edu.umich.edu.yctung.devapp) pid(7146) type(uiapp) bg(0)
04-18 23:18:10.139-0400 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (7146) was created
04-18 23:18:10.139-0400 W/AUL     ( 7236): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7146)
04-18 23:18:10.159-0400 W/STARTER ( 2598): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [7146]
04-18 23:18:10.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:10.229-0400 E/EFL     ( 7146): ecore_evas<7146> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
04-18 23:18:10.259-0400 D/devapp  ( 7146): label is added
04-18 23:18:10.269-0400 D/devapp  ( 7146): button is added
04-18 23:18:10.339-0400 I/TIZEN_N_AUDIO_IO( 7146): audio_io_private.c: audio_in_create_private(289) > mm_sound_pcm_capture_open_ex() success
04-18 23:18:10.339-0400 I/TIZEN_N_AUDIO_IO( 7146): audio_io_private.c: audio_in_create_private(306) > mm_sound_pcm_set_message_callback() success
04-18 23:18:10.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:10.389-0400 I/TIZEN_N_AUDIO_IO( 7146): audio_io_private.c: audio_out_create_private(402) > mm_sound_pcm_play_open() success
04-18 23:18:10.389-0400 I/TIZEN_N_AUDIO_IO( 7146): audio_io_private.c: audio_out_create_private(415) > mm_sound_pcm_set_message_callback() success
04-18 23:18:10.409-0400 I/TIZEN_N_AUDIO_IO( 7146): audio_io.c: audio_in_get_buffer_size(170) > [audio_in_get_buffer_size] buffer size = 4410
04-18 23:18:10.409-0400 D/devapp  ( 7146): buffer_size = 4410
04-18 23:18:10.429-0400 I/APP_CORE( 7146): appcore-efl.c: __do_app(453) > [APP 7146] Event: RESET State: CREATED
04-18 23:18:10.429-0400 I/CAPI_APPFW_APPLICATION( 7146): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-18 23:18:10.459-0400 I/APP_CORE( 7146): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-18 23:18:10.459-0400 I/APP_CORE( 7146): appcore-efl.c: __do_app(524) > [APP 7146] Initial Launching, call the resume_cb
04-18 23:18:10.459-0400 I/CAPI_APPFW_APPLICATION( 7146): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-18 23:18:10.469-0400 W/W_HOME  ( 2706): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
04-18 23:18:10.469-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:10.469-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:10.469-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:10.469-0400 W/W_HOME  ( 2706): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-18 23:18:10.469-0400 W/W_HOME  ( 2706): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
04-18 23:18:10.479-0400 W/W_INDICATOR( 2601): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-18 23:18:10.479-0400 W/W_INDICATOR( 2601): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-18 23:18:10.479-0400 W/APP_CORE( 7146): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(1)
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(327) > appcore paused manually
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): main.c: home_appcore_pause(515) > Home Appcore Paused
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:10.559-0400 W/W_HOME  ( 2706): rotary.c: rotary_deattach(156) > rotary_deattach:0xf844dba0
04-18 23:18:10.559-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-18 23:18:10.559-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf844dba0, elm_layout, func : 0xf768252d
04-18 23:18:10.559-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-18 23:18:10.559-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-18 23:18:10.559-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-18 23:18:10.559-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf838cc90, elm_box, _activated_obj : 0xf844dba0, activated : 1
04-18 23:18:10.559-0400 I/efl-extension( 2706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-18 23:18:10.559-0400 E/wnotib  ( 2706): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-18 23:18:10.559-0400 I/wnotib  ( 2706): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
04-18 23:18:10.569-0400 I/APP_CORE( 7146): appcore-efl.c: __do_app(453) > [APP 7146] Event: RESUME State: RUNNING
04-18 23:18:10.569-0400 W/W_INDICATOR( 2601): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-18 23:18:10.569-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2706) status(bg) type(uiapp)
04-18 23:18:10.579-0400 W/STARTER ( 2598): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2706] goes to (4)
04-18 23:18:10.579-0400 E/STARTER ( 2598): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2706)'s state(4)
04-18 23:18:10.579-0400 W/STARTER ( 2598): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[7146] goes to (3)
04-18 23:18:10.579-0400 W/W_HOME  ( 2706): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-18 23:18:10.589-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-18 23:18:10.589-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-18 23:18:10.589-0400 I/MESSAGE_PORT( 2472): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-18 23:18:10.589-0400 I/MESSAGE_PORT( 2472): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-18 23:18:10.589-0400 I/MESSAGE_PORT( 2472): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-18 23:18:10.589-0400 I/MESSAGE_PORT( 2472): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-18 23:18:10.589-0400 I/MESSAGE_PORT( 2472): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-18 23:18:10.589-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-18 23:18:10.589-0400 W/AUL_AMD ( 2478): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-18 23:18:10.589-0400 W/AUL_AMD ( 2478): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-18 23:18:10.589-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(edu.umich.edu.yctung.devapp) pid(7146) status(fg) type(uiapp)
04-18 23:18:10.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-18 23:18:10.599-0400 I/MESSAGE_PORT( 2472): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-18 23:18:10.599-0400 E/CAPI_APPFW_APP_CONTROL( 2898): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-18 23:18:10.599-0400 W/MUSIC_CONTROL_SERVICE( 2898): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2898]   [com.samsung.w-home]register msg port [false][0m
04-18 23:18:10.599-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-18 23:18:10.599-0400 W/W_HOME  ( 2706): main.c: _window_visibility_cb(964) > Window [0x2000003] is now visible(1)
04-18 23:18:10.609-0400 I/APP_CORE( 2706): appcore-efl.c: __do_app(453) > [APP 2706] Event: PAUSE State: RUNNING
04-18 23:18:10.609-0400 I/CAPI_APPFW_APPLICATION( 2706): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-18 23:18:10.609-0400 W/W_HOME  ( 2706): main.c: _appcore_pause_cb(488) > appcore pause
04-18 23:18:10.609-0400 E/W_HOME  ( 2706): main.c: _pause_cb(466) > paused already
04-18 23:18:10.609-0400 I/wnotib  ( 2706): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
04-18 23:18:10.609-0400 E/wnotib  ( 2706): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-18 23:18:10.609-0400 W/wnotib  ( 2706): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-18 23:18:10.609-0400 W/W_INDICATOR( 2601): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-18 23:18:10.629-0400 W/APPS    ( 2706): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
04-18 23:18:10.649-0400 E/PKGMGR_SERVER( 7187): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
04-18 23:18:10.649-0400 E/PKGMGR_SERVER( 7187): pkgmgr-server.c: main(2281) > package manager server terminated.
04-18 23:18:10.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:10.799-0400 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-18 23:18:10.939-0400 E/AUL     ( 2478): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-18 23:18:10.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:11.069-0400 E/WMS     ( 2431): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
04-18 23:18:11.099-0400 I/APP_CORE( 2706): appcore-efl.c: __do_app(453) > [APP 2706] Event: MEM_FLUSH State: PAUSED
04-18 23:18:11.199-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:11.229-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-18 23:18:11.239-0400 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7146
04-18 23:18:11.249-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-18 23:18:11.269-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-18 23:18:11.279-0400 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7146
04-18 23:18:11.279-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-18 23:18:11.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:11.469-0400 I/AUL_PAD ( 7244): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-18 23:18:11.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:11.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:11.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:12.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:12.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:12.569-0400 E/EFL     ( 7146): ecore_x<7146> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6486923 button=1
04-18 23:18:12.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:12.689-0400 E/EFL     ( 7146): ecore_x<7146> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=6487043 button=1
04-18 23:18:12.769-0400 D/devapp  ( 7146): button is clicked
04-18 23:18:12.779-0400 D/devapp  ( 7146): connect to server successfully
04-18 23:18:12.779-0400 D/devapp  ( 7146): temp = 83886080
04-18 23:18:12.779-0400 D/devapp  ( 7146): write to socket bytes n = 31 / 31
04-18 23:18:12.779-0400 D/devapp  ( 7146): _keep_reading_socket starts
04-18 23:18:12.779-0400 D/devapp  ( 7146): wait to read action
04-18 23:18:12.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:12.849-0400 D/devapp  ( 7146): n = 1, reaction = 1
04-18 23:18:12.849-0400 D/devapp  ( 7146): reaction == LIBAS_REACTION_SET_MEDIA
04-18 23:18:12.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:13.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:13.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:13.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:13.689-0400 E/EFL     ( 2304): ecore_x<2304> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3c00002 time=6487043
04-18 23:18:13.689-0400 E/EFL     ( 7146): ecore_x<7146> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=6487043
04-18 23:18:13.689-0400 E/EFL     ( 2304): ecore_x<2304> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=6487043
04-18 23:18:13.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:13.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:14.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:14.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:14.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:14.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:14.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:15.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:15.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:15.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:15.609-0400 I/APP_CORE( 2706): appcore-efl.c: __do_app(453) > [APP 2706] Event: MEM_FLUSH State: PAUSED
04-18 23:18:15.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:15.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:16.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:16.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:16.569-0400 D/devapp  ( 7146): FS = -2135228416, chCnt = 2, repeatCnt = 4800
04-18 23:18:16.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:16.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:16.839-0400 W/WATCH_CORE( 2781): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-18 23:18:16.839-0400 I/WATCH_CORE( 2781): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-18 23:18:16.839-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:16.839-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7146 pgid = 7146
04-18 23:18:16.839-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-18 23:18:16.859-0400 W/AUL_AMD ( 2478): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-18 23:18:16.859-0400 W/AUL_AMD ( 2478): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-18 23:18:16.859-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2706) status(fg) type(uiapp)
04-18 23:18:16.859-0400 W/STARTER ( 2598): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2706] goes to (3)
04-18 23:18:16.859-0400 E/STARTER ( 2598): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2706)'s state(3)
04-18 23:18:16.939-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-18 23:18:16.939-0400 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7146
04-18 23:18:16.939-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7146)
04-18 23:18:16.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 23:18:16.999-0400 W/CRASH_MANAGER( 7250): worker.c: worker_job(1199) > 1107146646576149257189
