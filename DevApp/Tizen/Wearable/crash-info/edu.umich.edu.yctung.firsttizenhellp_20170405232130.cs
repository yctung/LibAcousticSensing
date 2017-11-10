S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.0
Build-Number: R770XXU1APK2
Build-Date: 2016.11.02 17:15:20

Crash Information
Process Name: firsttizenhello
PID: 14151
Date: 2017-04-05 23:21:30-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 14151, uid 5000)

Register Information
r0   = 0x00000023, r1   = 0x00000000
r2   = 0x473c3600, r3   = 0x473c3600
r4   = 0xf77d4ea0, r5   = 0xf779a968
r6   = 0xf7769810, r7   = 0xffc04810
r8   = 0x00000000, r9   = 0xf77c9d40
r10  = 0xf77ccd28, fp   = 0x00000001
ip   = 0xf5ec1084, sp   = 0xffc047e0
lr   = 0xf5e81429, pc   = 0xf5e8142c
cpsr = 0x60000030

Memory Information
MemTotal:   714608 KB
MemFree:     27376 KB
Buffers:     32460 KB
Cached:     171628 KB
VmPeak:     127244 KB
VmSize:     127240 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27200 KB
VmRSS:       27196 KB
VmData:      63012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26556 KB
VmPTE:         136 KB
VmSwap:          0 KB

Threads Information
Threads: 8
PID = 14151 TID = 14151
14151 14227 14228 14229 14230 14232 14233 14239 

