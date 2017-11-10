S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: devapp
PID: 4068
Date: 2017-04-25 02:04:01-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 4068, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xff676cd0
r2   = 0x00000010, r3   = 0x55000000
r4   = 0xf620b42c, r5   = 0xf7c41cd0
r6   = 0xf7c0fc68, r7   = 0x0000011b
r8   = 0x00000000, r9   = 0xf7c76388
r10  = 0xf7c715e0, fp   = 0x00000001
ip   = 0x00000000, sp   = 0xff676bd0
lr   = 0xf7553aa4, pc   = 0xf7553ab4
cpsr = 0x80000010

Memory Information
MemTotal:   714608 KB
MemFree:      6984 KB
Buffers:     35688 KB
Cached:     209392 KB
VmPeak:     116708 KB
VmSize:     116704 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       33484 KB
VmRSS:       33480 KB
VmData:      38872 KB
VmStk:        6964 KB
VmExe:          20 KB
VmLib:       25340 KB
VmPTE:         140 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4068 TID = 4068
4068 4147 4148 4150 4235 

Maps Information
f0d7b000 f157a000 rw-p [stack:4235]
f157a000 f157b000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f16b0000 f16bb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f16c3000 f16c5000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f16cd000 f16ce000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f16d6000 f16de000 r-xp /usr/lib/libfeedback.so.0.1.4
f16f7000 f16f8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1807000 f180a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f18c8000 f20c7000 rw-p [stack:4150]
f24c9000 f2cc8000 rw-p [stack:4148]
f30ca000 f38c9000 rw-p [stack:4147]
f398b000 f39a2000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f39af000 f39b4000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f39bc000 f39c7000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3cef000 f3de1000 r-xp /usr/lib/libCOREGL.so.4.0
f3dfa000 f3dff000 r-xp /usr/lib/libsystem.so.0.0.0
f3e09000 f3e0a000 r-xp /usr/lib/libresponse.so.0.2.96
f3e12000 f3e17000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3e20000 f3e22000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3e2a000 f3e31000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3e3a000 f3e5c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3e65000 f3e6d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3e75000 f3e7b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3e84000 f3e89000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3e91000 f3eb2000 r-xp /usr/lib/libexif.so.12.3.3
f3ec5000 f3ede000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3ee6000 f3eeb000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3ef3000 f3ef9000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3f01000 f3f05000 r-xp /usr/lib/libogg.so.0.7.1
f3f0d000 f3f2f000 r-xp /usr/lib/libvorbis.so.0.4.3
f3f37000 f3f39000 r-xp /usr/lib/libttrace.so.1.1
f3f41000 f3f43000 r-xp /usr/lib/libdri2.so.0.0.0
f3f4b000 f3f53000 r-xp /usr/lib/libdrm.so.2.4.0
f3f5b000 f3f5c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3f65000 f3f68000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3f70000 f3f7f000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3f88000 f3fcf000 r-xp /usr/lib/libsndfile.so.1.0.26
f3fdb000 f4024000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f402d000 f4032000 r-xp /usr/lib/libjson.so.0.0.1
f403a000 f403d000 r-xp /usr/lib/libtinycompress.so.0.0.0
f4045000 f404b000 r-xp /usr/lib/libxcb-render.so.0.0.0
f4053000 f4054000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f405d000 f4061000 r-xp /usr/lib/libEGL.so.1.4
f4071000 f4082000 r-xp /usr/lib/libGLESv2.so.2.0
f4092000 f409d000 r-xp /usr/lib/libtbm.so.1.0.0
f40a5000 f40c8000 r-xp /usr/lib/libui-extension.so.0.1.0
f40d1000 f40e7000 r-xp /usr/lib/libtts.so
f40f0000 f4138000 r-xp /usr/lib/libmdm.so.1.2.62
f59ca000 f5ad0000 r-xp /usr/lib/libicuuc.so.57.1
f5ae6000 f5c6e000 r-xp /usr/lib/libicui18n.so.57.1
f5c7e000 f5c8b000 r-xp /usr/lib/libail.so.0.1.0
f5c94000 f5c97000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f5c9f000 f5cd7000 r-xp /usr/lib/libpulse.so.0.16.2
f5cd8000 f5cdb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5ce3000 f5d44000 r-xp /usr/lib/libasound.so.2.0.0
f5d4e000 f5d64000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5d6c000 f5d73000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5d7b000 f5d7f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5d87000 f5d92000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5d9f000 f5da3000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5dac000 f5db3000 r-xp /usr/lib/libminizip.so.1.0.0
f5dbb000 f5e73000 r-xp /usr/lib/libcairo.so.2.11200.14
f5e7e000 f5e90000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5e98000 f5e9d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5ea5000 f5ebc000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5ece000 f5ed3000 r-xp /usr/lib/libstorage.so.0.1
f5edb000 f5efc000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5f04000 f5f0b000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f5f16000 f5f21000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f60bb000 f60c5000 r-xp /lib/libnss_files-2.13.so
f60ce000 f619d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f61b3000 f61d7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f61e0000 f61e6000 r-xp /usr/lib/libappsvc.so.0.1.0
f61ee000 f61f0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f61f9000 f61fd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6209000 f620c000 r-xp /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
f621c000 f621e000 r-xp /usr/lib/libiniparser.so.0
f6227000 f622c000 r-xp /usr/lib/libappcore-common.so.1.1
f6235000 f623d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f623e000 f6242000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f624f000 f6251000 r-xp /usr/lib/libXau.so.6.0.0
f6259000 f6260000 r-xp /lib/libcrypt-2.13.so
f6290000 f6292000 r-xp /usr/lib/libiri.so
f629b000 f6444000 r-xp /usr/lib/libcrypto.so.1.0.0
f6464000 f64ab000 r-xp /usr/lib/libssl.so.1.0.0
f64b7000 f64e5000 r-xp /usr/lib/libidn.so.11.5.44
f64ed000 f64f6000 r-xp /usr/lib/libcares.so.2.1.0
f6500000 f6513000 r-xp /usr/lib/libxcb.so.1.1.0
f651c000 f651e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6526000 f6528000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6531000 f65fd000 r-xp /usr/lib/libxml2.so.2.7.8
f660a000 f660c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6615000 f661a000 r-xp /usr/lib/libffi.so.5.0.10
f6622000 f6623000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f662b000 f662e000 r-xp /lib/libattr.so.1.1.0
f6636000 f66ca000 r-xp /usr/lib/libstdc++.so.6.0.16
f66dd000 f66fa000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6704000 f671c000 r-xp /usr/lib/libpng12.so.0.50.0
f6724000 f673a000 r-xp /lib/libexpat.so.1.6.0
f6744000 f6788000 r-xp /usr/lib/libcurl.so.4.3.0
f6791000 f679b000 r-xp /usr/lib/libXext.so.6.4.0
f67a4000 f67a8000 r-xp /usr/lib/libXtst.so.6.1.0
f67b0000 f67b6000 r-xp /usr/lib/libXrender.so.1.3.0
f67be000 f67c4000 r-xp /usr/lib/libXrandr.so.2.2.0
f67cc000 f67cd000 r-xp /usr/lib/libXinerama.so.1.0.0
f67d6000 f67df000 r-xp /usr/lib/libXi.so.6.1.0
f67e7000 f67ea000 r-xp /usr/lib/libXfixes.so.3.1.0
f67f2000 f67f4000 r-xp /usr/lib/libXgesture.so.7.0.0
f67fc000 f67fe000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6806000 f6808000 r-xp /usr/lib/libXdamage.so.1.1.0
f6810000 f6817000 r-xp /usr/lib/libXcursor.so.1.0.2
f681f000 f6822000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f682a000 f682e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6837000 f683c000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6845000 f6926000 r-xp /usr/lib/libX11.so.6.3.0
f6931000 f6954000 r-xp /usr/lib/libjpeg.so.8.0.2
f696c000 f6982000 r-xp /lib/libz.so.1.2.5
f698a000 f698c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6994000 f6a09000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a13000 f6a2d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a35000 f6a69000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6a72000 f6b45000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b50000 f6b60000 r-xp /lib/libresolv-2.13.so
f6b64000 f6b7c000 r-xp /usr/lib/liblzma.so.5.0.3
f6b84000 f6b87000 r-xp /lib/libcap.so.2.21
f6b8f000 f6bbe000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bc6000 f6bc7000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6bcf000 f6bd5000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6bdd000 f6bf4000 r-xp /usr/lib/liblua-5.1.so
f6bfd000 f6c04000 r-xp /usr/lib/libembryo.so.1.7.99
f6c0c000 f6c12000 r-xp /lib/librt-2.13.so
f6c1b000 f6c71000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6c7e000 f6cd4000 r-xp /usr/lib/libfreetype.so.6.11.3
f6ce0000 f6d08000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6d09000 f6d4e000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6d57000 f6d6a000 r-xp /usr/lib/libfribidi.so.0.3.1
f6d72000 f6d8c000 r-xp /usr/lib/libecore_con.so.1.7.99
f6d95000 f6d9e000 r-xp /usr/lib/libedbus.so.1.7.99
f6da6000 f6df6000 r-xp /usr/lib/libecore_x.so.1.7.99
f6df8000 f6e01000 r-xp /usr/lib/libvconf.so.0.2.45
f6e09000 f6e1a000 r-xp /usr/lib/libecore_input.so.1.7.99
f6e22000 f6e27000 r-xp /usr/lib/libecore_file.so.1.7.99
f6e2f000 f6e51000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6e5a000 f6e9b000 r-xp /usr/lib/libeina.so.1.7.99
f6ea4000 f6ebd000 r-xp /usr/lib/libeet.so.1.7.99
f6ece000 f6f37000 r-xp /lib/libm-2.13.so
f6f40000 f6f46000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f4f000 f6f50000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f58000 f6f7b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f83000 f6f88000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f90000 f6fba000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fc3000 f6fda000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fe2000 f6fed000 r-xp /lib/libunwind.so.8.0.1
f701a000 f7038000 r-xp /usr/lib/libsystemd.so.0.4.0
f7042000 f7166000 r-xp /lib/libc-2.13.so
f7174000 f717c000 r-xp /lib/libgcc_s-4.6.so.1
f717d000 f7181000 r-xp /usr/lib/libsmack.so.1.0.0
f718a000 f7190000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f7198000 f7268000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7269000 f72c7000 r-xp /usr/lib/libedje.so.1.7.99
f72d1000 f72e8000 r-xp /usr/lib/libecore.so.1.7.99
f72ff000 f73cd000 r-xp /usr/lib/libevas.so.1.7.99
f73f2000 f752e000 r-xp /usr/lib/libelementary.so.1.7.99
f7545000 f7559000 r-xp /lib/libpthread-2.13.so
f7564000 f7566000 r-xp /usr/lib/libdlog.so.0.0.0
f756e000 f7571000 r-xp /usr/lib/libbundle.so.0.1.22
f7579000 f757b000 r-xp /lib/libdl-2.13.so
f7584000 f7591000 r-xp /usr/lib/libaul.so.0.1.0
f75a2000 f75a8000 r-xp /usr/lib/libappcore-efl.so.1.1
f75b1000 f75b5000 r-xp /usr/lib/libsys-assert.so
f75be000 f75db000 r-xp /lib/ld-2.13.so
f75e4000 f75e9000 r-xp /usr/bin/launchpad-loader
f7b0f000 f7d4f000 rw-p [heap]
ff66a000 ffd33000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4068)
Call Stack Count: 19
 0: connect + 0x44 (0xf7553ab4) [/lib/libpthread.so.0] + 0xeab4
 1: connect_sensing_server + 0x9e (0xf620ab47) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1b47
 2: button_clicked_request_cb + 0x52 (0xf620a9eb) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x19eb
 3: evas_object_smart_callback_call + 0x88 (0xf73345cd) [/usr/lib/libevas.so.1] + 0x355cd
 4: (0xf72aef0d) [/usr/lib/libedje.so.1] + 0x45f0d
 5: (0xf72b2efd) [/usr/lib/libedje.so.1] + 0x49efd
 6: (0xf72af869) [/usr/lib/libedje.so.1] + 0x46869
 7: (0xf72afc1b) [/usr/lib/libedje.so.1] + 0x46c1b
 8: (0xf72afd55) [/usr/lib/libedje.so.1] + 0x46d55
 9: (0xf72dc3f5) [/usr/lib/libecore.so.1] + 0xb3f5
