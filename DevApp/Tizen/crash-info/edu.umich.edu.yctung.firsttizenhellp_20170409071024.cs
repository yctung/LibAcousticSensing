S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: firsttizenhello
PID: 4999
Date: 2017-04-09 07:10:24-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
r0   = 0x00000023, r1   = 0x00000000
r2   = 0x0a3f4600, r3   = 0x0a3f4600
r4   = 0xaaaab924, r5   = 0xaabde268
r6   = 0xaab4e1f8, r7   = 0xfffef2d8
r8   = 0x00000000, r9   = 0xaac0bb28
r10  = 0xaac12370, fp   = 0x00000001
ip   = 0xf42d5084, sp   = 0xfffef298
lr   = 0xaaaab75d, pc   = 0xaaaab760
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:      7516 KB
Buffers:     36932 KB
Cached:     210420 KB
VmPeak:     109900 KB
VmSize:     109896 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26340 KB
VmRSS:       26336 KB
VmData:      39036 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       25304 KB
VmPTE:         124 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4999 TID = 4999
4999 5029 5030 5031 5067 

Maps Information
aaaaa000 aaaac000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
aaabc000 aacfc000 rw-p [heap]
f10c5000 f18c4000 rw-p [stack:5067]
f18c4000 f18cf000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f18d7000 f18d9000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f18e1000 f18e2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1a05000 f1a0d000 r-xp /usr/lib/libfeedback.so.0.1.4
f1a10000 f1a11000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1a19000 f1a1a000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f1a22000 f1a25000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f1ae3000 f22e2000 rw-p [stack:5031]
f26e4000 f2ee3000 rw-p [stack:5030]
f32e7000 f3ae6000 rw-p [stack:5029]
f3bab000 f3bc2000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3d65000 f3d6a000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3d72000 f3d7d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f40a5000 f40af000 r-xp /lib/libnss_files-2.13.so
f40b8000 f4187000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f419d000 f41c1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f41ca000 f42bc000 r-xp /usr/lib/libCOREGL.so.4.0
f42dc000 f42e1000 r-xp /usr/lib/libsystem.so.0.0.0
f42eb000 f42ec000 r-xp /usr/lib/libresponse.so.0.2.96
f42f5000 f42fa000 r-xp /usr/lib/libproc-stat.so.0.2.96
f4303000 f4305000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f430d000 f4314000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f431d000 f433f000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f4348000 f434b000 r-xp /lib/libattr.so.1.1.0
f4354000 f435c000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4364000 f436a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f4373000 f4378000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f4380000 f43a1000 r-xp /usr/lib/libexif.so.12.3.3
f43b4000 f43bb000 r-xp /lib/libcrypt-2.13.so
f43ec000 f43ef000 r-xp /lib/libcap.so.2.21
f43f7000 f43f9000 r-xp /usr/lib/libiri.so
f4401000 f441a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f4422000 f4427000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f442f000 f4435000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f443e000 f445b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f4464000 f4468000 r-xp /usr/lib/libogg.so.0.7.1
f4470000 f4492000 r-xp /usr/lib/libvorbis.so.0.4.3
f449a000 f449c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f44a5000 f44d3000 r-xp /usr/lib/libidn.so.11.5.44
f44db000 f44e4000 r-xp /usr/lib/libcares.so.2.1.0
f44ed000 f44ef000 r-xp /usr/lib/libXau.so.6.0.0
f44f7000 f44f9000 r-xp /usr/lib/libttrace.so.1.1
f4501000 f4503000 r-xp /usr/lib/libdri2.so.0.0.0
f450c000 f4514000 r-xp /usr/lib/libdrm.so.2.4.0
f451c000 f451d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f4526000 f4529000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f4531000 f4540000 r-xp /usr/lib/libmdm-common.so.1.1.22
f454a000 f45de000 r-xp /usr/lib/libstdc++.so.6.0.16
f45f1000 f45f5000 r-xp /usr/lib/libsmack.so.1.0.0
f45fe000 f47a7000 r-xp /usr/lib/libcrypto.so.1.0.0
f47c7000 f480e000 r-xp /usr/lib/libssl.so.1.0.0
f481b000 f484a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f4852000 f4899000 r-xp /usr/lib/libsndfile.so.1.0.26
f48a5000 f48ee000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f48f7000 f48fc000 r-xp /usr/lib/libjson.so.0.0.1
f4904000 f4907000 r-xp /usr/lib/libtinycompress.so.0.0.0
f4910000 f4912000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f491a000 f492a000 r-xp /lib/libresolv-2.13.so
f492e000 f4946000 r-xp /usr/lib/liblzma.so.5.0.3
f494e000 f4950000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f4959000 f4a2c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f4a37000 f4a3c000 r-xp /usr/lib/libffi.so.5.0.10
f4a44000 f4a88000 r-xp /usr/lib/libcurl.so.4.3.0
f4a91000 f4ab4000 r-xp /usr/lib/libjpeg.so.8.0.2
f4acd000 f4ae0000 r-xp /usr/lib/libxcb.so.1.1.0
f4ae9000 f4aef000 r-xp /usr/lib/libxcb-render.so.0.0.0
f4af7000 f4af8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f4b01000 f4b19000 r-xp /usr/lib/libpng12.so.0.50.0
f4b21000 f4b25000 r-xp /usr/lib/libEGL.so.1.4
f4b35000 f4b46000 r-xp /usr/lib/libGLESv2.so.2.0
f4b57000 f4b58000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f4b60000 f4b77000 r-xp /usr/lib/liblua-5.1.so
f4b80000 f4b87000 r-xp /usr/lib/libembryo.so.1.7.99
f4b8f000 f4b9a000 r-xp /usr/lib/libtbm.so.1.0.0
f4ba2000 f4bc5000 r-xp /usr/lib/libui-extension.so.0.1.0
f4bcf000 f4be5000 r-xp /usr/lib/libtts.so
f4bee000 f4c04000 r-xp /lib/libz.so.1.2.5
f4c0c000 f4c22000 r-xp /lib/libexpat.so.1.6.0
f4c2c000 f4c2f000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f4c37000 f4c3b000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f4c45000 f4c4a000 r-xp /usr/lib/libecore_fb.so.1.7.99
f4c53000 f4c5d000 r-xp /usr/lib/libXext.so.6.4.0
f4c66000 f4c6a000 r-xp /usr/lib/libXtst.so.6.1.0
f4c72000 f4c78000 r-xp /usr/lib/libXrender.so.1.3.0
f4c80000 f4c86000 r-xp /usr/lib/libXrandr.so.2.2.0
f4c8e000 f4c8f000 r-xp /usr/lib/libXinerama.so.1.0.0
f4c99000 f4c9c000 r-xp /usr/lib/libXfixes.so.3.1.0
f4ca4000 f4ca6000 r-xp /usr/lib/libXgesture.so.7.0.0
f4cae000 f4cb0000 r-xp /usr/lib/libXcomposite.so.1.0.0
f4cb8000 f4cba000 r-xp /usr/lib/libXdamage.so.1.1.0
f4cc2000 f4cc9000 r-xp /usr/lib/libXcursor.so.1.0.2
f4cd2000 f4d1a000 r-xp /usr/lib/libmdm.so.1.2.62
f65ac000 f66b2000 r-xp /usr/lib/libicuuc.so.57.1
f66c8000 f6850000 r-xp /usr/lib/libicui18n.so.57.1
f6860000 f6862000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f686c000 f6879000 r-xp /usr/lib/libail.so.0.1.0
f6882000 f6885000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f688d000 f68c5000 r-xp /usr/lib/libpulse.so.0.16.2
f68c6000 f68c9000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f68d1000 f6932000 r-xp /usr/lib/libasound.so.2.0.0
f693c000 f6952000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f695b000 f6962000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f696a000 f696e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f6976000 f6977000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f697f000 f698a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f6997000 f699b000 r-xp /usr/lib/libmmfsession.so.0.0.0
f69a5000 f69ab000 r-xp /lib/librt-2.13.so
f69b4000 f6a29000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a33000 f6a4d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a55000 f6a73000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a7d000 f6a7e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a87000 f6a8c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a94000 f6aab000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ab3000 f6ab5000 r-xp /usr/lib/libiniparser.so.0
f6abe000 f6af2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6afb000 f6b01000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6b0a000 f6b0d000 r-xp /usr/lib/libbundle.so.0.1.22
f6b15000 f6b1b000 r-xp /usr/lib/libappsvc.so.0.1.0
f6b23000 f6b2a000 r-xp /usr/lib/libminizip.so.1.0.0
f6b32000 f6b88000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b95000 f6beb000 r-xp /usr/lib/libfreetype.so.6.11.3
f6bf8000 f6c3d000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c46000 f6c59000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c61000 f6c7b000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c84000 f6cae000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cb7000 f6cc0000 r-xp /usr/lib/libedbus.so.1.7.99
f6cc9000 f6cda000 r-xp /usr/lib/libecore_input.so.1.7.99
f6ce2000 f6ce7000 r-xp /usr/lib/libecore_file.so.1.7.99
f6cef000 f6d08000 r-xp /usr/lib/libeet.so.1.7.99
f6d19000 f6d22000 r-xp /usr/lib/libXi.so.6.1.0
f6d2a000 f6e0b000 r-xp /usr/lib/libX11.so.6.3.0
f6e17000 f6ecf000 r-xp /usr/lib/libcairo.so.2.11200.14
f6eda000 f6f38000 r-xp /usr/lib/libedje.so.1.7.99
f6f42000 f6f59000 r-xp /usr/lib/libecore.so.1.7.99
f6f70000 f6fd9000 r-xp /lib/libm-2.13.so
f6fe2000 f6ff4000 r-xp /usr/lib/libefl-assist.so.0.1.0
f6ffc000 f70cc000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70cd000 f7199000 r-xp /usr/lib/libxml2.so.2.7.8
f71a6000 f71ce000 r-xp /usr/lib/libfontconfig.so.1.8.0
f71cf000 f71d8000 r-xp /usr/lib/libvconf.so.0.2.45
f71e0000 f7202000 r-xp /usr/lib/libecore_evas.so.1.7.99
f720b000 f725b000 r-xp /usr/lib/libecore_x.so.1.7.99
f725d000 f7262000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f726a000 f7281000 r-xp /usr/lib/libmmfsound.so.0.1.0
f7293000 f72a7000 r-xp /lib/libpthread-2.13.so
f72b2000 f72f3000 r-xp /usr/lib/libeina.so.1.7.99
f72fc000 f731f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7327000 f7334000 r-xp /usr/lib/libaul.so.0.1.0
f733e000 f7343000 r-xp /usr/lib/libappcore-common.so.1.1
f734b000 f7351000 r-xp /usr/lib/libappcore-efl.so.1.1
f7359000 f735b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7364000 f7368000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7371000 f7373000 r-xp /lib/libdl-2.13.so
f737c000 f7387000 r-xp /lib/libunwind.so.8.0.1
f73b4000 f73bc000 r-xp /lib/libgcc_s-4.6.so.1
f73bd000 f74e1000 r-xp /lib/libc-2.13.so
f74ef000 f74f4000 r-xp /usr/lib/libstorage.so.0.1
f74fc000 f75ca000 r-xp /usr/lib/libevas.so.1.7.99
f75ef000 f772b000 r-xp /usr/lib/libelementary.so.1.7.99
f7742000 f7763000 r-xp /usr/lib/libefl-extension.so.0.1.0
f776b000 f776d000 r-xp /usr/lib/libdlog.so.0.0.0
f7775000 f777d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f777e000 f7785000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f778d000 f7793000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f779c000 f77a0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f77aa000 f77b5000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f77be000 f77c2000 r-xp /usr/lib/libsys-assert.so
f77cb000 f77e8000 r-xp /lib/ld-2.13.so
fffcf000 ffff0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4999)
Call Stack Count: 16
 0: button_clicked_request_cb + 0x3b (0xaaaab760) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1760
 1: evas_object_smart_callback_call + 0x88 (0xf75315cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf6f1ff0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf6f23efd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf6f20869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf6f20c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf6f20d55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf6f4d3f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf6f4ae53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf6f4e46b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf6f4e879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf734eb47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf779e421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0xaaaab25f) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x125f
