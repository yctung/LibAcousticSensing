S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: firsttizenhello
PID: 13554
Date: 2017-04-07 15:19:38-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13554, uid 5000)

Register Information
r0   = 0x00000023, r1   = 0x00000000
r2   = 0x5c99bf00, r3   = 0x5c99bf00
r4   = 0x00000003, r5   = 0xf61c9770
r6   = 0xf7cad6b8, r7   = 0xffd29a50
r8   = 0x00000000, r9   = 0xf7d145e0
r10  = 0xf7d14090, fp   = 0x00000001
ip   = 0xf6209084, sp   = 0xffd299e8
lr   = 0xf61c9613, pc   = 0xf61c9616
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     10992 KB
Buffers:     51028 KB
Cached:     172272 KB
VmPeak:     109148 KB
VmSize:     109144 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25524 KB
VmRSS:       25520 KB
VmData:      38272 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25300 KB
VmPTE:         128 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 13554 TID = 13554
13554 13704 13705 13707 13709 

Maps Information
f0f8e000 f178d000 rw-p [stack:13709]
f178d000 f1798000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f17a0000 f17a2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f17aa000 f17ab000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f17b3000 f17bb000 r-xp /usr/lib/libfeedback.so.0.1.4
f17d4000 f17d5000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1893000 f2092000 rw-p [stack:13707]
f2494000 f2c93000 rw-p [stack:13705]
f3095000 f3894000 rw-p [stack:13704]
f3956000 f396d000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f397a000 f397f000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3987000 f3992000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3cba000 f3dac000 r-xp /usr/lib/libCOREGL.so.4.0
f3dc5000 f3dca000 r-xp /usr/lib/libsystem.so.0.0.0
f3dd4000 f3dd5000 r-xp /usr/lib/libresponse.so.0.2.96
f3ddd000 f3de2000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3deb000 f3df2000 r-xp /usr/lib/libminizip.so.1.0.0
f3dfa000 f3dfc000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3e04000 f3e0b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3e14000 f3e36000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3e3f000 f3e47000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3e4f000 f3e55000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3e5e000 f3e63000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3e6b000 f3e8c000 r-xp /usr/lib/libexif.so.12.3.3
f3e9f000 f3eb8000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3ec0000 f3ec5000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3ecd000 f3ed3000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3edb000 f3edf000 r-xp /usr/lib/libogg.so.0.7.1
f3ee7000 f3f09000 r-xp /usr/lib/libvorbis.so.0.4.3
f3f11000 f3f13000 r-xp /usr/lib/libttrace.so.1.1
f3f1b000 f3f1d000 r-xp /usr/lib/libdri2.so.0.0.0
f3f25000 f3f2d000 r-xp /usr/lib/libdrm.so.2.4.0
f3f35000 f3f36000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3f3f000 f3f42000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3f4a000 f3f59000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3f62000 f3fa9000 r-xp /usr/lib/libsndfile.so.1.0.26
f3fb5000 f3ffe000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f4007000 f400c000 r-xp /usr/lib/libjson.so.0.0.1
f4014000 f4017000 r-xp /usr/lib/libtinycompress.so.0.0.0
f401f000 f4025000 r-xp /usr/lib/libxcb-render.so.0.0.0
f402d000 f402e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f4037000 f403b000 r-xp /usr/lib/libEGL.so.1.4
f404b000 f405c000 r-xp /usr/lib/libGLESv2.so.2.0
f406c000 f4077000 r-xp /usr/lib/libtbm.so.1.0.0
f407f000 f40a2000 r-xp /usr/lib/libui-extension.so.0.1.0
f40ab000 f40c1000 r-xp /usr/lib/libtts.so
f40ca000 f4112000 r-xp /usr/lib/libmdm.so.1.2.62
f59a4000 f5aaa000 r-xp /usr/lib/libicuuc.so.57.1
f5ac0000 f5c48000 r-xp /usr/lib/libicui18n.so.57.1
f5c58000 f5c65000 r-xp /usr/lib/libail.so.0.1.0
f5c6e000 f5c71000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f5c79000 f5cb1000 r-xp /usr/lib/libpulse.so.0.16.2
f5cb2000 f5cb5000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5cbd000 f5d1e000 r-xp /usr/lib/libasound.so.2.0.0
f5d28000 f5d3e000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5d46000 f5d4d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5d55000 f5d59000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5d61000 f5d6c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5d79000 f5d7d000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5d86000 f5e3e000 r-xp /usr/lib/libcairo.so.2.11200.14
f5e49000 f5e5b000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5e63000 f5e68000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5e70000 f5e87000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5e99000 f5eba000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5ec2000 f5ec9000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f5ed4000 f5edf000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f6079000 f6083000 r-xp /lib/libnss_files-2.13.so
f608c000 f615b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f6171000 f6195000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f619e000 f61a4000 r-xp /usr/lib/libappsvc.so.0.1.0
f61ac000 f61ae000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f61b7000 f61bb000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f61c8000 f61ca000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
f61da000 f61dc000 r-xp /usr/lib/libiniparser.so.0
f61e5000 f61ea000 r-xp /usr/lib/libappcore-common.so.1.1
f61f3000 f61fb000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f61fc000 f6200000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f620d000 f620f000 r-xp /usr/lib/libXau.so.6.0.0
f6217000 f621e000 r-xp /lib/libcrypt-2.13.so
f624e000 f6250000 r-xp /usr/lib/libiri.so
f6259000 f6402000 r-xp /usr/lib/libcrypto.so.1.0.0
f6422000 f6469000 r-xp /usr/lib/libssl.so.1.0.0
f6475000 f64a3000 r-xp /usr/lib/libidn.so.11.5.44
f64ab000 f64b4000 r-xp /usr/lib/libcares.so.2.1.0
f64be000 f64d1000 r-xp /usr/lib/libxcb.so.1.1.0
f64da000 f64dc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f64e4000 f64e6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f64ef000 f65bb000 r-xp /usr/lib/libxml2.so.2.7.8
f65c8000 f65ca000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f65d3000 f65d8000 r-xp /usr/lib/libffi.so.5.0.10
f65e0000 f65e1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f65e9000 f65ec000 r-xp /lib/libattr.so.1.1.0
f65f4000 f6688000 r-xp /usr/lib/libstdc++.so.6.0.16
f669b000 f66b8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66c2000 f66da000 r-xp /usr/lib/libpng12.so.0.50.0
f66e2000 f66f8000 r-xp /lib/libexpat.so.1.6.0
f6702000 f6746000 r-xp /usr/lib/libcurl.so.4.3.0
f674f000 f6759000 r-xp /usr/lib/libXext.so.6.4.0
f6762000 f6766000 r-xp /usr/lib/libXtst.so.6.1.0
f676e000 f6774000 r-xp /usr/lib/libXrender.so.1.3.0
f677c000 f6782000 r-xp /usr/lib/libXrandr.so.2.2.0
f678a000 f678b000 r-xp /usr/lib/libXinerama.so.1.0.0
f6794000 f679d000 r-xp /usr/lib/libXi.so.6.1.0
f67a5000 f67a8000 r-xp /usr/lib/libXfixes.so.3.1.0
f67b0000 f67b2000 r-xp /usr/lib/libXgesture.so.7.0.0
f67ba000 f67bc000 r-xp /usr/lib/libXcomposite.so.1.0.0
f67c4000 f67c6000 r-xp /usr/lib/libXdamage.so.1.1.0
f67ce000 f67d5000 r-xp /usr/lib/libXcursor.so.1.0.2
f67dd000 f67e0000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f67e8000 f67ec000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f67f5000 f67fa000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6803000 f68e4000 r-xp /usr/lib/libX11.so.6.3.0
f68ef000 f6912000 r-xp /usr/lib/libjpeg.so.8.0.2
f692a000 f6940000 r-xp /lib/libz.so.1.2.5
f6948000 f694a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6952000 f69c7000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69d1000 f69eb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69f3000 f6a27000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6a30000 f6b03000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b0e000 f6b1e000 r-xp /lib/libresolv-2.13.so
f6b22000 f6b3a000 r-xp /usr/lib/liblzma.so.5.0.3
f6b42000 f6b45000 r-xp /lib/libcap.so.2.21
f6b4d000 f6b7c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b84000 f6b85000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6b8d000 f6b93000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6b9b000 f6bb2000 r-xp /usr/lib/liblua-5.1.so
f6bbb000 f6bc2000 r-xp /usr/lib/libembryo.so.1.7.99
f6bca000 f6bd0000 r-xp /lib/librt-2.13.so
f6bd9000 f6c2f000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6c3c000 f6c92000 r-xp /usr/lib/libfreetype.so.6.11.3
f6c9e000 f6cc6000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6cc7000 f6d0c000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6d15000 f6d28000 r-xp /usr/lib/libfribidi.so.0.3.1
f6d30000 f6d4a000 r-xp /usr/lib/libecore_con.so.1.7.99
f6d53000 f6d5c000 r-xp /usr/lib/libedbus.so.1.7.99
f6d64000 f6db4000 r-xp /usr/lib/libecore_x.so.1.7.99
f6db6000 f6dbf000 r-xp /usr/lib/libvconf.so.0.2.45
f6dc7000 f6dd8000 r-xp /usr/lib/libecore_input.so.1.7.99
f6de0000 f6de5000 r-xp /usr/lib/libecore_file.so.1.7.99
f6ded000 f6e0f000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6e18000 f6e59000 r-xp /usr/lib/libeina.so.1.7.99
f6e62000 f6e7b000 r-xp /usr/lib/libeet.so.1.7.99
f6e8c000 f6ef5000 r-xp /lib/libm-2.13.so
f6efe000 f6f04000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f0d000 f6f0e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f16000 f6f39000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f41000 f6f46000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f4e000 f6f78000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f81000 f6f98000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fa0000 f6fab000 r-xp /lib/libunwind.so.8.0.1
f6fd8000 f6ff6000 r-xp /usr/lib/libsystemd.so.0.4.0
f7000000 f7124000 r-xp /lib/libc-2.13.so
f7132000 f713a000 r-xp /lib/libgcc_s-4.6.so.1
f713b000 f713f000 r-xp /usr/lib/libsmack.so.1.0.0
f7148000 f714e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f7156000 f7226000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7227000 f7285000 r-xp /usr/lib/libedje.so.1.7.99
f728f000 f72a6000 r-xp /usr/lib/libecore.so.1.7.99
f72bd000 f738b000 r-xp /usr/lib/libevas.so.1.7.99
f73b0000 f74ec000 r-xp /usr/lib/libelementary.so.1.7.99
f7503000 f7517000 r-xp /lib/libpthread-2.13.so
f7522000 f7524000 r-xp /usr/lib/libdlog.so.0.0.0
f752c000 f752f000 r-xp /usr/lib/libbundle.so.0.1.22
f7537000 f7539000 r-xp /lib/libdl-2.13.so
f7542000 f754f000 r-xp /usr/lib/libaul.so.0.1.0
f7560000 f7566000 r-xp /usr/lib/libappcore-efl.so.1.1
f756f000 f7573000 r-xp /usr/lib/libsys-assert.so
f757c000 f7599000 r-xp /lib/ld-2.13.so
f75a2000 f75a7000 r-xp /usr/bin/launchpad-loader
f7bad000 f7d5f000 rw-p [heap]
ffd0a000 ffd2b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13554)
Call Stack Count: 17
 0: button_clicked_request_cb + 0x3d (0xf61c9616) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1616
 1: evas_object_smart_callback_call + 0x88 (0xf72f25cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf726cf0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf7270efd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf726d869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf726dc1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf726dd55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf729a3f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf7297e53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf729b46b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf729b879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf7563b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf61fe421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x12e (0xf61c91eb) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x11eb
14: (0xf75a3a53) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1a53
15: __libc_start_main + 0x114 (0xf701785c) [/lib/libc.so.6] + 0x1785c
16: (0xf75a3e0c) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1e0c
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
IpcRequestReceived(147) > MessagePort message received
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-07 15:19:33.531-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-07 15:19:33.531-0400 W/W_HOME  ( 2844): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-07 15:19:33.531-0400 E/W_HOME  ( 2844): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-07 15:19:33.531-0400 W/MUSIC_CONTROL_SERVICE( 6281): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:6281]   [MUSIC_PLAYER_EVENT][0m
04-07 15:19:33.541-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6281): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-07 15:19:33.541-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6281): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-07 15:19:33.541-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6281): preference.c: preference_get_int(1132) > preference_get_int(6281) : key(music-control-service_native/playing_diration) error
04-07 15:19:33.541-0400 W/MUSIC_CONTROL_SERVICE( 6281): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:6281]   preference_get_int() .. [0xfef00030][0m
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-07 15:19:33.541-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-07 15:19:33.541-0400 W/W_HOME  ( 2844): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-07 15:19:33.541-0400 E/W_HOME  ( 2844): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-07 15:19:33.551-0400 I/TIZEN_N_SOUND_MANAGER( 6281): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-07 15:19:33.551-0400 W/TIZEN_N_SOUND_MANAGER( 6281): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-07 15:19:33.551-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-07 15:19:33.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:33.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:33.851-0400 W/KEYROUTER( 2269): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x2200003
04-07 15:19:33.851-0400 E/EFL     ( 2844): ecore_x<2844> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=20341400
04-07 15:19:33.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:34.031-0400 W/KEYROUTER( 2269): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x2200003
04-07 15:19:34.031-0400 E/EFL     ( 2844): ecore_x<2844> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=20341580
04-07 15:19:34.031-0400 W/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40000
04-07 15:19:34.031-0400 I/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_view_event_handler(1382) > On the cover view. Go to home.
04-07 15:19:34.031-0400 W/W_HOME  ( 2844): noti_broker.c: _noti_broker_back_cb(762) > continue the back key execution
04-07 15:19:34.031-0400 E/W_HOME  ( 2844): cs_broker.c: _cs_broker_back_cb(258) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
04-07 15:19:34.031-0400 W/W_HOME  ( 2844): main.c: _back_key_cb(1386) > emit:signal => key,back,clicked
04-07 15:19:34.031-0400 W/W_HOME  ( 2844): clock_event.c: _back_key_cb(287) > 
04-07 15:19:34.041-0400 W/WATCH_CORE( 2893): appcore-watch.c: __widget_text_signal_cb(1140) > widget_text_signal
04-07 15:19:34.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:34.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:34.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:34.731-0400 W/KEYROUTER( 2269): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x2200003
04-07 15:19:34.731-0400 W/KEYROUTER( 2269): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x1e00002
04-07 15:19:34.731-0400 W/STARTER ( 2804): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
04-07 15:19:34.731-0400 W/STARTER ( 2804): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
04-07 15:19:34.731-0400 E/EFL     ( 2844): ecore_x<2844> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=20342282
04-07 15:19:34.731-0400 W/W_HOME  ( 2844): main.c: _direct_home_key_cb(1447) > was_win_on_top:1
04-07 15:19:34.731-0400 W/STARTER ( 2804): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
04-07 15:19:34.731-0400 E/STARTER ( 2804): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
04-07 15:19:34.731-0400 W/STARTER ( 2804): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
04-07 15:19:34.731-0400 W/STARTER ( 2804): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
04-07 15:19:34.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:34.951-0400 W/KEYROUTER( 2269): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1e00002
04-07 15:19:34.951-0400 W/KEYROUTER( 2269): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x2200003
04-07 15:19:34.951-0400 E/EFL     ( 2844): ecore_x<2844> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=20342501
04-07 15:19:34.951-0400 W/STARTER ( 2804): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
04-07 15:19:34.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:35.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:35.201-0400 W/STARTER ( 2804): hw_key.c: _powerkey_timer_cb(922) > [_powerkey_timer_cb:922] _powerkey_timer_cb, powerkey count[1]
04-07 15:19:35.211-0400 W/STARTER ( 2804): hw_key.c: _powerkey_timer_cb(1132) > [_powerkey_timer_cb:1132] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
04-07 15:19:35.211-0400 E/STARTER ( 2804): dbus-util.c: dbus_request_cpu_boost(292) > [dbus_request_cpu_boost:292] failed to _invoke_dbus_method_sync
04-07 15:19:35.211-0400 W/AUL     ( 2804): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
04-07 15:19:35.211-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 0
04-07 15:19:35.211-0400 W/AUL_AMD ( 2434): amd_launch.c: _start_app(1782) > caller pid : 2804
04-07 15:19:35.221-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2844) type(uiapp) bg(0)
04-07 15:19:35.221-0400 W/AUL_AMD ( 2434): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2844
04-07 15:19:35.221-0400 W/AUL_AMD ( 2434): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(22), pid(2844), cmd(0)
04-07 15:19:35.221-0400 I/APP_CORE( 2844): appcore-efl.c: __do_app(453) > [APP 2844] Event: RESET State: RUNNING
04-07 15:19:35.221-0400 I/CAPI_APPFW_APPLICATION( 2844): app_main.c: app_appcore_reset(245) > app_appcore_reset
04-07 15:19:35.221-0400 W/CAPI_APPFW_APP_CONTROL( 2844): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-07 15:19:35.221-0400 E/AUL     ( 2434): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-07 15:19:35.221-0400 W/W_HOME  ( 2844): main.c: _app_control_progress(1571) > Service value : powerkey
04-07 15:19:35.221-0400 W/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40001
04-07 15:19:35.221-0400 E/wnotib  ( 2844): w-notification-board-action.c: wnb_action_is_popup_shown(4738) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-07 15:19:35.221-0400 E/wnotib  ( 2844): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-07 15:19:35.221-0400 W/wnotib  ( 2844): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
04-07 15:19:35.221-0400 W/W_HOME  ( 2844): noti_broker.c: _noti_broker_home_cb(779) > continue the home key execution
04-07 15:19:35.221-0400 E/W_HOME  ( 2844): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
04-07 15:19:35.221-0400 W/W_HOME  ( 2844): main.c: _home_key_cb(1469) > Home Key operation tutorial:0 window:1 clock:1 apps:0 is_app_resumed:1
04-07 15:19:35.221-0400 W/W_HOME  ( 2844): move.c: move_move_to_apps(216) > move to apps
04-07 15:19:35.221-0400 W/W_HOME  ( 2844): rotary.c: rotary_attach(138) > rotary_attach:0xf7db9cf0
04-07 15:19:35.221-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7db9cf0, elm_layout, _activated_obj : 0xf7b6cf38, activated : 1
04-07 15:19:35.221-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-07 15:19:35.221-0400 W/W_HOME  ( 2844): event_manager.c: _move_module_anim_start_cb(673) > state: 0 -> 1
04-07 15:19:35.221-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:19:35.221-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:19:35.221-0400 W/APPS    ( 2844): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-07 15:19:35.231-0400 W/W_INDICATOR( 2817): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-07 15:19:35.231-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-07 15:19:35.231-0400 W/AUL     ( 2804): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2844)
04-07 15:19:35.231-0400 W/STARTER ( 2804): pkg-monitor.c: _app_mgr_status_cb(415) > [_app_mgr_status_cb:415] Resume request [2844]
04-07 15:19:35.231-0400 I/APP_CORE( 2844): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
04-07 15:19:35.231-0400 W/W_HOME  ( 2844): event_manager.c: _apptray_visibility_cb(611) > apps,show,start
04-07 15:19:35.241-0400 W/W_HOME  ( 2844): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 0
04-07 15:19:35.241-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:19:35.241-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:19:35.241-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:19:35.241-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:19:35.241-0400 W/W_HOME  ( 2844): clock_manager.c: _compositing_set(205) > hwc:0
04-07 15:19:35.241-0400 W/W_HOME  ( 2844): noti_broker.c: _apptray_visibility_cb(786) > apps,show,start
04-07 15:19:35.241-0400 W/W_HOME  ( 2844): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80002
04-07 15:19:35.241-0400 W/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80002
04-07 15:19:35.241-0400 I/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_view_event_handler(1418) > Unhandled type: 0x80002
04-07 15:19:35.251-0400 E/AUL     ( 2804): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-07 15:19:35.251-0400 W/W_INDICATOR( 2817): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-07 15:19:35.251-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-07 15:19:35.341-0400 W/W_HOME  ( 2844): clock_manager.c: _hwc_disabled_timer_cb(125) > hwc disabled
04-07 15:19:35.351-0400 I/TDM     ( 1375): tdm_display.c: tdm_layer_unset_buffer(1602) > [20342.904754] layer(0x8c91a0) now usable
04-07 15:19:35.351-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20342.904783] layer[0x8c8c40]zpos[0]
04-07 15:19:35.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:35.521-0400 W/W_HOME  ( 2844): event_manager.c: _move_module_anim_end_cb(687) > state: 1 -> 0
04-07 15:19:35.521-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:19:35.521-0400 W/W_HOME  ( 2844): rotary.c: rotary_deattach(156) > rotary_deattach:0xf7db9cf0
04-07 15:19:35.521-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-07 15:19:35.521-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7db9cf0, elm_layout, func : 0xf728e52d
04-07 15:19:35.521-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-07 15:19:35.521-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-07 15:19:35.521-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-07 15:19:35.521-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7b6cf38, elm_box, _activated_obj : 0xf7db9cf0, activated : 1
04-07 15:19:35.521-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-07 15:19:35.521-0400 E/wnotib  ( 2844): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-07 15:19:35.521-0400 I/wnotib  ( 2844): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6237) > Return true for 92, -1005.
04-07 15:19:35.521-0400 I/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
04-07 15:19:35.531-0400 W/W_HOME  ( 2844): event_manager.c: _apptray_visibility_cb(611) > apps,show
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 1
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): main.c: home_pause(547) > clock/widget paused
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:35.541-0400 W/APPS    ( 2844): apps_main.c: _time_changed_cb(308) >  date : 7->7
04-07 15:19:35.541-0400 W/APPS    ( 2844): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): rotary.c: rotary_attach(138) > rotary_attach:0xefa08640
04-07 15:19:35.541-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xefa08640, elm_layout, _activated_obj : 0xf7b6cf38, activated : 1
04-07 15:19:35.541-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): noti_broker.c: _apptray_visibility_cb(786) > apps,show
04-07 15:19:35.541-0400 W/W_HOME  ( 2844): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80000
04-07 15:19:35.541-0400 W/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80000
04-07 15:19:35.541-0400 E/wnotib  ( 2844): w-notification-board-action.c: wnb_action_is_event_receivable(5108) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-07 15:19:35.541-0400 I/wnotib  ( 2844): w-notification-board-basic-panel.c: _wnb_basic_panel_close_second_depth_view(6316) > wnotib_action_drawer_is_event_receivable: 0, third_depth_genlist: (nil), _wnotib_basic_panel_is_third_depth_thread_view: 0, wnotib_common_is_toast_popup_displayed: 0
04-07 15:19:35.541-0400 E/wnotib  ( 2844): w-notification-board-action.c: wnb_action_is_event_receivable(5108) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-07 15:19:35.541-0400 I/wnotib  ( 2844): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
04-07 15:19:35.541-0400 W/wnotib  ( 2844): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [71], notiboard card appending count [647].
04-07 15:19:35.541-0400 E/APPS    ( 2844): apps_main.c: apps_main_resume(1003) >  resumed already
04-07 15:19:35.541-0400 W/W_INDICATOR( 2817): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-07 15:19:35.541-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-07 15:19:35.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:35.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:35.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:36.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:36.221-0400 W/AUL_AMD ( 2434): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-07 15:19:36.221-0400 W/AUL_AMD ( 2434): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
04-07 15:19:36.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:36.411-0400 E/EFL     ( 2844): ecore_x<2844> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20343955 button=1
04-07 15:19:36.411-0400 W/APPS    ( 2844): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [55, 214]
04-07 15:19:36.581-0400 E/EFL     ( 2844): ecore_x<2844> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20344121 button=1
04-07 15:19:36.581-0400 W/APPS    ( 2844): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [55, 214]->[59, 214]
04-07 15:19:36.581-0400 W/APPS    ( 2844): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[14], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[16]
04-07 15:19:36.581-0400 W/APPS    ( 2844): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,14]
04-07 15:19:36.581-0400 E/APPS    ( 2844): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
04-07 15:19:36.581-0400 W/APPS    ( 2844): AppsItem.cpp: onItemClicked(487) >  item(firsttizenhello) launched, open(0), tts(0)
04-07 15:19:36.581-0400 W/AUL     ( 2844): launch.c: app_request_to_launchpad(284) > request cmd(0) to(edu.umich.edu.yctung.firsttizenhellp)
04-07 15:19:36.581-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 0
04-07 15:19:36.581-0400 W/AUL_AMD ( 2434): amd_launch.c: _start_app(1782) > caller pid : 2844
04-07 15:19:36.581-0400 I/AUL_AMD ( 2434): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
04-07 15:19:36.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:36.591-0400 E/RESOURCED( 2664): block.c: block_prelaunch_state(138) > insert data edu.umich.edu.yctung.firsttizenhellp, table num : 3
04-07 15:19:36.591-0400 W/AUL_AMD ( 2434): amd_launch.c: _start_app(2218) > pad pid(-5)
04-07 15:19:36.591-0400 W/AUL_PAD ( 3271): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
04-07 15:19:36.591-0400 W/AUL_PAD ( 3271): launchpad.c: __send_result_to_caller(272) > Check app launching
04-07 15:19:36.591-0400 W/AUL_PAD (13554): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
04-07 15:19:36.591-0400 W/AUL_PAD (13554): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
04-07 15:19:36.591-0400 W/AUL_PAD (13554): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
04-07 15:19:36.591-0400 W/AUL_PAD (13554): launchpad_loader.c: main(680) > [candidate] dlopen(edu.umich.edu.yctung.firsttizenhellp)
04-07 15:19:36.641-0400 I/efl-extension(13554): efl_extension.c: eext_mod_init(40) > Init
04-07 15:19:36.641-0400 I/UXT     (13554): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-07 15:19:36.641-0400 W/AUL_PAD (13554): launchpad_loader.c: main(690) > [candidate] dlsym
04-07 15:19:36.641-0400 W/AUL_PAD (13554): launchpad_loader.c: main(694) > [candidate] dl_main(edu.umich.edu.yctung.firsttizenhellp)
04-07 15:19:36.641-0400 I/CAPI_APPFW_APPLICATION(13554): app_main.c: ui_app_main(704) > app_efl_main
04-07 15:19:36.651-0400 I/CAPI_APPFW_APPLICATION(13554): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-07 15:19:36.691-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(edu.umich.edu.yctung.firsttizenhellp) pid(13554) type(uiapp) bg(0)
04-07 15:19:36.691-0400 W/AUL_AMD ( 2434): amd_status.c: __socket_monitor_cb(1277) > (13554) was created
04-07 15:19:36.691-0400 E/AUL     ( 2434): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-07 15:19:36.701-0400 W/AUL     ( 2844): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13554)
04-07 15:19:36.701-0400 W/W_HOME  ( 2844): util.c: apps_util_launch_main_operation(643) > Launch app:[firsttizenhello] ret:[0]
04-07 15:19:36.701-0400 W/STARTER ( 2804): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [13554]
04-07 15:19:36.741-0400 E/EFL     (13554): ecore_evas<13554> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
04-07 15:19:36.771-0400 D/firsttizenhello(13554): label is added
04-07 15:19:36.781-0400 D/firsttizenhello(13554): button is added
04-07 15:19:36.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:36.851-0400 I/TIZEN_N_AUDIO_IO(13554): audio_io_private.c: audio_in_create_private(289) > mm_sound_pcm_capture_open_ex() success
04-07 15:19:36.851-0400 I/TIZEN_N_AUDIO_IO(13554): audio_io_private.c: audio_in_create_private(306) > mm_sound_pcm_set_message_callback() success
04-07 15:19:36.881-0400 I/TIZEN_N_AUDIO_IO(13554): audio_io_private.c: audio_out_create_private(402) > mm_sound_pcm_play_open() success
04-07 15:19:36.881-0400 I/TIZEN_N_AUDIO_IO(13554): audio_io_private.c: audio_out_create_private(415) > mm_sound_pcm_set_message_callback() success
04-07 15:19:36.891-0400 I/TIZEN_N_AUDIO_IO(13554): audio_io.c: audio_in_get_buffer_size(170) > [audio_in_get_buffer_size] buffer size = 4410
04-07 15:19:36.891-0400 D/firsttizenhello(13554): buffer_size = 4410
04-07 15:19:36.901-0400 I/APP_CORE(13554): appcore-efl.c: __do_app(453) > [APP 13554] Event: RESET State: CREATED
04-07 15:19:36.901-0400 I/CAPI_APPFW_APPLICATION(13554): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-07 15:19:36.921-0400 I/APP_CORE(13554): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-07 15:19:36.921-0400 I/APP_CORE(13554): appcore-efl.c: __do_app(524) > [APP 13554] Initial Launching, call the resume_cb
04-07 15:19:36.921-0400 I/CAPI_APPFW_APPLICATION(13554): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-07 15:19:36.931-0400 W/W_HOME  ( 2844): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
04-07 15:19:36.931-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:36.931-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:36.931-0400 W/W_INDICATOR( 2817): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-07 15:19:36.931-0400 W/APP_CORE(13554): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
04-07 15:19:36.931-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:36.931-0400 W/W_HOME  ( 2844): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-07 15:19:36.931-0400 W/W_HOME  ( 2844): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
04-07 15:19:36.931-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-07 15:19:36.981-0400 W/W_HOME  ( 2844): event_manager.c: _window_visibility_cb(473) > Window [0x2200003] is now visible(1)
04-07 15:19:36.981-0400 W/W_HOME  ( 2844): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
04-07 15:19:36.981-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:36.981-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:36.981-0400 W/W_HOME  ( 2844): main.c: _window_visibility_cb(964) > Window [0x2200003] is now visible(1)
04-07 15:19:36.981-0400 I/APP_CORE(13554): appcore-efl.c: __do_app(453) > [APP 13554] Event: RESUME State: RUNNING
04-07 15:19:36.991-0400 I/APP_CORE( 2844): appcore-efl.c: __do_app(453) > [APP 2844] Event: PAUSE State: RUNNING
04-07 15:19:36.991-0400 I/CAPI_APPFW_APPLICATION( 2844): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-07 15:19:36.991-0400 W/W_HOME  ( 2844): main.c: _appcore_pause_cb(488) > appcore pause
04-07 15:19:36.991-0400 W/W_HOME  ( 2844): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
04-07 15:19:36.991-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:36.991-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:36.991-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-07 15:19:36.991-0400 W/W_HOME  ( 2844): rotary.c: rotary_deattach(156) > rotary_deattach:0xefa08640
04-07 15:19:36.991-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-07 15:19:36.991-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xefa08640, elm_layout, func : 0xf728e52d
04-07 15:19:36.991-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-07 15:19:36.991-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-07 15:19:36.991-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-07 15:19:36.991-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7b6cf38, elm_box, _activated_obj : 0xefa08640, activated : 1
04-07 15:19:36.991-0400 I/efl-extension( 2844): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-07 15:19:36.991-0400 E/wnotib  ( 2844): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-07 15:19:36.991-0400 I/wnotib  ( 2844): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6237) > Return true for 92, -1005.
04-07 15:19:36.991-0400 I/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
04-07 15:19:36.991-0400 W/W_INDICATOR( 2817): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-07 15:19:36.991-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-07 15:19:36.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:36.991-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2844) status(bg) type(uiapp)
04-07 15:19:36.991-0400 W/APPS    ( 2844): AppsItem.cpp: setLastIndex(1264) >  This is last index app [15:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[14]
04-07 15:19:36.991-0400 W/APPS    ( 2844): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
04-07 15:19:36.991-0400 W/APPS    ( 2844): AppsItem.cpp: aniFocusIndex(2351) >  [firsttizenhello:14] Focused[0], focusIdx[14]
04-07 15:19:37.001-0400 W/W_HOME  ( 2844): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-07 15:19:37.001-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-07 15:19:37.001-0400 W/STARTER ( 2804): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2844] goes to (4)
04-07 15:19:37.001-0400 E/STARTER ( 2804): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2844)'s state(4)
04-07 15:19:37.001-0400 I/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
04-07 15:19:37.001-0400 E/wnotib  ( 2844): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-07 15:19:37.001-0400 W/wnotib  ( 2844): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [71], notiboard card appending count [647].
04-07 15:19:37.001-0400 W/STARTER ( 2804): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[13554] goes to (3)
04-07 15:19:37.011-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(edu.umich.edu.yctung.firsttizenhellp) pid(13554) status(fg) type(uiapp)
04-07 15:19:37.011-0400 E/CAPI_APPFW_APP_CONTROL( 6281): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-07 15:19:37.021-0400 W/MUSIC_CONTROL_SERVICE( 6281): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:6281]   [com.samsung.w-home]register msg port [false][0m
04-07 15:19:37.041-0400 W/APPS    ( 2844): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
04-07 15:19:37.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:37.381-0400 E/AUL     ( 2434): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-07 15:19:37.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:37.501-0400 I/APP_CORE( 2844): appcore-efl.c: __do_app(453) > [APP 2844] Event: MEM_FLUSH State: PAUSED
04-07 15:19:37.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:37.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:37.791-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 14
04-07 15:19:37.811-0400 W/AUL_AMD ( 2434): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13554
04-07 15:19:37.811-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 14
04-07 15:19:37.821-0400 W/AUL_AMD ( 2434): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13554
04-07 15:19:37.831-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 12
04-07 15:19:37.831-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 12
04-07 15:19:37.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:38.021-0400 I/AUL_PAD (13708): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-07 15:19:38.061-0400 E/EFL     (13554): ecore_x<13554> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20345615 button=1
04-07 15:19:38.161-0400 E/EFL     (13554): ecore_x<13554> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20345716 button=1
04-07 15:19:38.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:38.251-0400 D/firsttizenhello(13554): button is clicked
04-07 15:19:38.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:38.521-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-07 15:19:38.521-0400 I/WATCH_CORE( 2893): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-07 15:19:38.521-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:38.521-0400 W/STARTER ( 2804): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2844] goes to (3)
04-07 15:19:38.521-0400 E/STARTER ( 2804): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2844)'s state(3)
04-07 15:19:38.521-0400 W/AUL_AMD ( 2434): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-07 15:19:38.521-0400 W/AUL_AMD ( 2434): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-07 15:19:38.521-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2844) status(fg) type(uiapp)
04-07 15:19:38.531-0400 W/AUL_PAD ( 3271): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 13554 pgid = 13554
04-07 15:19:38.531-0400 W/AUL_PAD ( 3271): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-07 15:19:38.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:19:38.611-0400 W/AUL_PAD ( 3271): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-07 15:19:38.641-0400 W/CRASH_MANAGER(13711): worker.c: worker_job(1199) > 1113554666972149159277
