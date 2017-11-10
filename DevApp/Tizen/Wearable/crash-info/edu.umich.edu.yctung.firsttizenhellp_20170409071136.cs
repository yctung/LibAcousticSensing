S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: firsttizenhello
PID: 4920
Date: 2017-04-09 07:11:36-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4920, uid 5000)

Register Information
r0   = 0x00000023, r1   = 0x00000000
r2   = 0x197cf600, r3   = 0x197cf600
r4   = 0xf5e65924, r5   = 0xf7a3e1b0
r6   = 0xf7a0ba18, r7   = 0xffa8b2d8
r8   = 0x00000000, r9   = 0xf7a6d6d0
r10  = 0xf7a70720, fp   = 0x00000001
ip   = 0xf5ea5084, sp   = 0xffa8b298
lr   = 0xf5e6575d, pc   = 0xf5e65760
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     12132 KB
Buffers:     37308 KB
Cached:     209452 KB
VmPeak:     109208 KB
VmSize:     109204 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25360 KB
VmRSS:       25356 KB
VmData:      38280 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25320 KB
VmPTE:         128 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4920 TID = 4920
4920 5227 5228 5230 5239 

Maps Information
f0c1d000 f141c000 rw-p [stack:5239]
f141c000 f1427000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f142f000 f1431000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1439000 f143a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1442000 f144a000 r-xp /usr/lib/libfeedback.so.0.1.4
f1463000 f1464000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1522000 f1d21000 rw-p [stack:5230]
f2123000 f2922000 rw-p [stack:5228]
f2d24000 f3523000 rw-p [stack:5227]
f35e5000 f35fc000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3609000 f360e000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3616000 f3621000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3949000 f3a3b000 r-xp /usr/lib/libCOREGL.so.4.0
f3a54000 f3a59000 r-xp /usr/lib/libsystem.so.0.0.0
f3a63000 f3a64000 r-xp /usr/lib/libresponse.so.0.2.96
f3a6c000 f3a71000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3a7a000 f3a7c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3a84000 f3a8b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3a94000 f3ab6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3abf000 f3ac7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3acf000 f3ad5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f3ade000 f3ae3000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3aeb000 f3b0c000 r-xp /usr/lib/libexif.so.12.3.3
f3b1f000 f3b38000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3b40000 f3b45000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3b4d000 f3b53000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3b5b000 f3b5f000 r-xp /usr/lib/libogg.so.0.7.1
f3b67000 f3b89000 r-xp /usr/lib/libvorbis.so.0.4.3
f3b91000 f3b93000 r-xp /usr/lib/libttrace.so.1.1
f3b9b000 f3b9d000 r-xp /usr/lib/libdri2.so.0.0.0
f3ba5000 f3bad000 r-xp /usr/lib/libdrm.so.2.4.0
f3bb5000 f3bb6000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3bbf000 f3bc2000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3bca000 f3bd9000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3be2000 f3c29000 r-xp /usr/lib/libsndfile.so.1.0.26
f3c35000 f3c7e000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3c87000 f3c8c000 r-xp /usr/lib/libjson.so.0.0.1
f3c94000 f3c97000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3c9f000 f3ca5000 r-xp /usr/lib/libxcb-render.so.0.0.0
f3cad000 f3cae000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f3cb7000 f3cbb000 r-xp /usr/lib/libEGL.so.1.4
f3ccb000 f3cdc000 r-xp /usr/lib/libGLESv2.so.2.0
f3cec000 f3cf7000 r-xp /usr/lib/libtbm.so.1.0.0
f3cff000 f3d22000 r-xp /usr/lib/libui-extension.so.0.1.0
f3d2b000 f3d41000 r-xp /usr/lib/libtts.so
f3d4a000 f3d92000 r-xp /usr/lib/libmdm.so.1.2.62
f5624000 f572a000 r-xp /usr/lib/libicuuc.so.57.1
f5740000 f58c8000 r-xp /usr/lib/libicui18n.so.57.1
f58d8000 f58e5000 r-xp /usr/lib/libail.so.0.1.0
f58ee000 f58f1000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f58f9000 f5931000 r-xp /usr/lib/libpulse.so.0.16.2
f5932000 f5935000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f593d000 f599e000 r-xp /usr/lib/libasound.so.2.0.0
f59a8000 f59be000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f59c6000 f59cd000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f59d5000 f59d9000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f59e1000 f59ec000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f59f9000 f59fd000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5a06000 f5a0d000 r-xp /usr/lib/libminizip.so.1.0.0
f5a15000 f5acd000 r-xp /usr/lib/libcairo.so.2.11200.14
f5ad8000 f5aea000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5af2000 f5af7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5aff000 f5b16000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5b28000 f5b2d000 r-xp /usr/lib/libstorage.so.0.1
f5b35000 f5b56000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5b5e000 f5b65000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f5b70000 f5b7b000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5d15000 f5d1f000 r-xp /lib/libnss_files-2.13.so
f5d28000 f5df7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5e0d000 f5e31000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5e3a000 f5e40000 r-xp /usr/lib/libappsvc.so.0.1.0
f5e48000 f5e4a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5e53000 f5e57000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5e64000 f5e66000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
f5e76000 f5e78000 r-xp /usr/lib/libiniparser.so.0
f5e81000 f5e86000 r-xp /usr/lib/libappcore-common.so.1.1
f5e8f000 f5e97000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5e98000 f5e9c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5ea9000 f5eab000 r-xp /usr/lib/libXau.so.6.0.0
f5eb3000 f5eba000 r-xp /lib/libcrypt-2.13.so
f5eea000 f5eec000 r-xp /usr/lib/libiri.so
f5ef5000 f609e000 r-xp /usr/lib/libcrypto.so.1.0.0
f60be000 f6105000 r-xp /usr/lib/libssl.so.1.0.0
f6111000 f613f000 r-xp /usr/lib/libidn.so.11.5.44
f6147000 f6150000 r-xp /usr/lib/libcares.so.2.1.0
f615a000 f616d000 r-xp /usr/lib/libxcb.so.1.1.0
f6176000 f6178000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6180000 f6182000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f618b000 f6257000 r-xp /usr/lib/libxml2.so.2.7.8
f6264000 f6266000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f626f000 f6274000 r-xp /usr/lib/libffi.so.5.0.10
f627c000 f627d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6285000 f6288000 r-xp /lib/libattr.so.1.1.0
f6290000 f6324000 r-xp /usr/lib/libstdc++.so.6.0.16
f6337000 f6354000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f635e000 f6376000 r-xp /usr/lib/libpng12.so.0.50.0
f637e000 f6394000 r-xp /lib/libexpat.so.1.6.0
f639e000 f63e2000 r-xp /usr/lib/libcurl.so.4.3.0
f63eb000 f63f5000 r-xp /usr/lib/libXext.so.6.4.0
f63fe000 f6402000 r-xp /usr/lib/libXtst.so.6.1.0
f640a000 f6410000 r-xp /usr/lib/libXrender.so.1.3.0
f6418000 f641e000 r-xp /usr/lib/libXrandr.so.2.2.0
f6426000 f6427000 r-xp /usr/lib/libXinerama.so.1.0.0
f6430000 f6439000 r-xp /usr/lib/libXi.so.6.1.0
f6441000 f6444000 r-xp /usr/lib/libXfixes.so.3.1.0
f644c000 f644e000 r-xp /usr/lib/libXgesture.so.7.0.0
f6456000 f6458000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6460000 f6462000 r-xp /usr/lib/libXdamage.so.1.1.0
f646a000 f6471000 r-xp /usr/lib/libXcursor.so.1.0.2
f6479000 f647c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6484000 f6488000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6491000 f6496000 r-xp /usr/lib/libecore_fb.so.1.7.99
f649f000 f6580000 r-xp /usr/lib/libX11.so.6.3.0
f658b000 f65ae000 r-xp /usr/lib/libjpeg.so.8.0.2
f65c6000 f65dc000 r-xp /lib/libz.so.1.2.5
f65e4000 f65e6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f65ee000 f6663000 r-xp /usr/lib/libsqlite3.so.0.8.6
f666d000 f6687000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f668f000 f66c3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f66cc000 f679f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67aa000 f67ba000 r-xp /lib/libresolv-2.13.so
f67be000 f67d6000 r-xp /usr/lib/liblzma.so.5.0.3
f67de000 f67e1000 r-xp /lib/libcap.so.2.21
f67e9000 f6818000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6820000 f6821000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6829000 f682f000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6837000 f684e000 r-xp /usr/lib/liblua-5.1.so
f6857000 f685e000 r-xp /usr/lib/libembryo.so.1.7.99
f6866000 f686c000 r-xp /lib/librt-2.13.so
f6875000 f68cb000 r-xp /usr/lib/libpixman-1.so.0.28.2
f68d8000 f692e000 r-xp /usr/lib/libfreetype.so.6.11.3
f693a000 f6962000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6963000 f69a8000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f69b1000 f69c4000 r-xp /usr/lib/libfribidi.so.0.3.1
f69cc000 f69e6000 r-xp /usr/lib/libecore_con.so.1.7.99
f69ef000 f69f8000 r-xp /usr/lib/libedbus.so.1.7.99
f6a00000 f6a50000 r-xp /usr/lib/libecore_x.so.1.7.99
f6a52000 f6a5b000 r-xp /usr/lib/libvconf.so.0.2.45
f6a63000 f6a74000 r-xp /usr/lib/libecore_input.so.1.7.99
f6a7c000 f6a81000 r-xp /usr/lib/libecore_file.so.1.7.99
f6a89000 f6aab000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6ab4000 f6af5000 r-xp /usr/lib/libeina.so.1.7.99
f6afe000 f6b17000 r-xp /usr/lib/libeet.so.1.7.99
f6b28000 f6b91000 r-xp /lib/libm-2.13.so
f6b9a000 f6ba0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ba9000 f6baa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bb2000 f6bd5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bdd000 f6be2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bea000 f6c14000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c1d000 f6c34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c3c000 f6c47000 r-xp /lib/libunwind.so.8.0.1
f6c74000 f6c92000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c9c000 f6dc0000 r-xp /lib/libc-2.13.so
f6dce000 f6dd6000 r-xp /lib/libgcc_s-4.6.so.1
f6dd7000 f6ddb000 r-xp /usr/lib/libsmack.so.1.0.0
f6de4000 f6dea000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6df2000 f6ec2000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ec3000 f6f21000 r-xp /usr/lib/libedje.so.1.7.99
f6f2b000 f6f42000 r-xp /usr/lib/libecore.so.1.7.99
f6f59000 f7027000 r-xp /usr/lib/libevas.so.1.7.99
f704c000 f7188000 r-xp /usr/lib/libelementary.so.1.7.99
f719f000 f71b3000 r-xp /lib/libpthread-2.13.so
f71be000 f71c0000 r-xp /usr/lib/libdlog.so.0.0.0
f71c8000 f71cb000 r-xp /usr/lib/libbundle.so.0.1.22
f71d3000 f71d5000 r-xp /lib/libdl-2.13.so
f71de000 f71eb000 r-xp /usr/lib/libaul.so.0.1.0
f71fc000 f7202000 r-xp /usr/lib/libappcore-efl.so.1.1
f720b000 f720f000 r-xp /usr/lib/libsys-assert.so
f7218000 f7235000 r-xp /lib/ld-2.13.so
f723e000 f7243000 r-xp /usr/bin/launchpad-loader
f790b000 f7abd000 rw-p [heap]
ffa6c000 ffa8d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4920)
Call Stack Count: 17
 0: button_clicked_request_cb + 0x3b (0xf5e65760) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1760
 1: evas_object_smart_callback_call + 0x88 (0xf6f8e5cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf6f08f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf6f0cefd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf6f09869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf6f09c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf6f09d55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf6f363f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf6f33e53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf6f3746b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf6f37879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf71ffb47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf5e9a421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0xf5e6525f) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x125f