14: __libc_start_main + 0x114 (0xf73d485c) [/lib/libc.so.6] + 0x1785c
15: (0xaaaaaf58) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0xf58
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
2473): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-09 07:10:08.212-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-09 07:10:08.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:08.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:08.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:08.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:09.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:09.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:09.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:09.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:09.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:10.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:10.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:10.492-0400 W/W_INDICATOR( 2651): windicator_moment_view.c: windicator_moment_view_battery_disp_timer_cb(737) > [windicator_moment_view_battery_disp_timer_cb:737] [CHARGING_UI] windicator_moment_view_battery_disp_timer_cb
04-09 07:10:10.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:10.722-0400 W/W_INDICATOR( 2651): windicator_moment_view.c: _charging_ui_fade_out_end_cb(246) > [_charging_ui_fade_out_end_cb:246] Fade out end. Call moment_view_hide
04-09 07:10:10.722-0400 E/W_INDICATOR( 2651): windicator_moment_view.c: windicator_moment_view_hide(1050) > [windicator_moment_view_hide:1050] Hide Moment View , Type(1)
04-09 07:10:10.722-0400 W/PROCESSMGR( 2304): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-09 07:10:10.722-0400 W/W_HOME  ( 2717): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
04-09 07:10:10.722-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:10.722-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:10.722-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-09 07:10:10.722-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-09 07:10:10.732-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:10.732-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:10.732-0400 W/W_HOME  ( 2717): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-09 07:10:10.732-0400 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
04-09 07:10:10.732-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
04-09 07:10:10.732-0400 W/W_INDICATOR( 2651): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-09 07:10:10.742-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(26), length(2)
04-09 07:10:10.742-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 26%
04-09 07:10:10.742-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 26, isCharging: 0
04-09 07:10:10.752-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [1403.421339] layer(0x4471a0) not usable
04-09 07:10:10.752-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [1403.421374] layer(0x4471a0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-09 07:10:10.752-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [1403.421400] layer[0x446c40]zpos[0]
04-09 07:10:10.752-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
04-09 07:10:10.752-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
04-09 07:10:10.762-0400 I/APP_CORE( 2651): appcore-efl.c: __do_app(453) > [APP 2651] Event: PAUSE State: RUNNING
04-09 07:10:10.762-0400 I/CAPI_APPFW_APPLICATION( 2651): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-09 07:10:10.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:10.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:11.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:11.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:11.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:11.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:11.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:12.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:12.222-0400 I/APP_CORE( 4999): appcore-efl.c: __do_app(453) > [APP 4999] Event: RESET State: CREATED
04-09 07:10:12.222-0400 I/CAPI_APPFW_APPLICATION( 4999): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-09 07:10:12.262-0400 W/W_HOME  ( 2717): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
04-09 07:10:12.262-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:12.262-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:12.262-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:12.262-0400 W/W_HOME  ( 2717): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
04-09 07:10:12.262-0400 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-09 07:10:12.282-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-09 07:10:12.292-0400 I/APP_CORE( 4999): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-09 07:10:12.292-0400 I/APP_CORE( 4999): appcore-efl.c: __do_app(524) > [APP 4999] Initial Launching, call the resume_cb
04-09 07:10:12.292-0400 I/CAPI_APPFW_APPLICATION( 4999): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-09 07:10:12.302-0400 W/APP_CORE( 4999): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000002
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(1)
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): main.c: _window_visibility_cb(964) > Window [0x2000003] is now visible(1)
04-09 07:10:12.382-0400 I/APP_CORE( 4999): appcore-efl.c: __do_app(453) > [APP 4999] Event: RESUME State: RUNNING
04-09 07:10:12.382-0400 I/APP_CORE( 2717): appcore-efl.c: __do_app(453) > [APP 2717] Event: PAUSE State: RUNNING
04-09 07:10:12.382-0400 I/CAPI_APPFW_APPLICATION( 2717): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): main.c: _appcore_pause_cb(488) > appcore pause
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): main.c: home_pause(547) > clock/widget paused
04-09 07:10:12.382-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-09 07:10:12.382-0400 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-09 07:10:12.382-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-09 07:10:12.382-0400 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-09 07:10:12.382-0400 E/CAPI_APPFW_APP_CONTROL( 2994): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-09 07:10:12.382-0400 W/MUSIC_CONTROL_SERVICE( 2994): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:2994]   [com.samsung.w-home]register msg port [false][0m
04-09 07:10:12.382-0400 I/wnotib  ( 2717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
04-09 07:10:12.382-0400 E/wnotib  ( 2717): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-09 07:10:12.382-0400 W/wnotib  ( 2717): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-09 07:10:12.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:12.392-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2717) status(bg) type(uiapp)
04-09 07:10:12.392-0400 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2717] goes to (4)
04-09 07:10:12.392-0400 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2717)'s state(4)
04-09 07:10:12.392-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1405.069134] layer(0x4471a0) now usable
04-09 07:10:12.392-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1405.069158] layer[0x446c40]zpos[0]
04-09 07:10:12.402-0400 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[4999] goes to (3)
04-09 07:10:12.402-0400 W/AUL_AMD ( 2480): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-09 07:10:12.402-0400 W/AUL_AMD ( 2480): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-09 07:10:12.402-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(edu.umich.edu.yctung.firsttizenhellp) pid(4999) status(fg) type(uiapp)
04-09 07:10:12.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:12.752-0400 E/AUL     ( 2480): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-09 07:10:12.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:12.882-0400 I/APP_CORE( 2717): appcore-efl.c: __do_app(453) > [APP 2717] Event: MEM_FLUSH State: PAUSED
04-09 07:10:12.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:13.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:13.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:13.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:13.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:13.932-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdoff_cb(554) >  event pre lcdoff[1]
04-09 07:10:13.932-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(413) >  enabled[1] status[0] setup[0] darkscreen[0]
04-09 07:10:13.932-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdoff_cb(578) >  Skip if wear off status and send ALPMLCDOff
04-09 07:10:13.942-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-09 07:10:13.942-0400 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-09 07:10:13.942-0400 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-09 07:10:13.942-0400 E/STARTER ( 2650): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
04-09 07:10:13.942-0400 W/STARTER ( 2650): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-09 07:10:13.942-0400 W/STARTER ( 2650): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-09 07:10:13.942-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -151753972[0;m
04-09 07:10:13.942-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-09 07:10:13.942-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-09 07:10:13.952-0400 W/W_HOME  ( 2717): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-09 07:10:13.952-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-09 07:10:13.952-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-09 07:10:13.952-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_enable(138) > 1
04-09 07:10:13.952-0400 W/W_HOME  ( 2717): event_manager.c: _lcd_off_cb(736) > lcd state: 0
04-09 07:10:13.952-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:13.962-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-09 07:10:13.962-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-09 07:10:13.962-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-09 07:10:13.962-0400 I/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-09 07:10:13.972-0400 I/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-09 07:10:13.972-0400 W/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-09 07:10:13.972-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-09 07:10:13.972-0400 I/HIGEAR  ( 3270): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-09 07:10:13.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:14.152-0400 W/SHealthCommon( 3208): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
04-09 07:10:14.162-0400 W/SHealthCommon( 2942): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
04-09 07:10:14.162-0400 W/SHealthService( 3208): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-09 07:10:14.182-0400 W/W_INDICATOR( 2651): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-09 07:10:14.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:14.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:14.392-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1407.069767] layer(0x447210) now usable
04-09 07:10:14.392-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1407.069823] layer[0x446d60]zpos[1]
04-09 07:10:14.392-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [1407.069877] layer(0x447260) now usable
04-09 07:10:14.392-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [1407.069898] layer[0x446e80]zpos[2]
04-09 07:10:14.392-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [1407.069925] dpms[0 -> 3]sync[1]
04-09 07:10:14.392-0400 I/TDM     ( 1956): 
04-09 07:10:14.532-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [1407.201325] dpms[3 -> 3]done
04-09 07:10:14.532-0400 I/TDM     ( 1956): 
04-09 07:10:14.582-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(668) >  event lcdoff completed[1][0]
04-09 07:10:14.582-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(413) >  enabled[1] status[0] setup[0] darkscreen[0]
04-09 07:10:14.582-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(688) >  Skip if wear off status
04-09 07:10:14.582-0400 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-09 07:10:14.582-0400 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[1]
04-09 07:10:14.582-0400 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-09 07:10:14.582-0400 W/STARTER ( 2650): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
04-09 07:10:14.582-0400 E/ALARM_MANAGER( 2650): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(9-4-2017, 07:10:35), repeat(1), interval(20), type(-1073741822)
04-09 07:10:14.592-0400 I/APP_CORE( 4999): appcore-efl.c: __do_app(453) > [APP 4999] Event: PAUSE State: RUNNING
04-09 07:10:14.592-0400 I/CAPI_APPFW_APPLICATION( 4999): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-09 07:10:14.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:14.602-0400 W/APP_CORE( 4999): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[4000002] -> redirected win[617ee9] for edu.umich.edu.yctung.firsttizenhellp[4999]
04-09 07:10:14.622-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2650].
04-09 07:10:14.662-0400 E/ALARM_MANAGER( 2418): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 169049069, next duetime: 1491736235
04-09 07:10:14.662-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(169049069)
04-09 07:10:14.662-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1491753599), due_time(1491736235)
04-09 07:10:14.662-0400 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-09 07:10:14.662-0400 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-09 07:10:14.662-0400 W/W_INDICATOR( 2651): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-09 07:10:14.672-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-09 07:10:14.672-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-09 07:10:14.672-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-4-2017, 11:10:35 (UTC).
04-09 07:10:14.672-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-09 07:10:14.672-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-09 07:10:14.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:14.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:15.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:15.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:15.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:15.762-0400 I/APP_CORE( 2651): appcore-efl.c: __do_app(453) > [APP 2651] Event: MEM_FLUSH State: PAUSED
04-09 07:10:15.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:15.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:16.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:16.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:16.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:16.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:16.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:17.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:17.382-0400 I/APP_CORE( 2717): appcore-efl.c: __do_app(453) > [APP 2717] Event: MEM_FLUSH State: PAUSED
04-09 07:10:17.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:17.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:17.662-0400 W/SHealthCommon( 3208): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-09 07:10:17.662-0400 W/SHealthService( 3208): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-09 07:10:17.662-0400 W/SHealthCommon( 2942): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-09 07:10:17.672-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [1410.345715] dpms[3 -> 0]sync[0]
04-09 07:10:17.672-0400 I/TDM     ( 1956): 
04-09 07:10:17.672-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [1410.345932] dpms[0 -> 0]done
04-09 07:10:17.672-0400 I/TDM     ( 1956): 
04-09 07:10:17.712-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-09 07:10:17.712-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-09 07:10:17.712-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:17.712-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151753972[0;m
04-09 07:10:17.712-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-09 07:10:17.712-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-09 07:10:17.712-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-09 07:10:17.712-0400 I/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-09 07:10:17.712-0400 W/W_HOME  ( 2717): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-09 07:10:17.712-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-09 07:10:17.712-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-09 07:10:17.712-0400 W/W_HOME  ( 2717): gesture.c: _apps_status_get(128) > apps status:0
04-09 07:10:17.712-0400 W/W_HOME  ( 2717): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:3751
04-09 07:10:17.712-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-09 07:10:17.712-0400 W/W_HOME  ( 2717): event_manager.c: _lcd_on_cb(728) > lcd state: 1
04-09 07:10:17.712-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:10:17.712-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdon_cb(463) >  event lcdon[1][0]
04-09 07:10:17.712-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer-self.c: clock_viewer_self_show_fake_hands(1083) >  Show fake hands default[0]
04-09 07:10:17.712-0400 E/W_CLOCK_VIEWER( 2734): clock-viewer-self.c: __rotate(1038) >  hand geo[161,1][40x360]
04-09 07:10:17.712-0400 E/W_CLOCK_VIEWER( 2734): clock-viewer-self.c: __rotate(1038) >  hand geo[161,1][40x360]
04-09 07:10:17.712-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdon_cb(493) >  lcdon by [powerkey] time[3751]
04-09 07:10:17.722-0400 W/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-09 07:10:17.722-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-09 07:10:17.722-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-09 07:10:17.732-0400 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [3751]ms
04-09 07:10:17.732-0400 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[1]
04-09 07:10:17.742-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [1410.411794] layer(0x447210) not usable
04-09 07:10:17.742-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [1410.411834] layer(0x447210) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-09 07:10:17.742-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [1410.411860] layer[0x446d60]zpos[1]
04-09 07:10:17.742-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [1410.411943] layer(0x447260) not usable
04-09 07:10:17.742-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [1410.411960] layer(0x447260) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-09 07:10:17.742-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [1410.411982] layer[0x446e80]zpos[2]
04-09 07:10:17.742-0400 I/APP_CORE( 4999): appcore-efl.c: __do_app(453) > [APP 4999] Event: RESUME State: PAUSED
04-09 07:10:17.742-0400 I/CAPI_APPFW_APPLICATION( 4999): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-09 07:10:17.742-0400 W/W_HOME  ( 2717): gesture.c: _widget_updated_cb(188) > widget updated
04-09 07:10:17.742-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-09 07:10:17.742-0400 W/W_HOME  ( 2717): gesture.c: _manual_render(182) > 
04-09 07:10:17.762-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2650].
04-09 07:10:17.762-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(169049069)
04-09 07:10:17.762-0400 E/ALARM_MANAGER( 2418): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1850700647) is OVER.
04-09 07:10:17.782-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-09 07:10:17.782-0400 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-09 07:10:17.782-0400 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
04-09 07:10:17.792-0400 W/W_HOME  ( 2717): gesture.c: _manual_render(182) > 
04-09 07:10:17.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:17.792-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3208): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
04-09 07:10:17.792-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3208): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
04-09 07:10:17.792-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3208): preference.c: preference_get_boolean(1173) > preference_get_boolean(3208) : test_healthy_pace error
04-09 07:10:17.802-0400 I/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-09 07:10:17.802-0400 I/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-09 07:10:17.812-0400 W/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-09 07:10:17.812-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-09 07:10:17.812-0400 I/HIGEAR  ( 3270): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-09 07:10:17.832-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_enable(138) > 0
04-09 07:10:17.842-0400 W/SHealthCommon( 3208): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1491696000000.000000[0;m
04-09 07:10:17.862-0400 W/SHealthCommon( 3208): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (289116)]][0;m
04-09 07:10:17.902-0400 W/SHealthCommon( 3208): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-09 07:10:17.912-0400 W/SHealthWidget( 2942): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (289116), msgName: timeline_summary_updated[0;m
04-09 07:10:17.912-0400 W/SHealthCommon( 2942): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
04-09 07:10:17.912-0400 W/SHealthWidget( 2942): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
04-09 07:10:17.912-0400 W/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1491721817919.000000, pattern:[HH:mm][0;m
04-09 07:10:17.912-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-09 07:10:17.912-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-09 07:10:17.912-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-09 07:10:17.912-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-09 07:10:17.912-0400 E/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
04-09 07:10:17.912-0400 W/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[07:10][0;m
04-09 07:10:17.912-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-09 07:10:17.912-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-09 07:10:17.912-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-09 07:10:17.912-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-09 07:10:17.912-0400 I/CAPI_WIDGET_APPLICATION( 2942): widget_app.c: __provider_update_cb(281) > received updating signal
04-09 07:10:17.952-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdon_completed_cb(518) >  event lcdon completed[1]
04-09 07:10:17.952-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer-self.c: clock_viewer_self_hide(1066) >  ===== HIDE =====
04-09 07:10:17.952-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: clock_viewer_hide(1452) >  reservied[0], gesture[0], clock visible[0]
04-09 07:10:17.952-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: _clock_viewer_send_clock_changed(1069) >  clock changed <<
04-09 07:10:17.962-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-09 07:10:17.962-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-09 07:10:17.962-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-4-2017, 15:59:59 (UTC).
04-09 07:10:17.962-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-09 07:10:17.972-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-09 07:10:17.972-0400 E/ALARM_MANAGER( 2418): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[169049069] is removed.
04-09 07:10:17.972-0400 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
04-09 07:10:17.972-0400 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[1]
04-09 07:10:17.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:18.022-0400 I/HealthDataService( 2983): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-09 07:10:18.042-0400 I/healthData( 3208): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-09 07:10:18.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:18.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:18.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:18.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:18.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:19.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:19.352-0400 E/EFL     ( 4999): ecore_x<4999> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1412024 button=1
04-09 07:10:19.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:19.472-0400 E/EFL     ( 4999): ecore_x<4999> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1412147 button=1
04-09 07:10:19.572-0400 D/firsttizenhello( 4999): button is clicked
04-09 07:10:19.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:19.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:19.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:20.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:20.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:20.482-0400 E/EFL     ( 2304): ecore_x<2304> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x4000002 time=1412147
04-09 07:10:20.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:20.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:20.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:21.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:21.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:21.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:21.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:21.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:22.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:22.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:22.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:22.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:22.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:23.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:23.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:23.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:23.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:23.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:24.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:24.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:24.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:24.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:24.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:25.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:10:25.262-0400 W/CRASH_MANAGER( 5069): worker.c: worker_job(1199) > 1104999666972149173622