10: (0xf72d9e53) [/usr/lib/libecore.so.1] + 0x8e53
11: (0xf72dd46b) [/usr/lib/libecore.so.1] + 0xc46b
12: ecore_main_loop_begin + 0x30 (0xf72dd879) [/usr/lib/libecore.so.1] + 0xc879
13: appcore_efl_main + 0x332 (0xf75a5b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
14: ui_app_main + 0xb0 (0xf6240421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
15: main + 0x124 (0xf620a525) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1525
16: storage_cb + 0x6 (0xf75e5a53) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1a53
17: __libc_start_main + 0x114 (0xf705985c) [/lib/libc.so.6] + 0x1785c
18: _keep_reading_socket + 0x5b (0xf75e5e0c) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1e0c
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
:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:PeerList.cpp     L:  107][_HIGH][TX]  ConnectType(1) : BT|[0m
04-25 02:03:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:ConnectionInfo.c L:  619][_HIGH][TX]State changed: SM_STATE_ESTABLISHED->SM_STATE_INITIATE[0m
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 3433): MessagePortProxy.cpp: IsLocalPortRegisted(695) > MessagePort name is already registered.
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 2467): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 2467): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 2467): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 2467): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.w-gallery.consumer:com.samsung.w-gallery.consumer], client = 3433
04-25 02:03:47.741-0400 I/MESSAGE_PORT( 2467): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-25 02:03:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:ReceiverCtrl.cpp L:  517][_HIGH][RX]Disconnect to Peer[0m
04-25 02:03:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:ConnectionInfo.c L:  217][_HIGH][RX]CConnection::Disconnect()[0m
04-25 02:03:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:ConnectionInfo.c L:  636][_HIGH][RX]SAPManager(0xf70fc500) Disconnect(218)[0m
04-25 02:03:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:ConnectionInfo.c L:  637][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0[0m
04-25 02:03:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:ConnectionInfo.c L:  638][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
04-25 02:03:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
04-25 02:03:47.741-0400 W/WG-CONSUMER( 3433): [34m[F:ConnectionInfo.c L:  619][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
04-25 02:03:47.741-0400 I/CAPI_CONTENT_MEDIA_CONTENT( 3433): media_content.c: media_content_disconnect(958) > [32m[3433]ref count changed to: 0
04-25 02:03:47.851-0400 E/WG-CONSUMER( 3433): [31m[F:consumer-app.cpp L:  433][ERROR]Terminate main. nRet=0[0m
04-25 02:03:47.851-0400 W/WG-CONSUMER( 3433): [34m[F:ReceiverCtrl.cpp L:   88][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
04-25 02:03:47.851-0400 W/WG-CONSUMER( 3433): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0xf70fc574)[0m
04-25 02:03:47.851-0400 W/WG-CONSUMER( 3433): [34m[F:TransferCtrl.cpp L:   97][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
04-25 02:03:47.851-0400 W/WG-CONSUMER( 3433): [34m[F:AlarmSvc.cpp     L:   96][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
04-25 02:03:47.851-0400 E/WG-CONSUMER( 3433): [31m[F:ConnectionInfo.c L:  148][ERROR]Unegister db/wms/host_status/vendor is failed[0m
04-25 02:03:47.851-0400 W/WG-CONSUMER( 3433): [34m[F:BAPProxy.cpp     L:   80][_HIGH]Destroying BAP Proxy Object. 0xf70f6c00[0m
04-25 02:03:47.851-0400 W/WG-CONSUMER( 3433): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0xf70f7a2c)[0m
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-25 02:03:47.871-0400 E/MESSAGE_PORT( 2467): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
04-25 02:03:47.871-0400 E/MESSAGE_PORT( 2467): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(3433) are closed. delete client info
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
04-25 02:03:47.871-0400 E/MESSAGE_PORT( 2467): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  3433
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: UnregisterMessagePortByDiscon(273) > _MessagePortService::UnregisterMessagePortByDiscon
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.871-0400 I/MESSAGE_PORT( 2467): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-25 02:03:47.891-0400 W/AUL     ( 4213): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
04-25 02:03:47.901-0400 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 23
04-25 02:03:47.901-0400 W/AUL_AMD ( 2477): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-25 02:03:47.901-0400 W/AUL_AMD ( 2477): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 3433
04-25 02:03:47.901-0400 W/AUL_AMD ( 2477): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-25 02:03:47.901-0400 I/AUL_AMD ( 2477): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3433
04-25 02:03:47.901-0400 W/AUL     ( 2477): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3433)
04-25 02:03:49.071-0400 W/WATCH_CORE( 2791): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-25 02:03:49.071-0400 I/WATCH_CORE( 2791): appcore-watch.c: __signal_context_handler(1308) > Skip the context signal in ambient mode
04-25 02:03:49.071-0400 W/WAKEUP-SERVICE( 3190): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -146968160[0;m
04-25 02:03:49.071-0400 W/WAKEUP-SERVICE( 3190): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
04-25 02:03:49.071-0400 W/WAKEUP-SERVICE( 3190): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-25 02:03:49.071-0400 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-25 02:03:49.071-0400 W/W_HOME  ( 2712): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
04-25 02:03:49.071-0400 W/W_HOME  ( 2712): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-25 02:03:49.101-0400 W/WATCH_CORE( 2791): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-25 02:03:49.101-0400 I/WATCH_CORE( 2791): appcore-watch.c: __signal_lcd_status_handler(1241) > Skip the lcd status signal in ambient mode
04-25 02:03:49.101-0400 W/W_HOME  ( 2712): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-25 02:03:49.101-0400 W/W_HOME  ( 2712): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-25 02:03:49.101-0400 W/W_HOME  ( 2712): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-25 02:03:49.101-0400 W/W_HOME  ( 2712): gesture.c: _apps_status_get(128) > apps status:0
04-25 02:03:49.101-0400 W/W_HOME  ( 2712): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:4228
04-25 02:03:49.101-0400 W/W_HOME  ( 2712): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-25 02:03:49.101-0400 W/W_HOME  ( 2712): event_manager.c: _lcd_on_cb(728) > lcd state: 1
04-25 02:03:49.101-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:03:49.111-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer.c: __clock_viewer_lcdon_cb(463) >  event lcdon[1][0]
04-25 02:03:49.111-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer-self.c: clock_viewer_self_show_fake_hands(1083) >  Show fake hands default[0]
04-25 02:03:49.111-0400 E/W_CLOCK_VIEWER( 2736): clock-viewer-self.c: __rotate(1038) >  hand geo[161,-1][40x360]
04-25 02:03:49.111-0400 E/W_CLOCK_VIEWER( 2736): clock-viewer-self.c: __rotate(1038) >  hand geo[161,-1][40x360]
04-25 02:03:49.111-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer.c: __clock_viewer_lcdon_cb(493) >  lcdon by [gesture] time[4228]
04-25 02:03:49.121-0400 W/STARTER ( 2651): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [4228]ms
04-25 02:03:49.121-0400 W/STARTER ( 2651): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[1]
04-25 02:03:49.131-0400 I/TDM     ( 1942): tdm_exynos_display.c: exynos_output_commit(1324) > [501.564729] set aod state[2]
04-25 02:03:49.131-0400 I/TDM     ( 1942): 
04-25 02:03:49.131-0400 I/TDM     ( 1942): tdm_exynos_display.c: exynos_output_commit(1369) > [501.567412] set aod state[3]
04-25 02:03:49.131-0400 I/TDM     ( 1942): 
04-25 02:03:49.131-0400 W/W_INDICATOR( 2654): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-25 02:03:49.131-0400 W/W_INDICATOR( 2654): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-25 02:03:49.141-0400 W/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-25 02:03:49.141-0400 E/WAKEUP-SERVICE( 3190): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-25 02:03:49.141-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2651].
04-25 02:03:49.141-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(975153754)
04-25 02:03:49.141-0400 E/ALARM_MANAGER( 2432): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1850700647) is OVER.
04-25 02:03:49.141-0400 E/WAKEUP-SERVICE( 3190): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-25 02:03:49.151-0400 E/WAKEUP-SERVICE( 3190): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-25 02:03:49.151-0400 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-25 02:03:49.151-0400 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-25 02:03:49.151-0400 W/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-25 02:03:49.151-0400 W/WAKEUP-SERVICE( 3190): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-25 02:03:49.151-0400 I/HIGEAR  ( 3190): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-25 02:03:49.151-0400 W/WAKEUP-SERVICE( 3190): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -150189300[0;m
04-25 02:03:49.161-0400 W/WAKEUP-SERVICE( 3190): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-25 02:03:49.161-0400 W/WAKEUP-SERVICE( 3190): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-25 02:03:49.161-0400 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-25 02:03:49.161-0400 W/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-25 02:03:49.171-0400 E/WAKEUP-SERVICE( 3190): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-25 02:03:49.171-0400 E/WAKEUP-SERVICE( 3190): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-25 02:03:49.171-0400 E/WAKEUP-SERVICE( 3190): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-25 02:03:49.171-0400 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-25 02:03:49.181-0400 I/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-25 02:03:49.181-0400 W/TIZEN_N_SOUND_MANAGER( 3190): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-25 02:03:49.181-0400 W/WAKEUP-SERVICE( 3190): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-25 02:03:49.181-0400 I/HIGEAR  ( 3190): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-25 02:03:49.181-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
04-25 02:03:49.181-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
04-25 02:03:49.181-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: preference_get_boolean(1173) > preference_get_boolean(3122) : test_healthy_pace error
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: preference_get_double(1214) > preference_get_double(3122) : pedometer_inactive_period error
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: preference_get_double(1214) > preference_get_double(3122) : inactive_10min_precaution_millisec error
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-25 02:03:49.221-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: preference_get_double(1214) > preference_get_double(3122) : inactive_before_10min_precaution_millisec error
04-25 02:03:49.301-0400 W/W_HOME  ( 2712): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-25 02:03:49.301-0400 W/W_HOME  ( 2712): gesture.c: _manual_render_enable(138) > 0
04-25 02:03:49.301-0400 W/W_HOME  ( 2712): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-25 02:03:49.311-0400 W/SHealthCommon( 2844): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-25 02:03:49.321-0400 W/SHealthCommon( 3122): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-25 02:03:49.321-0400 W/SHealthService( 3122): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-25 02:03:49.341-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer.c: __clock_viewer_lcdon_completed_cb(518) >  event lcdon completed[1]
04-25 02:03:49.341-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer-self.c: clock_viewer_self_hide(1066) >  ===== HIDE =====
04-25 02:03:49.341-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer.c: clock_viewer_hide(1452) >  reservied[0], gesture[0], clock visible[0]
04-25 02:03:49.341-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer.c: _clock_viewer_send_clock_stop(1059) >  clock stop <<
04-25 02:03:49.341-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer.c: _clock_viewer_send_clock_changed(1069) >  clock changed <<
04-25 02:03:49.341-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer.c: _clock_viewer_remove_alarms(887) >  Delete alarm id[975153753] by [hide_ambient], fini[1]
04-25 02:03:49.351-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-25 02:03:49.351-0400 W/WATCH_CORE( 2791): appcore-watch.c: __signal_alpm_handler(1151) > signal_alpm_handler: ambient mode: 0, state: 3
04-25 02:03:49.351-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_ambient_tick(339) > _watch_core_ambient_tick, watch: com.samsung.chronograph16
04-25 02:03:49.351-0400 D/chronograph( 2791): ChronographApp.cpp: _appAmbientTick(186) > [0;34m>>>HIT<<<[0;m
04-25 02:03:49.351-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-25 02:03:49.351-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-4-2017, 06:13:01 (UTC).
04-25 02:03:49.351-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-25 02:03:49.351-0400 D/chronograph( 2791): ChronographViewController.cpp: _getCurrentDate(2107) > [0;32mBEGIN >>>>[0;m
04-25 02:03:49.351-0400 D/chronograph-common( 2791): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-25 02:03:49.351-0400 D/chronograph-common( 2791): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-25 02:03:49.361-0400 D/chronograph( 2791): ChronographViewController.cpp: _getCurrentDate(2129) > timestamp = 1493100229 :: dateStr = TUE :: dayStr = 25 :: dateText = TUE 25
04-25 02:03:49.361-0400 W/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_ambient_changed(354) > _watch_core_ambient_changed: 0
04-25 02:03:49.361-0400 D/chronograph( 2791): ChronographApp.cpp: _appAmbientChanged(195) > [0;34m>>>HIT<<<[0;m
04-25 02:03:49.361-0400 D/chronograph( 2791): ChronographViewController.cpp: onEventAmbientMode(338) > onEventAmbientMode >>>> [isAmbientMode=0]
04-25 02:03:49.361-0400 I/chronograph( 2791): ChronographViewController.cpp: onEventAmbientMode(358) > [0;32mAmbient Mode Unset >>>>[0;m
04-25 02:03:49.361-0400 W/chronograph( 2791): ChronographViewController.cpp: _hideAodView(907) > [0;35mhideAodView >>>>[0;m
04-25 02:03:49.361-0400 D/chronograph( 2791): ChronographViewController.cpp: _setWatchTouchEvent(1025) > [0;32mBEGIN >>>>[0;m
04-25 02:03:49.361-0400 D/chronograph( 2791): ChronographViewController.cpp: _setCurrentHandPosition(973) > [0;32mBEGIN >>>>[0;m
04-25 02:03:49.361-0400 D/chronograph( 2791): ChronographViewController.cpp: _getCurrentDate(2107) > [0;32mBEGIN >>>>[0;m
04-25 02:03:49.361-0400 D/chronograph-common( 2791): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-25 02:03:49.361-0400 D/chronograph-common( 2791): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-25 02:03:49.371-0400 D/chronograph( 2791): ChronographViewController.cpp: _getCurrentDate(2129) > timestamp = 1493100229 :: dateStr = TUE :: dayStr = 25 :: dateText = TUE 25
04-25 02:03:49.371-0400 D/chronograph( 2791): ChronographApp.cpp: _appResume(161) > [0;34m>>>HIT<<<[0;m
04-25 02:03:49.371-0400 D/chronograph( 2791): ChronographViewController.cpp: onResume(221) > State is Resume[isPaused=0], StopwatchState=0
04-25 02:03:49.371-0400 W/chronograph( 2791): ChronographSweepSecond.cpp: setSweepSecond(55) > [0;35msetSweepSecond >>>>[0;m
04-25 02:03:49.371-0400 D/chronograph( 2791): ChronographSweepSecond.cpp: setSweepSecond(67) > Current sec = 49, msec = 380
04-25 02:03:49.371-0400 D/chronograph( 2791): ChronographSweepSecond.cpp: setSweepSecond(71) > Create sweepSecondAnimation !!
04-25 02:03:49.371-0400 D/chronograph-common( 2791): ChronographSensor.cpp: enableAccelerometer(44) > [0;32mBEGIN >>>>[0;m
04-25 02:03:49.371-0400 D/chronograph-common( 2791): ChronographSensor.cpp: _startAccelerometer(75) > [0;32mBEGIN >>>>[0;m
04-25 02:03:49.381-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:49.521-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-25 02:03:49.521-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[975153754] is removed.
04-25 02:03:49.531-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2736].
04-25 02:03:49.531-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(975153753)
04-25 02:03:49.531-0400 E/ALARM_MANAGER( 2432): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1850700647) is OVER.
04-25 02:03:49.531-0400 W/STARTER ( 2651): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-25 02:03:49.531-0400 W/STARTER ( 2651): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[1]
04-25 02:03:49.541-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-25 02:03:49.541-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-25 02:03:49.541-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-4-2017, 16:00:01 (UTC).
04-25 02:03:49.541-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-25 02:03:49.551-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-25 02:03:49.551-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[975153753] is removed.
04-25 02:03:49.551-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2791].
04-25 02:03:49.551-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(975153752)
04-25 02:03:49.551-0400 E/ALARM_MANAGER( 2432): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1850700647) is OVER.
04-25 02:03:49.551-0400 I/TDM     ( 1942): tdm_display.c: tdm_layer_set_buffer(1529) > [501.987417] layer(0x70b260) not usable
04-25 02:03:49.551-0400 I/TDM     ( 1942): tdm_exynos_display.c: exynos_output_set_property(1184) > [501.987652] id[0]
04-25 02:03:49.551-0400 I/TDM     ( 1942): tdm_exynos_display.c: __exynos_output_aod_change_state(1142) > [501.987674] aod_change_state:mode[3]
04-25 02:03:49.551-0400 I/TDM     ( 1942): tdm_exynos_display.c: __exynos_output_aod_change_state(1149) > [501.987693] aod_change_state:state[1 -> 0]
04-25 02:03:49.561-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-25 02:03:49.561-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-25 02:03:49.561-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-4-2017, 18:01:24 (UTC).
04-25 02:03:49.561-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-25 02:03:49.571-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-25 02:03:49.581-0400 E/ALARM_MANAGER( 2432): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[975153752] is removed.
04-25 02:03:49.581-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:49.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:49.641-0400 I/TDM     ( 1942): tdm_display.c: tdm_layer_set_info(1459) > [502.071252] layer(0x70b210) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-25 02:03:49.641-0400 I/TDM     ( 1942): tdm_exynos_display.c: exynos_layer_set_info(1578) > [502.071442] layer[0x70ad60]zpos[1]
04-25 02:03:49.661-0400 I/APP_CORE( 4068): appcore-efl.c: __do_app(453) > [APP 4068] Event: RESUME State: PAUSED
04-25 02:03:49.661-0400 I/CAPI_APPFW_APPLICATION( 4068): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-25 02:03:49.671-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer.c: __clock_viewer_visibility_change_cb(703) >  Window visibility : [HIDE] lcd[2] begin_flag[0]
04-25 02:03:49.681-0400 W/AUL_AMD ( 2477): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-25 02:03:49.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:49.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:50.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:50.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:50.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:50.641-0400 E/EFL     ( 4068): ecore_x<4068> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=503075 button=1
04-25 02:03:50.741-0400 E/EFL     ( 4068): ecore_x<4068> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=503173 button=1
04-25 02:03:50.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:50.831-0400 D/devapp  ( 4068): button is clicked
04-25 02:03:50.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:51.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:51.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:51.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:51.741-0400 E/EFL     ( 2307): ecore_x<2307> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2400002 time=503173
04-25 02:03:51.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:51.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:52.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:52.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:52.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:52.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:52.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:53.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:53.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:53.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:53.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:53.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:54.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:54.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:54.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:54.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:54.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:55.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:55.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:55.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:55.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:55.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:56.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:56.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:56.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:56.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:56.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:57.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:57.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:57.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:57.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:57.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:58.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:58.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:58.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:58.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:58.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:59.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:59.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:59.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:59.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:03:59.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:00.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:00.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:00.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:00.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: preference_get_double(1214) > preference_get_double(3122) : pedometer_inactive_period error
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: preference_get_double(1214) > preference_get_double(3122) : inactive_10min_precaution_millisec error
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-25 02:04:00.941-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3122): preference.c: preference_get_double(1214) > preference_get_double(3122) : inactive_before_10min_precaution_millisec error
04-25 02:04:00.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:01.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:01.391-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:01.591-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:01.621-0400 W/WATCH_CORE( 2791): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
04-25 02:04:01.621-0400 I/WATCH_CORE( 2791): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-25 02:04:01.621-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:01.621-0400 E/wnoti-service( 2947): wnoti-db-utility.c: context_wearonoff_status_cb(2092) > status changed from 1 to 2 
04-25 02:04:01.621-0400 W/WECONN  ( 2462): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
04-25 02:04:01.621-0400 W/WECONN  ( 2462): <__wc_device_on_wear_onoff_changed_cb:353> { state=WC_FEATURE_STATE_OFF
04-25 02:04:01.621-0400 W/WECONN  ( 2462): <__wc_device_on_wear_onoff_changed_cb:384> }
04-25 02:04:01.621-0400 W/WECONN  ( 2462): <__wc_feature_wearonoff_monitor_cb:531> }
04-25 02:04:01.631-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_monitor_cb(183) >  wearonoff_monitor_cb called error[0], context[45], data[{ "Time" : 1493100241628, "Reason" : 37, "Status" : 2 }], req_id[1]
04-25 02:04:01.631-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_monitor_cb(199) >  status[2] Wear OFF, enabled[1]
04-25 02:04:01.631-0400 W/W_CLOCK_VIEWER( 2736): clock-viewer-smart-lcdoff.c: __clock_viewer_smart_lcdoff_wear_status_changed_cb(101) >  status[0], alarm[0], started[0]
04-25 02:04:01.631-0400 E/WMS     ( 2437): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23450) > wear_monitor_status update[0] = 1 -> 2
04-25 02:04:01.641-0400 W/SHealthService( 3122): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
04-25 02:04:01.751-0400 E/PROCESSMGR( 2307): e_mod_processmgr.c: _e_mod_processmgr_dbus_msg_send(315) > [PROCESSMGR] pointed_win=0x2400002 Send kill command to the ResourceD! PID=4068 Name=edu.umich.edu.yctung.devapp
04-25 02:04:01.751-0400 E/RESOURCED( 2580): proc-monitor.c: proc_dbus_watchdog_handler(838) > Receive watchdog signal to pid: 4068(devapp)
04-25 02:04:01.751-0400 E/RESOURCED( 2580): proc-monitor.c: proc_dbus_watchdog_handler(854) > just kill watchdog process when debug enabled pid: 4068(devapp)
04-25 02:04:01.791-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:01.991-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:02.051-0400 W/AUL_PAD ( 3272): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4068 pgid = 4068
04-25 02:04:02.061-0400 W/AUL_PAD ( 3272): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 6
04-25 02:04:02.111-0400 W/STARTER ( 2651): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2712] goes to (3)
04-25 02:04:02.111-0400 E/STARTER ( 2651): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2712)'s state(3)
04-25 02:04:02.111-0400 W/WATCH_CORE( 2791): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-25 02:04:02.111-0400 I/WATCH_CORE( 2791): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-25 02:04:02.111-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:02.121-0400 W/AUL_AMD ( 2477): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-25 02:04:02.121-0400 W/AUL_AMD ( 2477): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-25 02:04:02.121-0400 W/AUL     ( 2477): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2712) status(fg) type(uiapp)
04-25 02:04:02.131-0400 W/PROCESSMGR( 2307): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-25 02:04:02.181-0400 W/AUL_PAD ( 3272): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-25 02:04:02.191-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:02.191-0400 I/AUL_AMD ( 2477): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4068
04-25 02:04:02.191-0400 W/AUL     ( 2477): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4068)
04-25 02:04:02.201-0400 W/W_HOME  ( 2712): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
04-25 02:04:02.201-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:04:02.201-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:04:02.211-0400 W/W_INDICATOR( 2654): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-25 02:04:02.211-0400 W/W_INDICATOR( 2654): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-25 02:04:02.211-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:04:02.211-0400 W/W_HOME  ( 2712): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-25 02:04:02.211-0400 W/W_HOME  ( 2712): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(0)
04-25 02:04:02.211-0400 W/W_HOME  ( 2712): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
04-25 02:04:02.211-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): main.c: _window_visibility_cb(964) > Window [0x2000003] is now visible(0)
04-25 02:04:02.221-0400 I/APP_CORE( 2712): appcore-efl.c: __do_app(453) > [APP 2712] Event: RESUME State: PAUSED
04-25 02:04:02.221-0400 I/CAPI_APPFW_APPLICATION( 2712): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): main.c: _appcore_resume_cb(479) > appcore resume
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): main.c: home_resume(531) > clock/widget resumed
04-25 02:04:02.221-0400 W/W_HOME  ( 2712): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-25 02:04:02.221-0400 I/wnotib  ( 2712): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
04-25 02:04:02.221-0400 E/wnotib  ( 2712): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-25 02:04:02.221-0400 W/wnotib  ( 2712): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-25 02:04:02.221-0400 W/W_INDICATOR( 2654): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
04-25 02:04:02.221-0400 W/W_INDICATOR( 2654): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
04-25 02:04:02.221-0400 W/W_INDICATOR( 2654): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-25 02:04:02.221-0400 W/WATCH_CORE( 2791): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-25 02:04:02.221-0400 I/WATCH_CORE( 2791): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-25 02:04:02.221-0400 I/CAPI_WATCH_APPLICATION( 2791): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-25 02:04:02.221-0400 W/W_INDICATOR( 2654): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(50), length(2)
04-25 02:04:02.221-0400 W/W_INDICATOR( 2654): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 50%
04-25 02:04:02.221-0400 W/W_INDICATOR( 2654): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 50, isCharging: 0
04-25 02:04:02.231-0400 W/W_INDICATOR( 2654): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_50
04-25 02:04:02.231-0400 W/W_INDICATOR( 2654): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
04-25 02:04:02.271-0400 W/CRASH_MANAGER( 4238): worker.c: worker_job(1199) > 0604068646576149310024