14: (0xf723fa53) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1a53
15: __libc_start_main + 0x114 (0xf6cb385c) [/lib/libc.so.6] + 0x1785c
16: (0xf723fe0c) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1e0c
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
 watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:16.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:16.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:16.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:16.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:17.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:17.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:17.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:17.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:17.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:18.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:18.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:18.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:18.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:18.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:19.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:19.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:19.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:19.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:19.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:20.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:20.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:20.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:20.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:20.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:21.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:21.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:21.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:21.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:21.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:22.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:22.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:22.452-0400 E/PKGMGR_SERVER( 5177): pkgmgr-server.c: main(2227) > package manager server start
04-09 07:11:22.542-0400 E/PKGMGR_SERVER( 5177): pkgmgr-server.c: req_cb(1134) > KILL_APP start 
04-09 07:11:22.552-0400 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 14
04-09 07:11:22.562-0400 W/AUL_AMD ( 2480): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-09 07:11:22.572-0400 E/PKGMGR_SERVER( 5177): pkgmgr-server.c: req_cb(1153) > CHECK_KILL_APP done[return = 0] 
04-09 07:11:22.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:22.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:22.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:23.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:23.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:23.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:23.782-0400 W/AUL     ( 5226): launch.c: app_request_to_launchpad(284) > request cmd(0) to(edu.umich.edu.yctung.firsttizenhellp)
04-09 07:11:23.792-0400 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 0
04-09 07:11:23.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:23.802-0400 I/AUL_AMD ( 2480): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
04-09 07:11:23.822-0400 I/AUL_AMD ( 2480): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
04-09 07:11:23.822-0400 E/AUL_AMD ( 2480): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
04-09 07:11:23.822-0400 W/AUL_AMD ( 2480): amd_launch.c: _start_app(1782) > caller pid : 5226
04-09 07:11:23.842-0400 W/AUL_AMD ( 2480): amd_launch.c: _start_app(2218) > pad pid(-5)
04-09 07:11:23.842-0400 E/RESOURCED( 2594): block.c: block_prelaunch_state(138) > insert data edu.umich.edu.yctung.firsttizenhellp, table num : 1
04-09 07:11:23.842-0400 W/AUL_PAD ( 3329): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
04-09 07:11:23.842-0400 W/AUL_PAD ( 3329): launchpad.c: __send_result_to_caller(272) > Check app launching
04-09 07:11:23.842-0400 W/AUL_PAD ( 4920): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
04-09 07:11:23.842-0400 W/AUL_PAD ( 4920): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
04-09 07:11:23.842-0400 W/AUL_PAD ( 4920): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
04-09 07:11:23.842-0400 W/AUL_PAD ( 4920): launchpad_loader.c: main(680) > [candidate] dlopen(edu.umich.edu.yctung.firsttizenhellp)
04-09 07:11:23.942-0400 I/efl-extension( 4920): efl_extension.c: eext_mod_init(40) > Init
04-09 07:11:23.952-0400 I/UXT     ( 4920): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-09 07:11:23.952-0400 W/AUL_PAD ( 4920): launchpad_loader.c: main(690) > [candidate] dlsym
04-09 07:11:23.952-0400 W/AUL_PAD ( 4920): launchpad_loader.c: main(694) > [candidate] dl_main(edu.umich.edu.yctung.firsttizenhellp)
04-09 07:11:23.952-0400 I/CAPI_APPFW_APPLICATION( 4920): app_main.c: ui_app_main(704) > app_efl_main
04-09 07:11:23.952-0400 I/CAPI_APPFW_APPLICATION( 4920): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-09 07:11:23.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:24.042-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(edu.umich.edu.yctung.firsttizenhellp) pid(4920) type(uiapp) bg(0)
04-09 07:11:24.042-0400 W/AUL_AMD ( 2480): amd_status.c: __socket_monitor_cb(1277) > (4920) was created
04-09 07:11:24.042-0400 W/AUL     ( 5226): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4920)
04-09 07:11:24.052-0400 W/STARTER ( 2650): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [4920]
04-09 07:11:24.122-0400 E/EFL     ( 4920): ecore_evas<4920> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
04-09 07:11:24.172-0400 D/firsttizenhello( 4920): label is added
04-09 07:11:24.182-0400 D/firsttizenhello( 4920): button is added
04-09 07:11:24.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:24.332-0400 E/PKGMGR_SERVER( 5177): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
04-09 07:11:24.332-0400 E/PKGMGR_SERVER( 5177): pkgmgr-server.c: main(2281) > package manager server terminated.
04-09 07:11:24.342-0400 I/TIZEN_N_AUDIO_IO( 4920): audio_io_private.c: audio_in_create_private(289) > mm_sound_pcm_capture_open_ex() success
04-09 07:11:24.342-0400 I/TIZEN_N_AUDIO_IO( 4920): audio_io_private.c: audio_in_create_private(306) > mm_sound_pcm_set_message_callback() success
04-09 07:11:24.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:24.422-0400 I/TIZEN_N_AUDIO_IO( 4920): audio_io_private.c: audio_out_create_private(402) > mm_sound_pcm_play_open() success
04-09 07:11:24.422-0400 I/TIZEN_N_AUDIO_IO( 4920): audio_io_private.c: audio_out_create_private(415) > mm_sound_pcm_set_message_callback() success
04-09 07:11:24.422-0400 I/TIZEN_N_AUDIO_IO( 4920): audio_io.c: audio_in_get_buffer_size(170) > [audio_in_get_buffer_size] buffer size = 4410
04-09 07:11:24.422-0400 D/firsttizenhello( 4920): buffer_size = 4410
04-09 07:11:24.432-0400 D/firsttizenhello( 4920): /opt/usr/media/Sounds
04-09 07:11:24.432-0400 D/firsttizenhello( 4920): /opt/usr/media/Sounds/yctung_pcm_w.raw
04-09 07:11:24.432-0400 I/APP_CORE( 4920): appcore-efl.c: __do_app(453) > [APP 4920] Event: RESET State: CREATED
04-09 07:11:24.432-0400 I/CAPI_APPFW_APPLICATION( 4920): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-09 07:11:24.452-0400 I/APP_CORE( 4920): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-09 07:11:24.452-0400 I/APP_CORE( 4920): appcore-efl.c: __do_app(524) > [APP 4920] Initial Launching, call the resume_cb
04-09 07:11:24.452-0400 I/CAPI_APPFW_APPLICATION( 4920): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-09 07:11:24.462-0400 W/W_HOME  ( 2717): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
04-09 07:11:24.462-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:24.462-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:24.462-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:24.462-0400 W/W_HOME  ( 2717): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
04-09 07:11:24.472-0400 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-09 07:11:24.472-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-09 07:11:24.492-0400 W/APP_CORE( 4920): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3000002
04-09 07:11:24.552-0400 W/W_HOME  ( 2717): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(1)
04-09 07:11:24.552-0400 W/W_HOME  ( 2717): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
04-09 07:11:24.552-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:24.552-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:24.552-0400 I/APP_CORE( 4920): appcore-efl.c: __do_app(453) > [APP 4920] Event: RESUME State: RUNNING
04-09 07:11:24.552-0400 W/W_HOME  ( 2717): main.c: _window_visibility_cb(964) > Window [0x2000003] is now visible(1)
04-09 07:11:24.552-0400 I/APP_CORE( 2717): appcore-efl.c: __do_app(453) > [APP 2717] Event: PAUSE State: RUNNING
04-09 07:11:24.552-0400 I/CAPI_APPFW_APPLICATION( 2717): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-09 07:11:24.552-0400 W/W_HOME  ( 2717): main.c: _appcore_pause_cb(488) > appcore pause
04-09 07:11:24.552-0400 E/W_HOME  ( 2717): main.c: _pause_cb(466) > paused already
04-09 07:11:24.552-0400 I/APP_CORE( 2717): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
04-09 07:11:24.552-0400 I/wnotib  ( 2717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
04-09 07:11:24.552-0400 E/wnotib  ( 2717): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-09 07:11:24.552-0400 W/wnotib  ( 2717): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-09 07:11:24.562-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2717) status(bg) type(uiapp)
04-09 07:11:24.562-0400 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2717] goes to (4)
04-09 07:11:24.562-0400 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2717)'s state(4)
04-09 07:11:24.572-0400 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[4920] goes to (3)
04-09 07:11:24.572-0400 W/AUL_AMD ( 2480): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-09 07:11:24.572-0400 W/AUL_AMD ( 2480): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-09 07:11:24.572-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(edu.umich.edu.yctung.firsttizenhellp) pid(4920) status(fg) type(uiapp)
04-09 07:11:24.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:24.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:24.932-0400 E/AUL     ( 2480): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-09 07:11:24.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:25.142-0400 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 14
04-09 07:11:25.152-0400 W/AUL_AMD ( 2480): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4920
04-09 07:11:25.152-0400 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 14
04-09 07:11:25.162-0400 W/AUL_AMD ( 2480): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4920
04-09 07:11:25.162-0400 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 12
04-09 07:11:25.172-0400 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 12
04-09 07:11:25.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:25.372-0400 I/AUL_PAD ( 5233): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-09 07:11:25.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:25.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:25.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:25.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:26.192-0400 D/chronograph( 2874): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(124) > [0;32mBEGIN >>>>[0;m
04-09 07:11:26.192-0400 D/chronograph( 2874): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(137) > mSweep60SStartValue[26.146999] mCurrentValue[26.198999]
04-09 07:11:26.192-0400 D/chronograph( 2874): ChronographSweepSecond.cpp: _onSweep60sAnimationFinished(178) > speed up/down by 0.312000 degree in 60 seconds
04-09 07:11:26.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:26.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:26.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:26.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:26.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:27.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:27.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:27.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:27.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:27.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:28.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:28.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:28.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:28.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:28.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:29.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:29.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:29.552-0400 I/APP_CORE( 2717): appcore-efl.c: __do_app(453) > [APP 2717] Event: MEM_FLUSH State: PAUSED
04-09 07:11:29.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:29.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:29.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:30.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:30.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:30.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:30.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:30.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:31.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:31.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:31.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:31.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:31.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:32.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:32.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:32.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:32.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:32.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:33.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:33.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:33.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:33.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:33.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:34.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:34.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:34.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:34.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:34.882-0400 W/SHealthCommon( 2942): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-09 07:11:34.882-0400 W/SHealthCommon( 3208): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-09 07:11:34.882-0400 W/SHealthService( 3208): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-09 07:11:34.892-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [1487.561494] dpms[3 -> 0]sync[0]
04-09 07:11:34.892-0400 I/TDM     ( 1956): 
04-09 07:11:34.892-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [1487.561718] dpms[0 -> 0]done
04-09 07:11:34.892-0400 I/TDM     ( 1956): 
04-09 07:11:34.902-0400 W/SHealthCommon( 3208): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1491696000000.000000[0;m
04-09 07:11:34.932-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151753972[0;m
04-09 07:11:34.932-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-09 07:11:34.932-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-09 07:11:34.932-0400 I/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-09 07:11:34.942-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-09 07:11:34.942-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-09 07:11:34.942-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:34.942-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-09 07:11:34.942-0400 W/W_HOME  ( 2717): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-09 07:11:34.942-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-09 07:11:34.942-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-09 07:11:34.942-0400 W/W_HOME  ( 2717): gesture.c: _apps_status_get(128) > apps status:0
04-09 07:11:34.942-0400 W/W_HOME  ( 2717): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:0 info->offtime:61016
04-09 07:11:34.942-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-09 07:11:34.942-0400 W/W_HOME  ( 2717): event_manager.c: _lcd_on_cb(728) > lcd state: 1
04-09 07:11:34.942-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:34.942-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdon_cb(463) >  event lcdon[1][0]
04-09 07:11:34.952-0400 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [61016]ms
04-09 07:11:34.952-0400 W/STARTER ( 2650): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[1]
04-09 07:11:34.952-0400 I/APP_CORE( 4920): appcore-efl.c: __do_app(453) > [APP 4920] Event: RESUME State: RUNNING
04-09 07:11:34.952-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer-self.c: clock_viewer_self_show_fake_hands(1083) >  Show fake hands default[0]
04-09 07:11:34.952-0400 E/W_CLOCK_VIEWER( 2734): clock-viewer-self.c: __rotate(1038) >  hand geo[161,1][40x360]
04-09 07:11:34.952-0400 E/W_CLOCK_VIEWER( 2734): clock-viewer-self.c: __rotate(1038) >  hand geo[161,1][40x360]
04-09 07:11:34.952-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdon_cb(493) >  lcdon by [powerkey] time[61016]
04-09 07:11:34.962-0400 W/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-09 07:11:34.972-0400 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-09 07:11:34.972-0400 W/W_INDICATOR( 2651): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
04-09 07:11:34.972-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [1487.645367] layer(0x447210) not usable
04-09 07:11:34.972-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [1487.645415] layer(0x447210) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-09 07:11:34.972-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [1487.645443] layer[0x446d60]zpos[1]
04-09 07:11:34.972-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [1487.645526] layer(0x447260) not usable
04-09 07:11:34.972-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [1487.645543] layer(0x447260) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-09 07:11:34.972-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [1487.645565] layer[0x446e80]zpos[2]
04-09 07:11:34.972-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-09 07:11:34.982-0400 W/W_HOME  ( 2717): gesture.c: _widget_updated_cb(188) > widget updated
04-09 07:11:34.982-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-09 07:11:34.982-0400 W/W_HOME  ( 2717): gesture.c: _manual_render(182) > 
04-09 07:11:34.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:34.992-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-09 07:11:35.002-0400 E/WAKEUP-SERVICE( 3270): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-09 07:11:35.002-0400 I/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-09 07:11:35.012-0400 I/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-09 07:11:35.012-0400 W/TIZEN_N_SOUND_MANAGER( 3270): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-09 07:11:35.012-0400 W/WAKEUP-SERVICE( 3270): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-09 07:11:35.012-0400 I/HIGEAR  ( 3270): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-09 07:11:35.032-0400 W/SHealthCommon( 3208): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (289116)]][0;m
04-09 07:11:35.042-0400 W/W_HOME  ( 2717): gesture.c: _manual_render(182) > 
04-09 07:11:35.072-0400 W/SHealthWidget( 2942): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (289116), msgName: timeline_summary_updated[0;m
04-09 07:11:35.072-0400 W/SHealthCommon( 2942): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
04-09 07:11:35.072-0400 W/SHealthWidget( 2942): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
04-09 07:11:35.072-0400 W/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1491721895084.000000, pattern:[HH:mm][0;m
04-09 07:11:35.072-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-09 07:11:35.072-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-09 07:11:35.072-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-09 07:11:35.072-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-09 07:11:35.072-0400 E/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
04-09 07:11:35.072-0400 W/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[07:11][0;m
04-09 07:11:35.072-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-09 07:11:35.072-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-09 07:11:35.072-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-09 07:11:35.072-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-09 07:11:35.072-0400 I/CAPI_WIDGET_APPLICATION( 2942): widget_app.c: __provider_update_cb(281) > received updating signal
04-09 07:11:35.082-0400 W/SHealthCommon( 3208): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-09 07:11:35.102-0400 W/W_HOME  ( 2717): gesture.c: _manual_render_enable(138) > 0
04-09 07:11:35.162-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdon_completed_cb(518) >  event lcdon completed[1]
04-09 07:11:35.162-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer-self.c: clock_viewer_self_hide(1066) >  ===== HIDE =====
04-09 07:11:35.162-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: clock_viewer_hide(1452) >  reservied[0], gesture[1], clock visible[0]
04-09 07:11:35.162-0400 W/STARTER ( 2650): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
04-09 07:11:35.162-0400 W/STARTER ( 2650): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[1]
04-09 07:11:35.182-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3208): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
04-09 07:11:35.182-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3208): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
04-09 07:11:35.182-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3208): preference.c: preference_get_boolean(1173) > preference_get_boolean(3208) : test_healthy_pace error
04-09 07:11:35.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:35.222-0400 I/HealthDataService( 2983): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-09 07:11:35.232-0400 I/healthData( 3208): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-09 07:11:35.232-0400 W/SHealthCommon( 3208): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1491696000000.000000[0;m
04-09 07:11:35.252-0400 W/SHealthCommon( 3208): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (289116)]][0;m
04-09 07:11:35.272-0400 W/SHealthCommon( 3208): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-09 07:11:35.272-0400 W/SHealthWidget( 2942): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (289116), msgName: timeline_summary_updated[0;m
04-09 07:11:35.272-0400 W/SHealthCommon( 2942): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
04-09 07:11:35.272-0400 W/SHealthWidget( 2942): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
04-09 07:11:35.282-0400 W/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1491721895287.000000, pattern:[HH:mm][0;m
04-09 07:11:35.282-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-09 07:11:35.282-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-09 07:11:35.282-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-09 07:11:35.282-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-09 07:11:35.282-0400 I/HealthDataService( 2983): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-09 07:11:35.282-0400 E/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
04-09 07:11:35.282-0400 W/WSLib   ( 2942): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[07:11][0;m
04-09 07:11:35.282-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-09 07:11:35.282-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-09 07:11:35.282-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-09 07:11:35.282-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2942): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-09 07:11:35.282-0400 I/CAPI_WIDGET_APPLICATION( 2942): widget_app.c: __provider_update_cb(281) > received updating signal
04-09 07:11:35.292-0400 I/healthData( 3208): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-09 07:11:35.362-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_lcdon_vi_timer_cb(199) >  lcdon vi wait timer
04-09 07:11:35.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:35.462-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: __clock_viewer_clock_changed_timer_cb(191) >  clock changed timer
04-09 07:11:35.462-0400 W/W_CLOCK_VIEWER( 2734): clock-viewer.c: _clock_viewer_send_clock_changed(1069) >  clock changed <<
04-09 07:11:35.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:35.792-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:35.992-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:36.072-0400 E/EFL     ( 4920): ecore_x<4920> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1488741 button=1
04-09 07:11:36.192-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:36.192-0400 E/EFL     ( 4920): ecore_x<4920> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1488864 button=1
04-09 07:11:36.282-0400 D/firsttizenhello( 4920): button is clicked
04-09 07:11:36.392-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:36.562-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4920 pgid = 4920
04-09 07:11:36.562-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-09 07:11:36.562-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-09 07:11:36.562-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-09 07:11:36.572-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:36.582-0400 W/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2717] goes to (3)
04-09 07:11:36.582-0400 E/STARTER ( 2650): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2717)'s state(3)
04-09 07:11:36.592-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:36.592-0400 W/AUL_AMD ( 2480): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-09 07:11:36.592-0400 W/AUL_AMD ( 2480): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-09 07:11:36.592-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2717) status(fg) type(uiapp)
04-09 07:11:36.602-0400 W/PROCESSMGR( 2304): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-09 07:11:36.602-0400 W/W_HOME  ( 2717): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
04-09 07:11:36.602-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:36.602-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:36.612-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:36.612-0400 W/W_HOME  ( 2717): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(0)
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): main.c: _window_visibility_cb(964) > Window [0x2000003] is now visible(0)
04-09 07:11:36.642-0400 I/APP_CORE( 2717): appcore-efl.c: __do_app(453) > [APP 2717] Event: RESUME State: PAUSED
04-09 07:11:36.642-0400 I/CAPI_APPFW_APPLICATION( 2717): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): main.c: _appcore_resume_cb(479) > appcore resume
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): main.c: home_resume(531) > clock/widget resumed
04-09 07:11:36.642-0400 W/W_HOME  ( 2717): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-09 07:11:36.642-0400 I/wnotib  ( 2717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
04-09 07:11:36.642-0400 E/wnotib  ( 2717): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-09 07:11:36.642-0400 W/wnotib  ( 2717): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-09 07:11:36.672-0400 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(26), length(2)
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 26%
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 26, isCharging: 0
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(26), length(2)
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 26%
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 26, isCharging: 0
04-09 07:11:36.692-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
04-09 07:11:36.702-0400 W/W_INDICATOR( 2651): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
04-09 07:11:36.722-0400 W/AUL_PAD ( 3329): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-09 07:11:36.722-0400 I/AUL_AMD ( 2480): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4920
04-09 07:11:36.722-0400 W/AUL     ( 2480): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4920)
04-09 07:11:36.742-0400 W/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-09 07:11:36.742-0400 I/WATCH_CORE( 2874): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-09 07:11:36.742-0400 I/CAPI_WATCH_APPLICATION( 2874): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-09 07:11:36.782-0400 W/CRASH_MANAGER( 5241): worker.c: worker_job(1199) > 1104920666972149173629
