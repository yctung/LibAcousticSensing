S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: firsttizenhello
PID: 7160
Date: 2017-04-07 11:05:47-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6e707574

Register Information
r0   = 0x6e707574, r1   = 0x00000025
r2   = 0xfffef3a4, r3   = 0x0000feff
r4   = 0x6e707570, r5   = 0x6e707574
r6   = 0xfffef3a4, r7   = 0x25252525
r8   = 0x00000000, r9   = 0xfffef3a4
r10  = 0x6e707574, fp   = 0xfffeee64
ip   = 0x6e707574, sp   = 0xfffee8e8
lr   = 0xf7407f50, pc   = 0xf74449cc
cpsr = 0x60000010

Memory Information
MemTotal:   714608 KB
MemFree:      9120 KB
Buffers:     56480 KB
Cached:     182300 KB
VmPeak:      84804 KB
VmSize:      82404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24688 KB
VmRSS:       24684 KB
VmData:      20692 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       25176 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7160 TID = 7160
7160 7163 

Maps Information
aaaaa000 aaaac000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
aaabc000 aac66000 rw-p [heap]
f32f4000 f3af3000 rw-p [stack:7163]
f3bb8000 f3bcf000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3d72000 f3d77000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3d7f000 f3d8a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f40b2000 f40bc000 r-xp /lib/libnss_files-2.13.so
f40c5000 f4194000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f41aa000 f41ce000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f41d7000 f42c9000 r-xp /usr/lib/libCOREGL.so.4.0
f42e9000 f42ee000 r-xp /usr/lib/libsystem.so.0.0.0
f42f8000 f42f9000 r-xp /usr/lib/libresponse.so.0.2.96
f4302000 f4307000 r-xp /usr/lib/libproc-stat.so.0.2.96
f4310000 f4317000 r-xp /usr/lib/libminizip.so.1.0.0
f431f000 f4321000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f4329000 f4330000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f4339000 f435b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f4365000 f4368000 r-xp /lib/libattr.so.1.1.0
f4370000 f4378000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4380000 f4386000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f438f000 f4394000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f439c000 f43bd000 r-xp /usr/lib/libexif.so.12.3.3
f43d1000 f43d8000 r-xp /lib/libcrypt-2.13.so
f4408000 f440b000 r-xp /lib/libcap.so.2.21
f4413000 f4415000 r-xp /usr/lib/libiri.so
f441d000 f4436000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f443e000 f4443000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f444c000 f4452000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f445a000 f4477000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f4480000 f4484000 r-xp /usr/lib/libogg.so.0.7.1
f448c000 f44ae000 r-xp /usr/lib/libvorbis.so.0.4.3
f44b7000 f44b9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f44c1000 f44ef000 r-xp /usr/lib/libidn.so.11.5.44
f44f7000 f4500000 r-xp /usr/lib/libcares.so.2.1.0
f4509000 f450b000 r-xp /usr/lib/libXau.so.6.0.0
f4513000 f4515000 r-xp /usr/lib/libttrace.so.1.1
f451e000 f4520000 r-xp /usr/lib/libdri2.so.0.0.0
f4528000 f4530000 r-xp /usr/lib/libdrm.so.2.4.0
f4538000 f4539000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f4542000 f4545000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f454e000 f455d000 r-xp /usr/lib/libmdm-common.so.1.1.22
f4566000 f45fa000 r-xp /usr/lib/libstdc++.so.6.0.16
f460d000 f4611000 r-xp /usr/lib/libsmack.so.1.0.0
f461a000 f47c3000 r-xp /usr/lib/libcrypto.so.1.0.0
f47e4000 f482b000 r-xp /usr/lib/libssl.so.1.0.0
f4837000 f4866000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f486e000 f48b5000 r-xp /usr/lib/libsndfile.so.1.0.26
f48c1000 f490a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f4913000 f4918000 r-xp /usr/lib/libjson.so.0.0.1
f4921000 f4924000 r-xp /usr/lib/libtinycompress.so.0.0.0
f492c000 f492e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f4936000 f4946000 r-xp /lib/libresolv-2.13.so
f494a000 f4962000 r-xp /usr/lib/liblzma.so.5.0.3
f496b000 f496d000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f4975000 f4a48000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f4a53000 f4a58000 r-xp /usr/lib/libffi.so.5.0.10
f4a60000 f4aa4000 r-xp /usr/lib/libcurl.so.4.3.0
f4aae000 f4ad1000 r-xp /usr/lib/libjpeg.so.8.0.2
f4ae9000 f4afc000 r-xp /usr/lib/libxcb.so.1.1.0
f4b05000 f4b0b000 r-xp /usr/lib/libxcb-render.so.0.0.0
f4b13000 f4b14000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f4b1d000 f4b35000 r-xp /usr/lib/libpng12.so.0.50.0
f4b3e000 f4b42000 r-xp /usr/lib/libEGL.so.1.4
f4b52000 f4b63000 r-xp /usr/lib/libGLESv2.so.2.0
f4b73000 f4b74000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f4b7c000 f4b93000 r-xp /usr/lib/liblua-5.1.so
f4b9c000 f4ba3000 r-xp /usr/lib/libembryo.so.1.7.99
f4bac000 f4bb7000 r-xp /usr/lib/libtbm.so.1.0.0
f4bbf000 f4be2000 r-xp /usr/lib/libui-extension.so.0.1.0
f4beb000 f4c01000 r-xp /usr/lib/libtts.so
f4c0a000 f4c20000 r-xp /lib/libz.so.1.2.5
f4c28000 f4c3e000 r-xp /lib/libexpat.so.1.6.0
f4c49000 f4c4c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f4c54000 f4c58000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f4c61000 f4c66000 r-xp /usr/lib/libecore_fb.so.1.7.99
f4c6f000 f4c79000 r-xp /usr/lib/libXext.so.6.4.0
f4c82000 f4c86000 r-xp /usr/lib/libXtst.so.6.1.0
f4c8f000 f4c95000 r-xp /usr/lib/libXrender.so.1.3.0
f4c9d000 f4ca3000 r-xp /usr/lib/libXrandr.so.2.2.0
f4cab000 f4cac000 r-xp /usr/lib/libXinerama.so.1.0.0
f4cb5000 f4cb8000 r-xp /usr/lib/libXfixes.so.3.1.0
f4cc0000 f4cc2000 r-xp /usr/lib/libXgesture.so.7.0.0
f4cca000 f4ccc000 r-xp /usr/lib/libXcomposite.so.1.0.0
f4cd5000 f4cd7000 r-xp /usr/lib/libXdamage.so.1.1.0
f4cdf000 f4ce6000 r-xp /usr/lib/libXcursor.so.1.0.2
f4cee000 f4d36000 r-xp /usr/lib/libmdm.so.1.2.62
f65c8000 f66ce000 r-xp /usr/lib/libicuuc.so.57.1
f66e5000 f686d000 r-xp /usr/lib/libicui18n.so.57.1
f687d000 f687f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6888000 f6895000 r-xp /usr/lib/libail.so.0.1.0
f689e000 f68a1000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f68a9000 f68e1000 r-xp /usr/lib/libpulse.so.0.16.2
f68e2000 f68e5000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f68ee000 f694f000 r-xp /usr/lib/libasound.so.2.0.0
f6959000 f696f000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f6977000 f697e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f6986000 f698a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f6992000 f6993000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f699c000 f69a7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f69b4000 f69b8000 r-xp /usr/lib/libmmfsession.so.0.0.0
f69c1000 f69c7000 r-xp /lib/librt-2.13.so
f69d0000 f6a45000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a4f000 f6a69000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a72000 f6a90000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a9a000 f6a9b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6aa3000 f6aa8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ab0000 f6ac7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6acf000 f6ad1000 r-xp /usr/lib/libiniparser.so.0
f6adb000 f6b0f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b18000 f6b1e000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6b26000 f6b29000 r-xp /usr/lib/libbundle.so.0.1.22
f6b31000 f6b37000 r-xp /usr/lib/libappsvc.so.0.1.0
f6b3f000 f6b95000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6ba3000 f6bf9000 r-xp /usr/lib/libfreetype.so.6.11.3
f6c05000 f6c4a000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c53000 f6c66000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c6e000 f6c88000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c91000 f6cbb000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cc5000 f6cce000 r-xp /usr/lib/libedbus.so.1.7.99
f6cd6000 f6ce7000 r-xp /usr/lib/libecore_input.so.1.7.99
f6cef000 f6cf4000 r-xp /usr/lib/libecore_file.so.1.7.99
f6cfc000 f6d15000 r-xp /usr/lib/libeet.so.1.7.99
f6d26000 f6d2f000 r-xp /usr/lib/libXi.so.6.1.0
f6d38000 f6e19000 r-xp /usr/lib/libX11.so.6.3.0
f6e24000 f6edc000 r-xp /usr/lib/libcairo.so.2.11200.14
f6ee7000 f6f45000 r-xp /usr/lib/libedje.so.1.7.99
f6f4f000 f6f66000 r-xp /usr/lib/libecore.so.1.7.99
f6f7d000 f6fe6000 r-xp /lib/libm-2.13.so
f6fef000 f7001000 r-xp /usr/lib/libefl-assist.so.0.1.0
f7009000 f70d9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70da000 f71a6000 r-xp /usr/lib/libxml2.so.2.7.8
f71b3000 f71db000 r-xp /usr/lib/libfontconfig.so.1.8.0
f71dc000 f71e5000 r-xp /usr/lib/libvconf.so.0.2.45
f71ed000 f720f000 r-xp /usr/lib/libecore_evas.so.1.7.99
f7218000 f7268000 r-xp /usr/lib/libecore_x.so.1.7.99
f726a000 f726f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7277000 f728e000 r-xp /usr/lib/libmmfsound.so.0.1.0
f72a0000 f72b4000 r-xp /lib/libpthread-2.13.so
f72bf000 f7300000 r-xp /usr/lib/libeina.so.1.7.99
f7309000 f732c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7334000 f7341000 r-xp /usr/lib/libaul.so.0.1.0
f734b000 f7350000 r-xp /usr/lib/libappcore-common.so.1.1
f7358000 f735e000 r-xp /usr/lib/libappcore-efl.so.1.1
f7366000 f7368000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7371000 f7375000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f737e000 f7380000 r-xp /lib/libdl-2.13.so
f7389000 f7394000 r-xp /lib/libunwind.so.8.0.1
f73c1000 f73c9000 r-xp /lib/libgcc_s-4.6.so.1
f73ca000 f74ee000 r-xp /lib/libc-2.13.so
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

