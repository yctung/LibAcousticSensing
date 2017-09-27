S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: firsttizenhello
PID: 13473
Date: 2017-04-07 15:18:51-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13473, uid 5000)

Register Information
r0   = 0x00000023, r1   = 0x00000000
r2   = 0x90bfb900, r3   = 0x90bfb900
r4   = 0x00000003, r5   = 0xf6105770
r6   = 0xf7864370, r7   = 0xffabd020
r8   = 0x00000000, r9   = 0xf78ca308
r10  = 0xf78c6330, fp   = 0x00000001
ip   = 0xf6145084, sp   = 0xffabcfb8
lr   = 0xf6105613, pc   = 0xf6105616
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     10440 KB
Buffers:     51364 KB
Cached:     171700 KB
VmPeak:     109220 KB
VmSize:     109216 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25644 KB
VmRSS:       25640 KB
VmData:      38268 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25316 KB
VmPTE:         128 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 13473 TID = 13473
13473 13551 13552 13553 13584 

Maps Information
f0db1000 f15b0000 rw-p [stack:13584]
f15b0000 f15bb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f15c3000 f15c5000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f15cd000 f15ce000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f15d6000 f15de000 r-xp /usr/lib/libfeedback.so.0.1.4
f15f7000 f15f8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1705000 f1706000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f170e000 f1711000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f17cf000 f1fce000 rw-p [stack:13553]
f23d0000 f2bcf000 rw-p [stack:13552]
f2fd1000 f37d0000 rw-p [stack:13551]
f3892000 f38a9000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f38b6000 f38bb000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f38c3000 f38ce000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3bf6000 f3ce8000 r-xp /usr/lib/libCOREGL.so.4.0
f3d01000 f3d06000 r-xp /usr/lib/libsystem.so.0.0.0
f3d10000 f3d11000 r-xp /usr/lib/libresponse.so.0.2.96
f3d19000 f3d1e000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3d27000 f3d2e000 r-xp /usr/lib/libminizip.so.1.0.0
f3d36000 f3d38000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3d40000 f3d47000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3d50000 f3d72000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3d7b000 f3d83000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3d8b000 f3d91000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3d9a000 f3d9f000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3da7000 f3dc8000 r-xp /usr/lib/libexif.so.12.3.3
f3ddb000 f3df4000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3dfc000 f3e01000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3e09000 f3e0f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3e17000 f3e1b000 r-xp /usr/lib/libogg.so.0.7.1
f3e23000 f3e45000 r-xp /usr/lib/libvorbis.so.0.4.3
f3e4d000 f3e4f000 r-xp /usr/lib/libttrace.so.1.1
f3e57000 f3e59000 r-xp /usr/lib/libdri2.so.0.0.0
f3e61000 f3e69000 r-xp /usr/lib/libdrm.so.2.4.0
f3e71000 f3e72000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3e7b000 f3e7e000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3e86000 f3e95000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3e9e000 f3ee5000 r-xp /usr/lib/libsndfile.so.1.0.26
f3ef1000 f3f3a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3f43000 f3f48000 r-xp /usr/lib/libjson.so.0.0.1
f3f50000 f3f53000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3f5b000 f3f61000 r-xp /usr/lib/libxcb-render.so.0.0.0
f3f69000 f3f6a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f3f73000 f3f77000 r-xp /usr/lib/libEGL.so.1.4
f3f87000 f3f98000 r-xp /usr/lib/libGLESv2.so.2.0
f3fa8000 f3fb3000 r-xp /usr/lib/libtbm.so.1.0.0
f3fbb000 f3fde000 r-xp /usr/lib/libui-extension.so.0.1.0
f3fe7000 f3ffd000 r-xp /usr/lib/libtts.so
f4006000 f404e000 r-xp /usr/lib/libmdm.so.1.2.62
f58e0000 f59e6000 r-xp /usr/lib/libicuuc.so.57.1
f59fc000 f5b84000 r-xp /usr/lib/libicui18n.so.57.1
f5b94000 f5ba1000 r-xp /usr/lib/libail.so.0.1.0
f5baa000 f5bad000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f5bb5000 f5bed000 r-xp /usr/lib/libpulse.so.0.16.2
f5bee000 f5bf1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5bf9000 f5c5a000 r-xp /usr/lib/libasound.so.2.0.0
f5c64000 f5c7a000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5c82000 f5c89000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f5c91000 f5c95000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5c9d000 f5ca8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5cb5000 f5cb9000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5cc2000 f5d7a000 r-xp /usr/lib/libcairo.so.2.11200.14
f5d85000 f5d97000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5d9f000 f5da4000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5dac000 f5dc3000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5dd5000 f5df6000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5dfe000 f5e05000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f5e10000 f5e1b000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5fb5000 f5fbf000 r-xp /lib/libnss_files-2.13.so
f5fc8000 f6097000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f60ad000 f60d1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f60da000 f60e0000 r-xp /usr/lib/libappsvc.so.0.1.0
f60e8000 f60ea000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f60f3000 f60f7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6104000 f6106000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
f6116000 f6118000 r-xp /usr/lib/libiniparser.so.0
f6121000 f6126000 r-xp /usr/lib/libappcore-common.so.1.1
f612f000 f6137000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f6138000 f613c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6149000 f614b000 r-xp /usr/lib/libXau.so.6.0.0
f6153000 f615a000 r-xp /lib/libcrypt-2.13.so
f618a000 f618c000 r-xp /usr/lib/libiri.so
f6195000 f633e000 r-xp /usr/lib/libcrypto.so.1.0.0
f635e000 f63a5000 r-xp /usr/lib/libssl.so.1.0.0
f63b1000 f63df000 r-xp /usr/lib/libidn.so.11.5.44
f63e7000 f63f0000 r-xp /usr/lib/libcares.so.2.1.0
f63fa000 f640d000 r-xp /usr/lib/libxcb.so.1.1.0
f6416000 f6418000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6420000 f6422000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f642b000 f64f7000 r-xp /usr/lib/libxml2.so.2.7.8
f6504000 f6506000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f650f000 f6514000 r-xp /usr/lib/libffi.so.5.0.10
f651c000 f651d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6525000 f6528000 r-xp /lib/libattr.so.1.1.0
f6530000 f65c4000 r-xp /usr/lib/libstdc++.so.6.0.16
f65d7000 f65f4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65fe000 f6616000 r-xp /usr/lib/libpng12.so.0.50.0
f661e000 f6634000 r-xp /lib/libexpat.so.1.6.0
f663e000 f6682000 r-xp /usr/lib/libcurl.so.4.3.0
f668b000 f6695000 r-xp /usr/lib/libXext.so.6.4.0
f669e000 f66a2000 r-xp /usr/lib/libXtst.so.6.1.0
f66aa000 f66b0000 r-xp /usr/lib/libXrender.so.1.3.0
f66b8000 f66be000 r-xp /usr/lib/libXrandr.so.2.2.0
f66c6000 f66c7000 r-xp /usr/lib/libXinerama.so.1.0.0
f66d0000 f66d9000 r-xp /usr/lib/libXi.so.6.1.0
f66e1000 f66e4000 r-xp /usr/lib/libXfixes.so.3.1.0
f66ec000 f66ee000 r-xp /usr/lib/libXgesture.so.7.0.0
f66f6000 f66f8000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6700000 f6702000 r-xp /usr/lib/libXdamage.so.1.1.0
f670a000 f6711000 r-xp /usr/lib/libXcursor.so.1.0.2
f6719000 f671c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6724000 f6728000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6731000 f6736000 r-xp /usr/lib/libecore_fb.so.1.7.99
f673f000 f6820000 r-xp /usr/lib/libX11.so.6.3.0
f682b000 f684e000 r-xp /usr/lib/libjpeg.so.8.0.2
f6866000 f687c000 r-xp /lib/libz.so.1.2.5
f6884000 f6886000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f688e000 f6903000 r-xp /usr/lib/libsqlite3.so.0.8.6
f690d000 f6927000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f692f000 f6963000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f696c000 f6a3f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a4a000 f6a5a000 r-xp /lib/libresolv-2.13.so
f6a5e000 f6a76000 r-xp /usr/lib/liblzma.so.5.0.3
f6a7e000 f6a81000 r-xp /lib/libcap.so.2.21
f6a89000 f6ab8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ac0000 f6ac1000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6ac9000 f6acf000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6ad7000 f6aee000 r-xp /usr/lib/liblua-5.1.so
f6af7000 f6afe000 r-xp /usr/lib/libembryo.so.1.7.99
f6b06000 f6b0c000 r-xp /lib/librt-2.13.so
f6b15000 f6b6b000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b78000 f6bce000 r-xp /usr/lib/libfreetype.so.6.11.3
f6bda000 f6c02000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6c03000 f6c48000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c51000 f6c64000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c6c000 f6c86000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c8f000 f6c98000 r-xp /usr/lib/libedbus.so.1.7.99
f6ca0000 f6cf0000 r-xp /usr/lib/libecore_x.so.1.7.99
f6cf2000 f6cfb000 r-xp /usr/lib/libvconf.so.0.2.45
f6d03000 f6d14000 r-xp /usr/lib/libecore_input.so.1.7.99
f6d1c000 f6d21000 r-xp /usr/lib/libecore_file.so.1.7.99
f6d29000 f6d4b000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6d54000 f6d95000 r-xp /usr/lib/libeina.so.1.7.99
f6d9e000 f6db7000 r-xp /usr/lib/libeet.so.1.7.99
f6dc8000 f6e31000 r-xp /lib/libm-2.13.so
f6e3a000 f6e40000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e49000 f6e4a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e52000 f6e75000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e7d000 f6e82000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e8a000 f6eb4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ebd000 f6ed4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6edc000 f6ee7000 r-xp /lib/libunwind.so.8.0.1
f6f14000 f6f32000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f3c000 f7060000 r-xp /lib/libc-2.13.so
f706e000 f7076000 r-xp /lib/libgcc_s-4.6.so.1
f7077000 f707b000 r-xp /usr/lib/libsmack.so.1.0.0
f7084000 f708a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f7092000 f7162000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7163000 f71c1000 r-xp /usr/lib/libedje.so.1.7.99
f71cb000 f71e2000 r-xp /usr/lib/libecore.so.1.7.99
f71f9000 f72c7000 r-xp /usr/lib/libevas.so.1.7.99
f72ec000 f7428000 r-xp /usr/lib/libelementary.so.1.7.99
f743f000 f7453000 r-xp /lib/libpthread-2.13.so
f745e000 f7460000 r-xp /usr/lib/libdlog.so.0.0.0
f7468000 f746b000 r-xp /usr/lib/libbundle.so.0.1.22
f7473000 f7475000 r-xp /lib/libdl-2.13.so
f747e000 f748b000 r-xp /usr/lib/libaul.so.0.1.0
f749c000 f74a2000 r-xp /usr/lib/libappcore-efl.so.1.1
f74ab000 f74af000 r-xp /usr/lib/libsys-assert.so
f74b8000 f74d5000 r-xp /lib/ld-2.13.so
f74de000 f74e3000 r-xp /usr/bin/launchpad-loader
f7764000 f790d000 rw-p [heap]
ffa9d000 ffabe000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13473)
Call Stack Count: 17
 0: button_clicked_request_cb + 0x3d (0xf6105616) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1616
 1: evas_object_smart_callback_call + 0x88 (0xf722e5cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf71a8f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf71acefd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf71a9869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf71a9c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf71a9d55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf71d63f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf71d3e53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf71d746b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf71d7879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf749fb47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf613a421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x12e (0xf61051eb) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x11eb
14: (0xf74dfa53) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1a53
15: __libc_start_main + 0x114 (0xf6f5385c) [/lib/libc.so.6] + 0x1785c
16: (0xf74dfe0c) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1e0c
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
se(611) > app_appcore_pause
04-07 15:14:31.461-0400 W/APP_CORE(13473): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3000002] -> redirected win[6e1033] for edu.umich.edu.yctung.firsttizenhellp[13473]
04-07 15:14:32.011-0400 W/AUL_AMD ( 2434): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-07 15:14:32.011-0400 W/AUL_AMD ( 2434): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
04-07 15:14:32.111-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 14
04-07 15:14:32.121-0400 W/AUL_AMD ( 2434): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13473
04-07 15:14:32.121-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 14
04-07 15:14:32.141-0400 W/AUL_AMD ( 2434): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13473
04-07 15:14:32.141-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 12
04-07 15:14:32.141-0400 W/AUL_AMD ( 2434): amd_request.c: __request_handler(669) > __request_handler: 12
04-07 15:14:32.311-0400 I/AUL_PAD (13554): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-07 15:14:36.461-0400 I/APP_CORE(13473): appcore-efl.c: __do_app(453) > [APP 13473] Event: MEM_FLUSH State: PAUSED
04-07 15:15:00.711-0400 W/SHealthService( 2948): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(678) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-07 15:15:00.731-0400 W/SHealthCommon( 2948): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: pedo_update client list: [2:com.samsung.shealth.widget.pedometer (393574)]][0;m
04-07 15:15:00.771-0400 W/SHealthCommon( 2948): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-07 15:15:00.771-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-07 15:15:00.771-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-07 15:15:00.771-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_get_int(1132) > preference_get_int(2948) : key(pedometer_goal_achieve_percents) error
04-07 15:15:00.771-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-07 15:15:00.771-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-07 15:15:00.771-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-07 15:15:00.771-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-07 15:15:00.771-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_get_int(1132) > preference_get_int(2948) : key(best_step_goal) error
04-07 15:15:00.781-0400 I/HealthDataService( 3003): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-07 15:15:00.791-0400 W/SHealthWidget( 2966): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.pedometer (393574), msgName: pedo_update[0;m
04-07 15:15:00.801-0400 I/healthData( 2948): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-07 15:15:00.801-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
04-07 15:15:00.811-0400 W/SHealthCommon( 2966): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: pedo_update[0;m
04-07 15:15:00.811-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
04-07 15:15:00.811-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_get_boolean(1173) > preference_get_boolean(2948) : test_healthy_pace error
04-07 15:15:00.811-0400 W/SHealthWidget( 2966): PedometerWidgetViewController.cpp: OnIpcProxyMessageReceived(112) > [1;35mmsgName:[pedo_update], serializedStr:[calorie:0.000000,distance:0.000000,down_step:0,run_step:0,speed:0.000000,step:0,up_step:0,walk_step:0][0;m
04-07 15:15:00.811-0400 W/SHealthWidget( 2966): PedometerWidgetViewController.cpp: OnIpcProxyMessageReceived(120) > [1;40;33mmCurrentSteps = 0[0;m
04-07 15:15:00.811-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-07 15:15:00.811-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-07 15:15:00.811-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-07 15:15:00.811-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-07 15:15:00.811-0400 W/SHealthWidget( 2966): PedometerWidgetViewController.cpp: UpdateSteps(170) > [1;35mrate:0.000000[0;m
04-07 15:15:00.811-0400 W/SHealthWidget( 2966): PedometerWidgetViewController.cpp: UpdateSteps(181) > [1;35mmCurrentSteps:0, mCurrentGoal:6000, ratePercent:0.000000[0;m
04-07 15:15:00.811-0400 W/SHealthWidget( 2966): PedometerWidgetView.cpp: SetGoalAchievedPercent(272) > [1;35mpercent:0.000000[0;m
04-07 15:15:00.811-0400 W/SHealthAppCommon( 2966): TriangleProgressWidget.cpp: UpdateProgress(58) > [1;35mprogressRate:0.000000[0;m
04-07 15:15:00.811-0400 W/SHealthAppCommon( 2966): TriangleProgressWidget.cpp: UpdateProgress(61) > [1;35mheight:0[0;m
04-07 15:15:00.811-0400 I/CAPI_WIDGET_APPLICATION( 2966): widget_app.c: __provider_update_cb(281) > received updating signal
04-07 15:15:00.821-0400 E/EFL     ( 2966): edje<2966> edje_util.c:3785 edje_object_size_min_restricted_calc() group triangle_progress_layout has a non-fixed part 'part_level_image'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-07 15:15:01.271-0400 W/SHealthService( 2948): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-07 15:18:47.861-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-07 15:18:47.861-0400 I/WATCH_CORE( 2893): appcore-watch.c: __signal_context_handler(1308) > Skip the context signal in ambient mode
04-07 15:18:47.871-0400 W/WECONN  ( 2423): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
04-07 15:18:47.871-0400 W/WECONN  ( 2423): <__wc_device_on_wear_onoff_changed_cb:353> { state=WC_FEATURE_STATE_OFF
04-07 15:18:47.871-0400 W/WECONN  ( 2423): <__wc_device_on_wear_onoff_changed_cb:384> }
04-07 15:18:47.871-0400 W/WECONN  ( 2423): <__wc_feature_wearonoff_monitor_cb:531> }
04-07 15:18:47.871-0400 E/wnoti-service( 3056): wnoti-db-utility.c: context_wearonoff_status_cb(2092) > status changed from 1 to 2 
04-07 15:18:47.871-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_monitor_cb(183) >  wearonoff_monitor_cb called error[0], context[45], data[{ "Time" : 1491592727876, "Reason" : 36, "Status" : 2 }], req_id[1]
04-07 15:18:47.871-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_monitor_cb(199) >  status[2] Wear OFF, enabled[1]
04-07 15:18:47.871-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer-smart-lcdoff.c: __clock_viewer_smart_lcdoff_wear_status_changed_cb(101) >  status[0], alarm[0], started[1]
04-07 15:18:47.871-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer-smart-lcdoff.c: __clock_viewer_smart_lcdoff_alarm_cb(79) >  clock tick block >>
04-07 15:18:47.871-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer-smart-lcdoff.c: __clock_viewer_smart_lcdoff_alarm_cb(82) >  ALPMLCDOff >>
04-07 15:18:47.871-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: _clock_viewer_remove_alarms(887) >  Delete alarm id[1329970444] by [from_smart_lcdoff], fini[1]
04-07 15:18:47.881-0400 E/WMS     ( 2411): wms_bap_event_handler.c: _wms_bap_event_handler_cb_wearonoff_monitor(14012) > _bap_wear_monitor_status update[0] = 1 -> 2
04-07 15:18:47.881-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_alpm_handler(1151) > signal_alpm_handler: ambient mode: 2, state: 3
04-07 15:18:47.881-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_alpm_handler(1215) > Disable the alarm
04-07 15:18:47.891-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [3464].
04-07 15:18:47.891-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1329970444)
04-07 15:18:48.131-0400 I/TDM     ( 1375): tdm_display.c: tdm_layer_unset_buffer(1602) > [20295.682037] layer(0x8c9210) now usable
04-07 15:18:48.131-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20295.682082] layer[0x8c8d60]zpos[1]
04-07 15:18:48.131-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_output_set_property(1184) > [20295.682211] id[0]
04-07 15:18:48.131-0400 I/TDM     ( 1375): tdm_exynos_display.c: __exynos_output_aod_change_state(1142) > [20295.682231] aod_change_state:mode[3]
04-07 15:18:48.131-0400 I/TDM     ( 1375): tdm_exynos_display.c: __exynos_output_aod_change_state(1149) > [20295.682250] aod_change_state:state[1 -> 0]
04-07 15:18:48.181-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [20295.730459] dpms[0 -> 3]sync[1]
04-07 15:18:48.181-0400 I/TDM     ( 1375): 
04-07 15:18:48.311-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [20295.861292] dpms[3 -> 3]done
04-07 15:18:48.311-0400 I/TDM     ( 1375): 
04-07 15:18:48.331-0400 W/STARTER ( 2804): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-07 15:18:48.331-0400 W/STARTER ( 2804): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[1]
04-07 15:18:48.341-0400 W/STARTER ( 2804): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-07 15:18:48.341-0400 W/STARTER ( 2804): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
04-07 15:18:48.341-0400 E/ALARM_MANAGER( 2804): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(7-4-2017, 15:19:08), repeat(1), interval(20), type(-1073741822)
04-07 15:18:48.361-0400 W/W_INDICATOR( 2817): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-07 15:18:48.361-0400 W/W_INDICATOR( 2817): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-07 15:18:48.361-0400 W/W_INDICATOR( 2817): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-07 15:18:48.361-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-07 15:18:48.361-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 15:18:48.361-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-4-2017, 23:25:10 (UTC).
04-07 15:18:48.361-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 15:18:48.361-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-07 15:18:48.371-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-07 15:18:48.371-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1329970444] is removed.
04-07 15:18:48.371-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-07 15:18:48.371-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2893].
04-07 15:18:48.371-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(558667318)
04-07 15:18:48.371-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(668) >  event lcdoff completed[1][0]
04-07 15:18:48.371-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(413) >  enabled[1] status[0] setup[0] darkscreen[0]
04-07 15:18:48.371-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(688) >  Skip if wear off status
04-07 15:18:48.381-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-07 15:18:48.381-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 15:18:48.381-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-4-2017, 23:25:10 (UTC).
04-07 15:18:48.381-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 15:18:48.381-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-07 15:18:48.391-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-07 15:18:48.391-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[558667318] is removed.
04-07 15:18:48.391-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-07 15:18:48.391-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2804].
04-07 15:18:48.411-0400 E/ALARM_MANAGER( 2409): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 234229205, next duetime: 1491592748
04-07 15:18:48.411-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(234229205)
04-07 15:18:48.421-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1491607510), due_time(1491592748)
04-07 15:18:48.421-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-07 15:18:48.421-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 15:18:48.421-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-4-2017, 19:19:08 (UTC).
04-07 15:18:48.421-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 15:18:48.421-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-07 15:18:48.431-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-07 15:18:48.431-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-07 15:18:48.641-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-07 15:18:48.641-0400 I/WATCH_CORE( 2893): appcore-watch.c: __signal_context_handler(1308) > Skip the context signal in ambient mode
04-07 15:18:48.641-0400 W/WAKEUP-SERVICE( 3339): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -148532832[0;m
04-07 15:18:48.641-0400 W/WAKEUP-SERVICE( 3339): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
04-07 15:18:48.641-0400 W/WAKEUP-SERVICE( 3339): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-07 15:18:48.641-0400 I/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-07 15:18:48.651-0400 W/W_HOME  ( 2844): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
04-07 15:18:48.651-0400 W/W_HOME  ( 2844): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-07 15:18:48.651-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [20296.205471] dpms[3 -> 0]sync[0]
04-07 15:18:48.651-0400 I/TDM     ( 1375): 
04-07 15:18:48.651-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [20296.205667] dpms[0 -> 0]done
04-07 15:18:48.651-0400 I/TDM     ( 1375): 
04-07 15:18:48.651-0400 W/SHealthCommon( 2966): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-07 15:18:48.661-0400 W/SHealthCommon( 2948): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-07 15:18:48.661-0400 W/SHealthService( 2948): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-07 15:18:48.711-0400 W/wnotibp (13104): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
04-07 15:18:48.711-0400 I/wnotibp (13104): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
04-07 15:18:48.721-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: __clock_viewer_lcdon_cb(463) >  event lcdon[1][0]
04-07 15:18:48.721-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer-self.c: clock_viewer_self_show_fake_hands(1083) >  Show fake hands default[0]
04-07 15:18:48.721-0400 E/W_CLOCK_VIEWER( 3464): clock-viewer-self.c: __rotate(1038) >  hand geo[160,-1][40x360]
04-07 15:18:48.721-0400 E/W_CLOCK_VIEWER( 3464): clock-viewer-self.c: __rotate(1038) >  hand geo[160,-1][40x360]
04-07 15:18:48.721-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: __clock_viewer_lcdon_cb(493) >  lcdon by [gesture] time[279980]
04-07 15:18:48.741-0400 W/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-07 15:18:48.751-0400 E/WAKEUP-SERVICE( 3339): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-07 15:18:48.751-0400 I/TDM     ( 1375): tdm_display.c: tdm_layer_set_info(1442) > [20296.302264] layer(0x8c9210) not usable
04-07 15:18:48.751-0400 I/TDM     ( 1375): tdm_display.c: tdm_layer_set_info(1459) > [20296.302305] layer(0x8c9210) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-07 15:18:48.751-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_layer_set_info(1578) > [20296.302332] layer[0x8c8d60]zpos[1]
04-07 15:18:48.751-0400 I/TDM     ( 1375): tdm_display.c: tdm_layer_set_info(1459) > [20296.302415] layer(0x8c9260) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-07 15:18:48.751-0400 I/TDM     ( 1375): tdm_exynos_display.c: exynos_layer_set_info(1578) > [20296.302442] layer[0x8c8e80]zpos[2]
04-07 15:18:48.751-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-07 15:18:48.751-0400 I/WATCH_CORE( 2893): appcore-watch.c: __signal_lcd_status_handler(1241) > Skip the lcd status signal in ambient mode
04-07 15:18:48.751-0400 W/W_INDICATOR( 2817): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-07 15:18:48.751-0400 W/W_HOME  ( 2844): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-07 15:18:48.751-0400 W/W_HOME  ( 2844): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-07 15:18:48.751-0400 W/W_HOME  ( 2844): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-07 15:18:48.751-0400 W/W_INDICATOR( 2817): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-07 15:18:48.751-0400 W/W_HOME  ( 2844): gesture.c: _apps_status_get(128) > apps status:0
04-07 15:18:48.751-0400 W/W_HOME  ( 2844): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:0 info->offtime:279980
04-07 15:18:48.751-0400 W/W_HOME  ( 2844): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-07 15:18:48.751-0400 W/W_HOME  ( 2844): event_manager.c: _lcd_on_cb(728) > lcd state: 1
04-07 15:18:48.751-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:48.751-0400 W/STARTER ( 2804): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [279980]ms
04-07 15:18:48.751-0400 W/STARTER ( 2804): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[1]
04-07 15:18:48.751-0400 E/WAKEUP-SERVICE( 3339): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-07 15:18:48.751-0400 W/SHealthCommon( 2948): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1491523200000.000000[0;m
04-07 15:18:48.761-0400 E/WAKEUP-SERVICE( 3339): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-07 15:18:48.761-0400 I/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-07 15:18:48.771-0400 I/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-07 15:18:48.771-0400 W/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-07 15:18:48.771-0400 W/WAKEUP-SERVICE( 3339): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-07 15:18:48.771-0400 I/HIGEAR  ( 3339): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-07 15:18:48.771-0400 W/WAKEUP-SERVICE( 3339): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151590132[0;m
04-07 15:18:48.771-0400 W/WAKEUP-SERVICE( 3339): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-07 15:18:48.771-0400 W/WAKEUP-SERVICE( 3339): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-07 15:18:48.771-0400 I/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-07 15:18:48.771-0400 W/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-07 15:18:48.781-0400 E/WAKEUP-SERVICE( 3339): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-07 15:18:48.781-0400 E/WAKEUP-SERVICE( 3339): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-07 15:18:48.781-0400 E/WAKEUP-SERVICE( 3339): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-07 15:18:48.791-0400 I/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-07 15:18:48.791-0400 I/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-07 15:18:48.791-0400 W/TIZEN_N_SOUND_MANAGER( 3339): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-07 15:18:48.791-0400 W/WAKEUP-SERVICE( 3339): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-07 15:18:48.791-0400 I/HIGEAR  ( 3339): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-07 15:18:48.811-0400 W/SHealthCommon( 2948): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (322783)]][0;m
04-07 15:18:48.831-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2804].
04-07 15:18:48.831-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(234229205)
04-07 15:18:48.851-0400 W/SHealthCommon( 2948): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-07 15:18:48.851-0400 W/SHealthWidget( 2966): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (322783), msgName: timeline_summary_updated[0;m
04-07 15:18:48.851-0400 W/SHealthCommon( 2966): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
04-07 15:18:48.851-0400 W/SHealthWidget( 2966): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
04-07 15:18:48.851-0400 I/HealthDataService( 3003): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-07 15:18:48.861-0400 W/WSLib   ( 2966): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1491578328869.000000, pattern:[HH:mm][0;m
04-07 15:18:48.861-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-07 15:18:48.861-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-07 15:18:48.861-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-07 15:18:48.861-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-07 15:18:48.861-0400 E/WSLib   ( 2966): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
04-07 15:18:48.861-0400 W/WSLib   ( 2966): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[15:18][0;m
04-07 15:18:48.861-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-07 15:18:48.861-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-07 15:18:48.861-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-07 15:18:48.861-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2966): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-07 15:18:48.861-0400 I/healthData( 2948): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-07 15:18:48.871-0400 W/SHealthService( 2948): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
04-07 15:18:48.871-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
04-07 15:18:48.871-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
04-07 15:18:48.871-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_get_boolean(1173) > preference_get_boolean(2948) : test_healthy_pace error
04-07 15:18:48.871-0400 I/CAPI_WIDGET_APPLICATION( 2966): widget_app.c: __provider_update_cb(281) > received updating signal
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_get_double(1214) > preference_get_double(2948) : pedometer_inactive_period error
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_get_double(1214) > preference_get_double(2948) : inactive_10min_precaution_millisec error
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-07 15:18:48.881-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2948): preference.c: preference_get_double(1214) > preference_get_double(2948) : inactive_before_10min_precaution_millisec error
04-07 15:18:48.931-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: __clock_viewer_lcdon_completed_cb(518) >  event lcdon completed[1]
04-07 15:18:48.931-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer-self.c: clock_viewer_self_hide(1066) >  ===== HIDE =====
04-07 15:18:48.931-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: clock_viewer_hide(1452) >  reservied[0], gesture[1], clock visible[1]
04-07 15:18:48.931-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: _clock_viewer_send_clock_stop(1059) >  clock stop <<
04-07 15:18:48.941-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_alpm_handler(1151) > signal_alpm_handler: ambient mode: 0, state: 3
04-07 15:18:48.941-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_ambient_tick(339) > _watch_core_ambient_tick, watch: com.samsung.chronograph16
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographApp.cpp: _appAmbientTick(186) > [0;34m>>>HIT<<<[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographViewController.cpp: _getCurrentDate(2107) > [0;32mBEGIN >>>>[0;m
04-07 15:18:48.941-0400 D/chronograph-common( 2893): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-07 15:18:48.941-0400 D/chronograph-common( 2893): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographViewController.cpp: _getCurrentDate(2129) > timestamp = 1491592728 :: dateStr = FRI :: dayStr = 7 :: dateText = FRI 7
04-07 15:18:48.941-0400 W/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_ambient_changed(354) > _watch_core_ambient_changed: 0
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographApp.cpp: _appAmbientChanged(195) > [0;34m>>>HIT<<<[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographViewController.cpp: onEventAmbientMode(338) > onEventAmbientMode >>>> [isAmbientMode=0]
04-07 15:18:48.941-0400 I/chronograph( 2893): ChronographViewController.cpp: onEventAmbientMode(358) > [0;32mAmbient Mode Unset >>>>[0;m
04-07 15:18:48.941-0400 W/chronograph( 2893): ChronographViewController.cpp: _hideAodView(907) > [0;35mhideAodView >>>>[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographViewController.cpp: _setWatchTouchEvent(1025) > [0;32mBEGIN >>>>[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographViewController.cpp: _setCurrentHandPosition(973) > [0;32mBEGIN >>>>[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographViewController.cpp: _getCurrentDate(2107) > [0;32mBEGIN >>>>[0;m
04-07 15:18:48.941-0400 D/chronograph-common( 2893): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-07 15:18:48.941-0400 D/chronograph-common( 2893): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographViewController.cpp: _getCurrentDate(2129) > timestamp = 1491592728 :: dateStr = FRI :: dayStr = 7 :: dateText = FRI 7
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographApp.cpp: _appResume(161) > [0;34m>>>HIT<<<[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographViewController.cpp: onResume(221) > State is Resume[isPaused=0], StopwatchState=0
04-07 15:18:48.941-0400 W/chronograph( 2893): ChronographSweepSecond.cpp: setSweepSecond(55) > [0;35msetSweepSecond >>>>[0;m
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographSweepSecond.cpp: setSweepSecond(67) > Current sec = 48, msec = 956
04-07 15:18:48.941-0400 D/chronograph( 2893): ChronographSweepSecond.cpp: setSweepSecond(71) > Create sweepSecondAnimation !!
04-07 15:18:48.941-0400 D/chronograph-common( 2893): ChronographSensor.cpp: enableAccelerometer(44) > [0;32mBEGIN >>>>[0;m
04-07 15:18:48.941-0400 D/chronograph-common( 2893): ChronographSensor.cpp: _startAccelerometer(75) > [0;32mBEGIN >>>>[0;m
04-07 15:18:48.951-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-07 15:18:48.951-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-07 15:18:48.951-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-4-2017, 23:25:10 (UTC).
04-07 15:18:48.951-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-07 15:18:48.951-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-07 15:18:48.951-0400 W/W_HOME  ( 2844): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-07 15:18:48.951-0400 W/W_HOME  ( 2844): gesture.c: _manual_render_enable(138) > 0
04-07 15:18:48.951-0400 W/W_HOME  ( 2844): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-07 15:18:48.951-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-07 15:18:48.951-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[234229205] is removed.
04-07 15:18:48.951-0400 E/ALARM_MANAGER( 2409): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-07 15:18:48.961-0400 W/STARTER ( 2804): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-07 15:18:48.961-0400 W/STARTER ( 2804): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[1]
04-07 15:18:48.981-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:48.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:49.141-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: __clock_viewer_lcdon_vi_timer_cb(199) >  lcdon vi wait timer
04-07 15:18:49.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:49.211-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: __clock_viewer_visibility_change_cb(703) >  Window visibility : [HIDE] lcd[2] begin_flag[0]
04-07 15:18:49.221-0400 I/APP_CORE(13473): appcore-efl.c: __do_app(453) > [APP 13473] Event: RESUME State: PAUSED
04-07 15:18:49.221-0400 I/CAPI_APPFW_APPLICATION(13473): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-07 15:18:49.231-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: __clock_viewer_clock_changed_timer_cb(191) >  clock changed timer
04-07 15:18:49.231-0400 W/W_CLOCK_VIEWER( 3464): clock-viewer.c: _clock_viewer_send_clock_changed(1069) >  clock changed <<
04-07 15:18:49.231-0400 W/STARTER ( 2804): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[13473] goes to (3)
04-07 15:18:49.231-0400 W/AUL_AMD ( 2434): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-07 15:18:49.231-0400 W/AUL_AMD ( 2434): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-07 15:18:49.231-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(edu.umich.edu.yctung.firsttizenhellp) pid(13473) status(fg) type(uiapp)
04-07 15:18:49.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:49.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:49.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:49.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:50.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:50.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:50.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:50.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:50.991-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:51.191-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:51.251-0400 E/EFL     (13473): ecore_x<13473> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=20298808 button=1
04-07 15:18:51.381-0400 E/EFL     (13473): ecore_x<13473> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=20298929 button=1
04-07 15:18:51.391-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:51.471-0400 D/firsttizenhello(13473): button is clicked
04-07 15:18:51.591-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:51.781-0400 W/AUL_PAD ( 3271): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 13473 pgid = 13473
04-07 15:18:51.781-0400 W/AUL_PAD ( 3271): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-07 15:18:51.791-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:51.801-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-07 15:18:51.801-0400 I/WATCH_CORE( 2893): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-07 15:18:51.801-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:51.801-0400 W/STARTER ( 2804): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2844] goes to (3)
04-07 15:18:51.801-0400 E/STARTER ( 2804): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2844)'s state(3)
04-07 15:18:51.801-0400 W/AUL_AMD ( 2434): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-07 15:18:51.801-0400 W/AUL_AMD ( 2434): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-07 15:18:51.801-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2844) status(fg) type(uiapp)
04-07 15:18:51.861-0400 W/PROCESSMGR( 2269): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-07 15:18:51.901-0400 W/AUL_PAD ( 3271): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-07 15:18:51.901-0400 W/WATCH_CORE( 2893): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-07 15:18:51.901-0400 I/WATCH_CORE( 2893): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-07 15:18:51.901-0400 I/CAPI_WATCH_APPLICATION( 2893): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-07 15:18:51.911-0400 I/AUL_AMD ( 2434): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 13473
04-07 15:18:51.911-0400 W/AUL     ( 2434): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(13473)
04-07 15:18:51.921-0400 W/W_HOME  ( 2844): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
04-07 15:18:51.921-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:51.921-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(336) > appcore resumed manually
04-07 15:18:51.921-0400 W/W_HOME  ( 2844): main.c: home_appcore_resume(506) > Home Appcore Resumed
04-07 15:18:51.921-0400 W/W_HOME  ( 2844): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
04-07 15:18:51.921-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:51.931-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:51.931-0400 W/W_HOME  ( 2844): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-07 15:18:51.931-0400 W/W_HOME  ( 2844): main.c: home_resume(531) > clock/widget resumed
04-07 15:18:51.931-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:51.931-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:51.951-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:51.951-0400 W/W_HOME  ( 2844): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-07 15:18:51.951-0400 W/W_HOME  ( 2844): event_manager.c: _window_visibility_cb(473) > Window [0x2200003] is now visible(0)
04-07 15:18:51.951-0400 W/W_HOME  ( 2844): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
04-07 15:18:51.951-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:51.951-0400 W/W_HOME  ( 2844): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-07 15:18:51.951-0400 W/W_HOME  ( 2844): main.c: _window_visibility_cb(964) > Window [0x2200003] is now visible(0)
04-07 15:18:51.951-0400 I/APP_CORE( 2844): appcore-efl.c: __do_app(453) > [APP 2844] Event: RESUME State: RUNNING
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(82), length(2)
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 82%
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 82, isCharging: 0
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_85
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(82), length(2)
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 82%
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 82, isCharging: 0
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_85
04-07 15:18:51.951-0400 W/W_INDICATOR( 2817): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
04-07 15:18:51.951-0400 I/wnotib  ( 2844): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
04-07 15:18:51.951-0400 E/wnotib  ( 2844): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-07 15:18:51.951-0400 W/wnotib  ( 2844): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-07 15:18:51.981-0400 W/CRASH_MANAGER(13586): worker.c: worker_job(1199) > 1113473666972149159273