Maps Information
ef9ee000 f01ed000 rw-p [stack:14239]
f01ed000 f01f8000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f0201000 f0a00000 rw-p [stack:14233]
f0a01000 f1200000 rw-p [stack:14232]
f1201000 f1a00000 rw-p [stack:14230]
f1b08000 f1b0a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1b12000 f1b13000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1b1b000 f1b23000 r-xp /usr/lib/libfeedback.so.0.1.4
f1b3c000 f1b3d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1b45000 f1b46000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f1b4e000 f1b51000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f1bd9000 f23d8000 rw-p [stack:14229]
f23d9000 f2bd8000 rw-p [stack:14228]
f2bd9000 f33d8000 rw-p [stack:14227]
f349a000 f34b1000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f34be000 f34c3000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f34cb000 f34d6000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f37fe000 f38f0000 r-xp /usr/lib/libCOREGL.so.4.0
f3909000 f390e000 r-xp /usr/lib/libsystem.so.0.0.0
f3918000 f3919000 r-xp /usr/lib/libresponse.so.0.2.96
f3921000 f3926000 r-xp /usr/lib/libproc-stat.so.0.2.96
f392f000 f3936000 r-xp /usr/lib/libminizip.so.1.0.0
f393e000 f3940000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f3948000 f394f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f3958000 f397a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f3983000 f398b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f3993000 f3999000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f39a2000 f39c3000 r-xp /usr/lib/libexif.so.12.3.3
f39d6000 f39da000 r-xp /usr/lib/libogg.so.0.7.1
f39e2000 f3a04000 r-xp /usr/lib/libvorbis.so.0.4.3
f3a0c000 f3a25000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f3a2d000 f3a33000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3a3b000 f3a41000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f3a49000 f3a58000 r-xp /usr/lib/libmdm-common.so.1.1.22
f3a61000 f3aa8000 r-xp /usr/lib/libsndfile.so.1.0.26
f3ab4000 f3afd000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3b06000 f3b0b000 r-xp /usr/lib/libjson.so.0.0.1
f3b13000 f3b16000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3b1e000 f3b1f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f3b28000 f3b2b000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f3b33000 f3b38000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f3b40000 f3b59000 r-xp /usr/lib/libnetwork.so.0.0.0
f3b61000 f3ba9000 r-xp /usr/lib/libmdm.so.1.2.62
f543b000 f5541000 r-xp /usr/lib/libicuuc.so.57.1
f5557000 f5564000 r-xp /usr/lib/libail.so.0.1.0
f556d000 f5570000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f5578000 f55b0000 r-xp /usr/lib/libpulse.so.0.16.2
f55b1000 f55b4000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f55bc000 f561d000 r-xp /usr/lib/libasound.so.2.0.0
f5627000 f563d000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f5645000 f5649000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f5651000 f5653000 r-xp /usr/lib/libttrace.so.1.1
f565b000 f5661000 r-xp /usr/lib/libxcb-render.so.0.0.0
f5669000 f566a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f5673000 f5677000 r-xp /usr/lib/libEGL.so.1.4
f5687000 f5698000 r-xp /usr/lib/libGLESv2.so.2.0
f56a8000 f56cb000 r-xp /usr/lib/libui-extension.so.0.1.0
f56d4000 f56ea000 r-xp /usr/lib/libtts.so
f56f3000 f5703000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f570b000 f5893000 r-xp /usr/lib/libicui18n.so.57.1
f58a3000 f58aa000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f58b2000 f58bd000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f58ca000 f58ce000 r-xp /usr/lib/libmmfsession.so.0.0.0
f58d7000 f58ee000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5900000 f590d000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f5916000 f591b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f5923000 f5925000 r-xp /usr/lib/libdri2.so.0.0.0
f592d000 f5935000 r-xp /usr/lib/libdrm.so.2.4.0
f593d000 f59f5000 r-xp /usr/lib/libcairo.so.2.11200.14
f5a00000 f5a12000 r-xp /usr/lib/libefl-assist.so.0.1.0
f5a1a000 f5ab5000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f5ac1000 f5ac3000 r-xp /usr/lib/libmm_ta.so.0.0.0
f5acc000 f5b1a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
f5b22000 f5b2d000 r-xp /usr/lib/libtbm.so.1.0.0
f5b35000 f5b3a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f5b42000 f5b63000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5b6b000 f5b81000 r-xp /usr/lib/libcapi-media-player.so.0.1.51
f5b8c000 f5b97000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5d31000 f5d3b000 r-xp /lib/libnss_files-2.13.so
f5d44000 f5e13000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5e29000 f5e4d000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5e56000 f5e5c000 r-xp /usr/lib/libappsvc.so.0.1.0
f5e64000 f5e66000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5e6f000 f5e73000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5e80000 f5e82000 r-xp /opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello
f5e92000 f5e94000 r-xp /usr/lib/libiniparser.so.0
f5e9d000 f5ea2000 r-xp /usr/lib/libappcore-common.so.1.1
f5eab000 f5eb3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5eb4000 f5eb8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5ec5000 f5ec7000 r-xp /usr/lib/libXau.so.6.0.0
f5ecf000 f5ed6000 r-xp /lib/libcrypt-2.13.so
f5f06000 f5f08000 r-xp /usr/lib/libiri.so
f5f11000 f60ba000 r-xp /usr/lib/libcrypto.so.1.0.0
f60da000 f6121000 r-xp /usr/lib/libssl.so.1.0.0
f612d000 f615b000 r-xp /usr/lib/libidn.so.11.5.44
f6163000 f616c000 r-xp /usr/lib/libcares.so.2.1.0
f6176000 f6189000 r-xp /usr/lib/libxcb.so.1.1.0
f6192000 f6194000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f619c000 f619e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f61a7000 f6273000 r-xp /usr/lib/libxml2.so.2.7.8
f6280000 f6282000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f628b000 f6290000 r-xp /usr/lib/libffi.so.5.0.10
f6298000 f6299000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f62a1000 f62a4000 r-xp /lib/libattr.so.1.1.0
f62ac000 f6340000 r-xp /usr/lib/libstdc++.so.6.0.16
f6353000 f6370000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f637a000 f6392000 r-xp /usr/lib/libpng12.so.0.50.0
f639a000 f63b0000 r-xp /lib/libexpat.so.1.6.0
f63ba000 f63fe000 r-xp /usr/lib/libcurl.so.4.3.0
f6407000 f6411000 r-xp /usr/lib/libXext.so.6.4.0
f641a000 f641e000 r-xp /usr/lib/libXtst.so.6.1.0
f6426000 f642c000 r-xp /usr/lib/libXrender.so.1.3.0
f6434000 f643a000 r-xp /usr/lib/libXrandr.so.2.2.0
f6442000 f6443000 r-xp /usr/lib/libXinerama.so.1.0.0
f644c000 f6455000 r-xp /usr/lib/libXi.so.6.1.0
f645d000 f6460000 r-xp /usr/lib/libXfixes.so.3.1.0
f6468000 f646a000 r-xp /usr/lib/libXgesture.so.7.0.0
f6472000 f6474000 r-xp /usr/lib/libXcomposite.so.1.0.0
f647c000 f647e000 r-xp /usr/lib/libXdamage.so.1.1.0
f6486000 f648d000 r-xp /usr/lib/libXcursor.so.1.0.2
f6495000 f6498000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f64a0000 f64a4000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f64ad000 f64b2000 r-xp /usr/lib/libecore_fb.so.1.7.99
f64bb000 f659c000 r-xp /usr/lib/libX11.so.6.3.0
f65a7000 f65ca000 r-xp /usr/lib/libjpeg.so.8.0.2
f65e2000 f65f8000 r-xp /lib/libz.so.1.2.5
f6600000 f6602000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f660a000 f667f000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6689000 f66a3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66ab000 f66df000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f66e8000 f67bb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67c6000 f67d6000 r-xp /lib/libresolv-2.13.so
f67da000 f67f2000 r-xp /usr/lib/liblzma.so.5.0.3
f67fa000 f67fd000 r-xp /lib/libcap.so.2.21
f6805000 f6834000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f683c000 f683d000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6845000 f684b000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6853000 f686a000 r-xp /usr/lib/liblua-5.1.so
f6873000 f687a000 r-xp /usr/lib/libembryo.so.1.7.99
f6882000 f6888000 r-xp /lib/librt-2.13.so
f6891000 f68e7000 r-xp /usr/lib/libpixman-1.so.0.28.2
f68f4000 f694a000 r-xp /usr/lib/libfreetype.so.6.11.3
f6956000 f697e000 r-xp /usr/lib/libfontconfig.so.1.8.0
f697f000 f69c4000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f69cd000 f69e0000 r-xp /usr/lib/libfribidi.so.0.3.1
f69e8000 f6a02000 r-xp /usr/lib/libecore_con.so.1.7.99
f6a0b000 f6a14000 r-xp /usr/lib/libedbus.so.1.7.99
f6a1c000 f6a6c000 r-xp /usr/lib/libecore_x.so.1.7.99
f6a6e000 f6a77000 r-xp /usr/lib/libvconf.so.0.2.45
f6a7f000 f6a90000 r-xp /usr/lib/libecore_input.so.1.7.99
f6a98000 f6a9d000 r-xp /usr/lib/libecore_file.so.1.7.99
f6aa5000 f6ac7000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6ad0000 f6b11000 r-xp /usr/lib/libeina.so.1.7.99
f6b1a000 f6b33000 r-xp /usr/lib/libeet.so.1.7.99
f6b44000 f6bad000 r-xp /lib/libm-2.13.so
f6bb6000 f6bbc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bc5000 f6bc6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bce000 f6bf1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bf9000 f6bfe000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c06000 f6c30000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c39000 f6c50000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c58000 f6c63000 r-xp /lib/libunwind.so.8.0.1
f6c90000 f6cae000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cb8000 f6ddc000 r-xp /lib/libc-2.13.so
f6dea000 f6df2000 r-xp /lib/libgcc_s-4.6.so.1
f6df3000 f6df7000 r-xp /usr/lib/libsmack.so.1.0.0
f6e00000 f6e06000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6e0e000 f6ede000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6edf000 f6f3d000 r-xp /usr/lib/libedje.so.1.7.99
f6f47000 f6f5e000 r-xp /usr/lib/libecore.so.1.7.99
f6f75000 f7043000 r-xp /usr/lib/libevas.so.1.7.99
f7068000 f71a4000 r-xp /usr/lib/libelementary.so.1.7.99
f71bb000 f71cf000 r-xp /lib/libpthread-2.13.so
f71da000 f71dc000 r-xp /usr/lib/libdlog.so.0.0.0
f71e4000 f71e7000 r-xp /usr/lib/libbundle.so.0.1.22
f71ef000 f71f1000 r-xp /lib/libdl-2.13.so
f71fa000 f7207000 r-xp /usr/lib/libaul.so.0.1.0
f7218000 f721e000 r-xp /usr/lib/libappcore-efl.so.1.1
f7227000 f722b000 r-xp /usr/lib/libsys-assert.so
f7234000 f7251000 r-xp /lib/ld-2.13.so
f725a000 f725f000 r-xp /usr/bin/launchpad-loader
f7666000 f785c000 rw-p [heap]
ffbe5000 ffc06000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14151)
Call Stack Count: 17
 0: button_clicked_request_cb + 0x37 (0xf5e8142c) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x142c
 1: evas_object_smart_callback_call + 0x88 (0xf6faa5cd) [/usr/lib/libevas.so.1] + 0x355cd
 2: (0xf6f24f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 3: (0xf6f28efd) [/usr/lib/libedje.so.1] + 0x49efd
 4: (0xf6f25869) [/usr/lib/libedje.so.1] + 0x46869
 5: (0xf6f25c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 6: (0xf6f25d55) [/usr/lib/libedje.so.1] + 0x46d55
 7: (0xf6f523f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0xf6f4fe53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0xf6f5346b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0xf6f53879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0xf721bb47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0xf5eb6421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x12a (0xf5e8100b) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x100b
14: (0xf725ba53) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1a53
15: __libc_start_main + 0x114 (0xf6ccf85c) [/lib/libc.so.6] + 0x1785c
16: (0xf725be0c) [/opt/usr/apps/edu.umich.edu.yctung.firsttizenhellp/bin/firsttizenhello] + 0x1e0c
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
FAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath.c: fastpath_init_context_states(1463) >  [40;31;1mNumber of uniform buffer binding is too big! (64-72)[0m
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
04-05 23:21:25.351-0400 W/CoreGL  (14150): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
04-05 23:21:25.391-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:25.431-0400 E/rpm-installer(14141): rpm-appcore-intf.c: main(273) > ------------------------------------------------
04-05 23:21:25.431-0400 E/rpm-installer(14141): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
04-05 23:21:25.431-0400 E/rpm-installer(14141): rpm-appcore-intf.c: main(275) > ------------------------------------------------
04-05 23:21:25.441-0400 E/PKGMGR_SERVER(14000): pkgmgr-server.c: sighandler(486) > child NORMAL exit [14141]
04-05 23:21:25.481-0400 E/RESOURCED( 2562): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/14141/oom_score_adj failed
04-05 23:21:25.481-0400 E/RESOURCED( 2562): proc-main.c: resourced_proc_status_change(1504) > Empty pid or process not exists. 14141
04-05 23:21:25.591-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:25.791-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:25.991-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:26.191-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:26.391-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:26.601-0400 W/AUL     (14224): launch.c: app_request_to_launchpad(284) > request cmd(0) to(edu.umich.edu.yctung.firsttizenhellp)
04-05 23:21:26.601-0400 W/AUL_AMD ( 2465): amd_request.c: __request_handler(669) > __request_handler: 0
04-05 23:21:26.611-0400 I/AUL_AMD ( 2465): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
04-05 23:21:26.621-0400 I/AUL_AMD ( 2465): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
04-05 23:21:26.621-0400 E/AUL_AMD ( 2465): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
04-05 23:21:26.621-0400 W/AUL_AMD ( 2465): amd_launch.c: _start_app(1782) > caller pid : 14224
04-05 23:21:26.621-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:26.631-0400 W/AUL_AMD ( 2465): amd_launch.c: _start_app(2218) > pad pid(-5)
04-05 23:21:26.631-0400 E/RESOURCED( 2562): block.c: block_prelaunch_state(138) > insert data edu.umich.edu.yctung.firsttizenhellp, table num : 3
04-05 23:21:26.631-0400 W/AUL_PAD ( 3218): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
04-05 23:21:26.631-0400 W/AUL_PAD ( 3218): launchpad.c: __send_result_to_caller(272) > Check app launching
04-05 23:21:26.631-0400 W/AUL_PAD (14151): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
04-05 23:21:26.631-0400 W/AUL_PAD (14151): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
04-05 23:21:26.631-0400 W/AUL_PAD (14151): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
04-05 23:21:26.631-0400 W/AUL_PAD (14151): launchpad_loader.c: main(680) > [candidate] dlopen(edu.umich.edu.yctung.firsttizenhellp)
04-05 23:21:26.701-0400 I/efl-extension(14151): efl_extension.c: eext_mod_init(40) > Init
04-05 23:21:26.701-0400 I/UXT     (14151): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-05 23:21:26.701-0400 W/AUL_PAD (14151): launchpad_loader.c: main(690) > [candidate] dlsym
04-05 23:21:26.701-0400 W/AUL_PAD (14151): launchpad_loader.c: main(694) > [candidate] dl_main(edu.umich.edu.yctung.firsttizenhellp)
04-05 23:21:26.701-0400 I/CAPI_APPFW_APPLICATION(14151): app_main.c: ui_app_main(704) > app_efl_main
04-05 23:21:26.711-0400 I/CAPI_APPFW_APPLICATION(14151): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-05 23:21:26.711-0400 I/AUL     (14162): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
04-05 23:21:26.721-0400 I/AUL     (14162): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-05 23:21:26.721-0400 E/AUL     (14162): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-05 23:21:26.721-0400 E/AUL     (14162): aul_path.c: __get_path(169) > root_path is NULL!
04-05 23:21:26.731-0400 W/AUL     ( 2465): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(edu.umich.edu.yctung.firsttizenhellp) pid(14151) type(uiapp) bg(0)
04-05 23:21:26.731-0400 W/AUL_AMD ( 2465): amd_status.c: __socket_monitor_cb(1277) > (14151) was created
04-05 23:21:26.741-0400 W/AUL     (14224): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14151)
04-05 23:21:26.741-0400 W/STARTER ( 2656): pkg-monitor.c: _app_mgr_status_cb(394) > [_app_mgr_status_cb:394] Launch request [14151]
04-05 23:21:26.791-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:26.801-0400 E/EFL     (14151): ecore_evas<14151> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
04-05 23:21:26.831-0400 D/firsttizenhello(14151): label is added
04-05 23:21:26.841-0400 D/firsttizenhello(14151): button is added
04-05 23:21:26.891-0400 W/TIZEN_N_PLAYER(14151): player.c: player_create(1183) > [player_create] new handle : 0xf779dbd8
04-05 23:21:26.901-0400 I/APP_CORE(14151): appcore-efl.c: __do_app(453) > [APP 14151] Event: RESET State: CREATED
04-05 23:21:26.901-0400 I/CAPI_APPFW_APPLICATION(14151): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-05 23:21:26.911-0400 I/APP_CORE(14151): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-05 23:21:26.911-0400 I/APP_CORE(14151): appcore-efl.c: __do_app(524) > [APP 14151] Initial Launching, call the resume_cb
04-05 23:21:26.911-0400 I/CAPI_APPFW_APPLICATION(14151): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-05 23:21:26.921-0400 W/W_HOME  ( 2922): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
04-05 23:21:26.921-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:26.921-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:26.931-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:26.931-0400 W/W_HOME  ( 2922): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
04-05 23:21:26.931-0400 W/APP_CORE(14151): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2400002
04-05 23:21:26.931-0400 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-05 23:21:26.931-0400 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): event_manager.c: _window_visibility_cb(473) > Window [0x1200003] is now visible(1)
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:26.991-0400 I/APP_CORE(14151): appcore-efl.c: __do_app(453) > [APP 14151] Event: RESUME State: RUNNING
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): main.c: _window_visibility_cb(963) > Window [0x1200003] is now visible(1)
04-05 23:21:26.991-0400 I/APP_CORE( 2922): appcore-efl.c: __do_app(453) > [APP 2922] Event: PAUSE State: RUNNING
04-05 23:21:26.991-0400 I/CAPI_APPFW_APPLICATION( 2922): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): main.c: _appcore_pause_cb(487) > appcore pause
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:26.991-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:26.991-0400 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
04-05 23:21:26.991-0400 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): main.c: home_pause(546) > clock/widget paused
04-05 23:21:26.991-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:26.991-0400 I/MESSAGE_PORT( 2459): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-05 23:21:26.991-0400 I/MESSAGE_PORT( 2459): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-05 23:21:26.991-0400 I/MESSAGE_PORT( 2459): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-05 23:21:26.991-0400 I/MESSAGE_PORT( 2459): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-05 23:21:26.991-0400 I/MESSAGE_PORT( 2459): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-05 23:21:26.991-0400 I/MESSAGE_PORT( 2459): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-05 23:21:26.991-0400 I/MESSAGE_PORT( 2459): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-05 23:21:26.991-0400 I/MESSAGE_PORT( 2459): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-05 23:21:27.001-0400 I/MESSAGE_PORT( 2459): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-05 23:21:27.001-0400 E/CAPI_APPFW_APP_CONTROL( 3313): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-05 23:21:27.001-0400 W/MUSIC_CONTROL_SERVICE( 3313): music-control-service.c: _music_control_service_pasre_request(460) > [33m[TID:3313]   [com.samsung.w-home]register msg port [false][0m
04-05 23:21:27.001-0400 I/wnotib  ( 2922): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
04-05 23:21:27.001-0400 E/wnotib  ( 2922): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-05 23:21:27.001-0400 W/wnotib  ( 2922): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [10], notiboard card appending count [69].
04-05 23:21:27.001-0400 W/STARTER ( 2656): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2922] goes to (4)
04-05 23:21:27.001-0400 W/AUL     ( 2465): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2922) status(bg) type(uiapp)
04-05 23:21:27.011-0400 E/STARTER ( 2656): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2922)'s state(4)
04-05 23:21:27.011-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [17200.971853] layer(0x525f48) now usable
04-05 23:21:27.011-0400 W/WATCH_CORE( 8831): appcore-watch.c: __widget_pause(1113) > widget_pause
04-05 23:21:27.011-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [17200.974775] layer[0x5259e8]zpos[0]
04-05 23:21:27.011-0400 W/AUL     ( 8831): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(8831) status(bg) type(watchapp)
04-05 23:21:27.011-0400 D/chronograph( 8831): ChronographApp.cpp: _appPause(150) > [0;34m>>>HIT<<<[0;m
04-05 23:21:27.011-0400 W/chronograph( 8831): ChronographViewController.cpp: onPause(183) > [0;35mState is Pause[isPaused=1], StopwatchState=0[0;m
04-05 23:21:27.011-0400 W/chronograph( 8831): ChronographSweepSecond.cpp: resetSweepSecond(103) > [0;35mresetSweepSecond >>>>[0;m
04-05 23:21:27.011-0400 D/chronograph( 8831): ChronographSweepSecond.cpp: resetSweepSecond(107) > Stop and Clear sweepAnimation !!
04-05 23:21:27.011-0400 D/chronograph-common( 8831): ChronographSensor.cpp: disableAcceleormeter(52) > [0;32mBEGIN >>>>[0;m
04-05 23:21:27.011-0400 D/chronograph-common( 8831): ChronographSensor.cpp: _stopAccelerometer(129) > [0;32mBEGIN >>>>[0;m
04-05 23:21:27.031-0400 W/STARTER ( 2656): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[14151] goes to (3)
04-05 23:21:27.031-0400 W/AUL_AMD ( 2465): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-05 23:21:27.031-0400 W/AUL_AMD ( 2465): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-05 23:21:27.031-0400 W/AUL     ( 2465): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(edu.umich.edu.yctung.firsttizenhellp) pid(14151) status(fg) type(uiapp)
04-05 23:21:27.041-0400 E/PKGMGR_SERVER(14000): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
04-05 23:21:27.041-0400 E/PKGMGR_SERVER(14000): pkgmgr-server.c: main(2281) > package manager server terminated.
04-05 23:21:27.391-0400 E/AUL     ( 2465): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-05 23:21:27.501-0400 I/APP_CORE( 2922): appcore-efl.c: __do_app(453) > [APP 2922] Event: MEM_FLUSH State: PAUSED
04-05 23:21:27.751-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [17201.718502] layer(0x525fb8) now usable
04-05 23:21:27.751-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [17201.718550] layer[0x525b08]zpos[1]
04-05 23:21:27.751-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [17201.718591] layer(0x526008) now usable
04-05 23:21:27.751-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [17201.718612] layer[0x525c28]zpos[2]
04-05 23:21:27.751-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [17201.718639] dpms[0 -> 3]sync[1]
04-05 23:21:27.751-0400 I/TDM     ( 1956): 
04-05 23:21:27.761-0400 W/WATCH_CORE( 8831): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-05 23:21:27.791-0400 W/W_HOME  ( 2922): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-05 23:21:27.791-0400 W/W_HOME  ( 2922): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-05 23:21:27.791-0400 W/W_HOME  ( 2922): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-05 23:21:27.791-0400 W/W_HOME  ( 2922): gesture.c: _manual_render_enable(138) > 1
04-05 23:21:27.791-0400 W/W_HOME  ( 2922): event_manager.c: _lcd_off_cb(736) > lcd state: 0
04-05 23:21:27.791-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:27.791-0400 W/STARTER ( 2656): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-05 23:21:27.791-0400 W/STARTER ( 2656): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-05 23:21:27.791-0400 E/STARTER ( 2656): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
04-05 23:21:27.791-0400 W/STARTER ( 2656): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-05 23:21:27.791-0400 W/STARTER ( 2656): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-05 23:21:27.801-0400 W/WAKEUP-SERVICE( 3137): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -148755700[0;m
04-05 23:21:27.801-0400 W/WAKEUP-SERVICE( 3137): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-05 23:21:27.811-0400 W/WAKEUP-SERVICE( 3137): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-05 23:21:27.811-0400 E/WAKEUP-SERVICE( 3137): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-05 23:21:27.811-0400 E/WAKEUP-SERVICE( 3137): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-05 23:21:27.811-0400 E/WAKEUP-SERVICE( 3137): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-05 23:21:27.811-0400 I/TIZEN_N_SOUND_MANAGER( 3137): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-05 23:21:27.821-0400 I/TIZEN_N_SOUND_MANAGER( 3137): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-05 23:21:27.821-0400 W/TIZEN_N_SOUND_MANAGER( 3137): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-05 23:21:27.821-0400 W/WAKEUP-SERVICE( 3137): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-05 23:21:27.821-0400 I/HIGEAR  ( 3137): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-05 23:21:27.881-0400 W/AUL_AMD ( 2465): amd_request.c: __request_handler(669) > __request_handler: 14
04-05 23:21:27.891-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [17201.851311] dpms[3 -> 3]done
04-05 23:21:27.891-0400 I/TDM     ( 1956): 
04-05 23:21:27.891-0400 W/W_INDICATOR( 2666): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-05 23:21:27.901-0400 W/AUL_AMD ( 2465): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14151
04-05 23:21:27.911-0400 W/AUL_AMD ( 2465): amd_request.c: __request_handler(669) > __request_handler: 12
04-05 23:21:27.911-0400 W/SHealthCommon( 3439): SystemUtil.cpp: OnDeviceStatusChanged(1003) > [1;35mlcdState:3[0;m
04-05 23:21:27.911-0400 W/AUL_AMD ( 2465): amd_request.c: __request_handler(669) > __request_handler: 14
04-05 23:21:27.921-0400 W/AUL_AMD ( 2465): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14151
04-05 23:21:27.921-0400 W/AUL_AMD ( 2465): amd_request.c: __request_handler(669) > __request_handler: 14
04-05 23:21:27.931-0400 W/AUL_AMD ( 2465): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14151
04-05 23:21:27.931-0400 W/AUL_AMD ( 2465): amd_request.c: __request_handler(669) > __request_handler: 12
04-05 23:21:27.941-0400 W/AUL_AMD ( 2465): amd_request.c: __request_handler(669) > __request_handler: 12
04-05 23:21:27.941-0400 W/SHealthCommon( 3164): SystemUtil.cpp: OnDeviceStatusChanged(1003) > [1;35mlcdState:3[0;m
04-05 23:21:27.941-0400 W/SHealthService( 3164): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-05 23:21:27.951-0400 W/STARTER ( 2656): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-05 23:21:27.951-0400 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-05 23:21:27.951-0400 W/STARTER ( 2656): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-05 23:21:27.951-0400 W/STARTER ( 2656): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-05 23:21:27.951-0400 W/STARTER ( 2656): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
04-05 23:21:27.951-0400 E/ALARM_MANAGER( 2656): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(5-4-2017, 23:21:48), repeat(1), interval(20), type(-1073741822)
04-05 23:21:27.951-0400 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-05 23:21:27.951-0400 W/W_INDICATOR( 2666): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-05 23:21:27.951-0400 I/APP_CORE(14151): appcore-efl.c: __do_app(453) > [APP 14151] Event: PAUSE State: RUNNING
04-05 23:21:27.951-0400 I/CAPI_APPFW_APPLICATION(14151): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-05 23:21:27.951-0400 W/APP_CORE(14151): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2400002] -> redirected win[637b70] for edu.umich.edu.yctung.firsttizenhellp[14151]
04-05 23:21:27.971-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2656].
04-05 23:21:27.991-0400 E/ALARM_MANAGER( 2441): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1953399767, next duetime: 1491448908
04-05 23:21:27.991-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1953399767)
04-05 23:21:27.991-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1491451200), due_time(1491448908)
04-05 23:21:28.001-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-05 23:21:28.001-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-05 23:21:28.001-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 6-4-2017, 03:21:48 (UTC).
04-05 23:21:28.001-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-05 23:21:28.001-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-05 23:21:28.011-0400 W/SHealthCommon( 8578): SystemUtil.cpp: OnDeviceStatusChanged(1003) > [1;35mlcdState:3[0;m
04-05 23:21:28.131-0400 I/AUL_PAD (14235): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-05 23:21:29.391-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [17203.352313] dpms[3 -> 0]sync[0]
04-05 23:21:29.391-0400 I/TDM     ( 1956): 
04-05 23:21:29.391-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [17203.352543] dpms[0 -> 0]done
04-05 23:21:29.391-0400 I/TDM     ( 1956): 
04-05 23:21:29.431-0400 W/WATCH_CORE( 8831): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-05 23:21:29.431-0400 I/WATCH_CORE( 8831): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-05 23:21:29.431-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:29.431-0400 I/WATCH_CORE( 8831): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-05 23:21:29.441-0400 W/wnotibp ( 4998): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
04-05 23:21:29.441-0400 I/wnotibp ( 4998): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
04-05 23:21:29.451-0400 W/W_HOME  ( 2922): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-05 23:21:29.451-0400 W/W_HOME  ( 2922): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-05 23:21:29.451-0400 W/W_HOME  ( 2922): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-05 23:21:29.451-0400 W/W_HOME  ( 2922): gesture.c: _apps_status_get(128) > apps status:0
04-05 23:21:29.451-0400 W/W_HOME  ( 2922): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:1657
04-05 23:21:29.451-0400 W/W_HOME  ( 2922): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-05 23:21:29.451-0400 W/W_HOME  ( 2922): event_manager.c: _lcd_on_cb(728) > lcd state: 1
04-05 23:21:29.451-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:29.451-0400 W/STARTER ( 2656): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [1657]ms
04-05 23:21:29.451-0400 W/STARTER ( 2656): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-05 23:21:29.461-0400 I/APP_CORE(14151): appcore-efl.c: __do_app(453) > [APP 14151] Event: RESUME State: PAUSED
04-05 23:21:29.461-0400 I/CAPI_APPFW_APPLICATION(14151): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-05 23:21:29.461-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [17203.424258] layer(0x525fb8) not usable
04-05 23:21:29.461-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [17203.424296] layer(0x525fb8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-05 23:21:29.461-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [17203.424321] layer[0x525b08]zpos[1]
04-05 23:21:29.461-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1442) > [17203.424427] layer(0x526008) not usable
04-05 23:21:29.461-0400 I/TDM     ( 1956): tdm_display.c: tdm_layer_set_info(1459) > [17203.424445] layer(0x526008) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-05 23:21:29.461-0400 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_set_info(1578) > [17203.424500] layer[0x525c28]zpos[2]
04-05 23:21:29.481-0400 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-05 23:21:29.481-0400 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
04-05 23:21:29.491-0400 W/W_HOME  ( 2922): gesture.c: _widget_updated_cb(188) > widget updated
04-05 23:21:29.491-0400 W/W_HOME  ( 2922): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-05 23:21:29.491-0400 W/W_HOME  ( 2922): gesture.c: _manual_render(182) > 
04-05 23:21:29.491-0400 W/WAKEUP-SERVICE( 3137): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -148755700[0;m
04-05 23:21:29.491-0400 W/WAKEUP-SERVICE( 3137): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-05 23:21:29.491-0400 W/WAKEUP-SERVICE( 3137): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-05 23:21:29.491-0400 I/TIZEN_N_SOUND_MANAGER( 3137): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-05 23:21:29.501-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2656].
04-05 23:21:29.501-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1953399767)
04-05 23:21:29.511-0400 W/TIZEN_N_SOUND_MANAGER( 3137): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-05 23:21:29.511-0400 E/WAKEUP-SERVICE( 3137): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-05 23:21:29.521-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
04-05 23:21:29.521-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
04-05 23:21:29.521-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: preference_get_boolean(1173) > preference_get_boolean(3164) : test_healthy_pace error
04-05 23:21:29.521-0400 E/WAKEUP-SERVICE( 3137): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-05 23:21:29.521-0400 E/WAKEUP-SERVICE( 3137): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-05 23:21:29.521-0400 I/TIZEN_N_SOUND_MANAGER( 3137): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-05 23:21:29.531-0400 I/TIZEN_N_SOUND_MANAGER( 3137): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-05 23:21:29.531-0400 W/TIZEN_N_SOUND_MANAGER( 3137): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-05 23:21:29.531-0400 W/WAKEUP-SERVICE( 3137): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-05 23:21:29.531-0400 I/HIGEAR  ( 3137): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-05 23:21:29.531-0400 W/W_HOME  ( 2922): gesture.c: _manual_render(182) > 
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: preference_get_double(1214) > preference_get_double(3164) : pedometer_inactive_period error
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: preference_get_double(1214) > preference_get_double(3164) : inactive_10min_precaution_millisec error
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-05 23:21:29.561-0400 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3164): preference.c: preference_get_double(1214) > preference_get_double(3164) : inactive_before_10min_precaution_millisec error
04-05 23:21:29.571-0400 W/W_HOME  ( 2922): gesture.c: _manual_render_enable(138) > 0
04-05 23:21:29.651-0400 W/SHealthCommon( 8578): SystemUtil.cpp: OnDeviceStatusChanged(1003) > [1;35mlcdState:1[0;m
04-05 23:21:29.651-0400 W/SHealthCommon( 3439): SystemUtil.cpp: OnDeviceStatusChanged(1003) > [1;35mlcdState:1[0;m
04-05 23:21:29.661-0400 W/SHealthCommon( 3164): SystemUtil.cpp: OnDeviceStatusChanged(1003) > [1;35mlcdState:1[0;m
04-05 23:21:29.661-0400 W/SHealthService( 3164): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-05 23:21:29.681-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-05 23:21:29.681-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-05 23:21:29.681-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 6-4-2017, 04:00:00 (UTC).
04-05 23:21:29.681-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-05 23:21:29.681-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-05 23:21:29.691-0400 E/ALARM_MANAGER( 2441): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1953399767] is removed.
04-05 23:21:29.691-0400 W/STARTER ( 2656): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
04-05 23:21:29.691-0400 W/STARTER ( 2656): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-05 23:21:30.601-0400 E/EFL     (14151): ecore_x<14151> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=17204566 button=1
04-05 23:21:30.681-0400 E/EFL     (14151): ecore_x<14151> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=17204639 button=1
04-05 23:21:30.751-0400 D/firsttizenhello(14151): button is clicked
04-05 23:21:31.001-0400 W/AUL_PAD ( 3218): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 14151 pgid = 14151
04-05 23:21:31.001-0400 W/AUL_PAD ( 3218): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-05 23:21:31.041-0400 W/WATCH_CORE( 8831): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-05 23:21:31.041-0400 I/WATCH_CORE( 8831): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-05 23:21:31.041-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:31.041-0400 W/STARTER ( 2656): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2922] goes to (3)
04-05 23:21:31.041-0400 E/STARTER ( 2656): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2922)'s state(3)
04-05 23:21:31.041-0400 W/AUL_AMD ( 2465): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-05 23:21:31.041-0400 W/AUL_AMD ( 2465): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-05 23:21:31.041-0400 W/AUL     ( 2465): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2922) status(fg) type(uiapp)
04-05 23:21:31.081-0400 W/AUL_PAD ( 3218): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-05 23:21:31.091-0400 I/AUL_AMD ( 2465): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14151
04-05 23:21:31.091-0400 W/AUL     ( 2465): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14151)
04-05 23:21:31.111-0400 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-05 23:21:31.111-0400 W/WATCH_CORE( 8831): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-05 23:21:31.111-0400 I/WATCH_CORE( 8831): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-05 23:21:31.111-0400 I/CAPI_WATCH_APPLICATION( 8831): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-05 23:21:31.111-0400 W/W_HOME  ( 2922): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
04-05 23:21:31.111-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:31.111-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:31.111-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:31.111-0400 W/W_HOME  ( 2922): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): event_manager.c: _window_visibility_cb(473) > Window [0x1200003] is now visible(0)
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): main.c: _window_visibility_cb(963) > Window [0x1200003] is now visible(0)
04-05 23:21:31.141-0400 I/APP_CORE( 2922): appcore-efl.c: __do_app(453) > [APP 2922] Event: RESUME State: PAUSED
04-05 23:21:31.141-0400 I/CAPI_APPFW_APPLICATION( 2922): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): main.c: _appcore_resume_cb(478) > appcore resume
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): main.c: home_resume(530) > clock/widget resumed
04-05 23:21:31.141-0400 W/W_HOME  ( 2922): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-05 23:21:31.151-0400 I/wnotib  ( 2922): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
04-05 23:21:31.151-0400 E/wnotib  ( 2922): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-05 23:21:31.151-0400 W/wnotib  ( 2922): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-05 23:21:31.161-0400 W/WATCH_CORE( 8831): appcore-watch.c: __widget_resume(1124) > widget_resume
04-05 23:21:31.161-0400 W/AUL     ( 8831): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.chronograph16) pid(8831) status(fg) type(watchapp)
04-05 23:21:31.161-0400 D/chronograph( 8831): ChronographApp.cpp: _appResume(161) > [0;34m>>>HIT<<<[0;m
04-05 23:21:31.161-0400 D/chronograph( 8831): ChronographViewController.cpp: onResume(221) > State is Resume[isPaused=0], StopwatchState=0
04-05 23:21:31.161-0400 W/chronograph( 8831): ChronographSweepSecond.cpp: setSweepSecond(55) > [0;35msetSweepSecond >>>>[0;m
04-05 23:21:31.161-0400 D/chronograph( 8831): ChronographSweepSecond.cpp: setSweepSecond(67) > Current sec = 31, msec = 167
04-05 23:21:31.161-0400 D/chronograph( 8831): ChronographSweepSecond.cpp: setSweepSecond(71) > Create sweepSecondAnimation !!
04-05 23:21:31.161-0400 D/chronograph-common( 8831): ChronographSensor.cpp: enableAccelerometer(44) > [0;32mBEGIN >>>>[0;m
04-05 23:21:31.161-0400 D/chronograph-common( 8831): ChronographSensor.cpp: _startAccelerometer(75) > [0;32mBEGIN >>>>[0;m
04-05 23:21:31.191-0400 W/CRASH_MANAGER(14241): worker.c: worker_job(1199) > 1114151666972149144889