Callstack Information (PID:7160)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0xf74449cc) [/lib/libc.so.6] + 0x7a9cc
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
erList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
04-07 11:07:50.361-0400 W/WG-CONSUMER( 6703): [34m[F:ConnectionInfo.c L:  619][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
04-07 11:07:50.371-0400 I/CAPI_CONTENT_MEDIA_CONTENT( 6703): media_content.c: media_content_disconnect(958) > [32m[6703]ref count changed to: 0
04-07 11:07:50.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:50.481-0400 E/WG-CONSUMER( 6703): [31m[F:consumer-app.cpp L:  433][ERROR]Terminate main. nRet=0[0m
04-07 11:07:50.481-0400 W/WG-CONSUMER( 6703): [34m[F:ReceiverCtrl.cpp L:   88][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
04-07 11:07:50.481-0400 W/WG-CONSUMER( 6703): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0xf772f574)[0m
04-07 11:07:50.481-0400 W/WG-CONSUMER( 6703): [34m[F:TransferCtrl.cpp L:   97][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
04-07 11:07:50.481-0400 W/WG-CONSUMER( 6703): [34m[F:AlarmSvc.cpp     L:   96][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
04-07 11:07:50.481-0400 E/WG-CONSUMER( 6703): [31m[F:ConnectionInfo.c L:  148][ERROR]Unegister db/wms/host_status/vendor is failed[0m
04-07 11:07:50.481-0400 W/WG-CONSUMER( 6703): [34m[F:BAPProxy.cpp     L:   80][_HIGH]Destroying BAP Proxy Object. 0xf7729c00[0m
04-07 11:07:50.481-0400 W/WG-CONSUMER( 6703): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0xf772aa2c)[0m
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-07 11:07:50.501-0400 E/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
04-07 11:07:50.501-0400 E/MESSAGE_PORT( 2429): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(6703) are closed. delete client info
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
04-07 11:07:50.501-0400 E/MESSAGE_PORT( 2429): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  6703
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: UnregisterMessagePortByDiscon(273) > _MessagePortService::UnregisterMessagePortByDiscon
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.501-0400 I/MESSAGE_PORT( 2429): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
04-07 11:07:50.511-0400 W/AUL     ( 7179): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
04-07 11:07:50.511-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 23
04-07 11:07:50.511-0400 W/AUL_AMD ( 2434): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-07 11:07:50.511-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6703
04-07 11:07:50.511-0400 W/AUL_AMD ( 2434): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-07 11:07:50.521-0400 I/AUL_AMD ( 2434): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6703
04-07 11:07:50.521-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6703)
04-07 11:07:50.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:50.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:50.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:51.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:51.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:51.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:51.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:51.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:52.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:52.311-0400 W/AUL_AMD ( 2434): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-07 11:07:52.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:52.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:52.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:52.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:53.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:53.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:53.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:53.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:53.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:54.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:54.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:54.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:54.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:54.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:55.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:55.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:55.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:55.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:55.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:56.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:56.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:56.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:56.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:56.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:57.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:57.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:57.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:57.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:57.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:58.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:58.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:58.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:58.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:58.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:59.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:59.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:59.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:59.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:07:59.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:00.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:00.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:00.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:00.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:00.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:01.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:01.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:01.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:01.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:01.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:02.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:02.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:02.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:02.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:02.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:03.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:03.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:03.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:03.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:03.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:04.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:04.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:04.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:04.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:04.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:05.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:05.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:05.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:05.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:05.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:06.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:06.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:06.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:06.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:06.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:07.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:07.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:07.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:07.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:07.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:08.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:08.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:08.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:08.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:08.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:09.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:09.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:09.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:09.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:09.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:10.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:10.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:10.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:10.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:10.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:11.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:11.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:11.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:11.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:11.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:12.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:12.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:12.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:12.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:12.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:13.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:13.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:13.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:13.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:13.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:14.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:14.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:14.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:14.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:14.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:15.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:15.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:15.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:15.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:15.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:16.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:16.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:16.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:16.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:16.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:17.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:17.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:17.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:17.611-0400 D/chronograph( 2893): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(124) > [0;32mBEGIN >>>>[0;m
04-07 11:08:17.611-0400 D/chronograph( 2893): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(137) > mSweep60SStartValue[39.998001] mCurrentValue[17.627001]
04-07 11:08:17.611-0400 D/chronograph( 2893): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(171) > speed down by 6 degree in 60 seconds
04-07 11:08:17.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:17.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:18.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:18.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:18.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:18.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:18.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:19.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:19.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:19.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:19.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:19.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:20.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:20.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:20.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:20.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:20.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:21.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:21.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:21.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:21.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:21.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:22.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:22.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:22.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:22.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:22.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:23.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:23.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:23.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:23.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:23.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:24.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:24.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:24.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:24.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:24.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:25.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:25.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:25.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:25.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:25.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:26.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:26.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:26.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:26.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:26.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:27.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:27.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:27.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:27.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:27.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:28.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:28.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:28.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:28.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:28.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:29.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:29.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:29.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:29.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:29.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:30.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:30.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:30.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:30.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:30.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:31.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:31.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:31.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:31.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:31.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:32.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:32.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:32.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:32.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:32.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:33.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:33.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:33.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:33.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:33.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:34.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:34.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:34.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:34.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:34.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:35.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:35.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:35.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:35.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:35.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:36.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:36.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:36.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:36.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:36.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:37.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:37.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:37.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:37.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:37.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:38.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:38.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:38.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:38.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:38.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:39.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:39.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:39.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:39.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:39.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:40.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:40.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:40.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:40.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:40.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:41.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:41.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:41.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:41.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:41.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:42.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:42.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:42.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:42.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:42.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:43.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:43.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:43.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:43.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:43.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:44.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:44.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:44.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:44.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:44.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:45.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:45.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:45.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:45.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:45.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:46.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:46.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:46.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:46.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:46.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:47.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:47.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:47.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:47.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:47.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:48.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:48.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:48.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:48.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:48.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:49.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:49.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:49.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:49.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:49.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:50.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:50.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:50.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:50.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:50.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:51.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:51.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:51.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:51.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:51.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:52.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:52.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:52.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:52.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:52.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:53.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:53.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:53.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:53.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:53.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:54.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:54.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:54.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:54.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:54.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:55.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:55.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:55.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:55.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:55.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:56.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:56.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:56.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:56.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:56.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:57.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:57.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:57.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:57.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:57.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:58.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 11:08:58.341-0400 W/CRASH_MANAGER( 7184): worker.c: worker_job(1199) > 1107160666972149157754
