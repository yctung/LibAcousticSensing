S/W Version Information
Model: SM-R770
Tizen-Version: 2.3.2.1
Build-Number: R770XXU1APK6
Build-Date: 2016.11.25 15:41:21

Crash Information
Process Name: devapp
PID: 5670
Date: 2017-04-18 22:53:13-0400
Executable File Path: /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5670, uid 5000)

Register Information
r0   = 0x00904c00, r1   = 0x00000002
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xf7625848, r5   = 0xf6d669d8
r6   = 0xf08ed100, r7   = 0xf08eca48
r8   = 0xf6d669e8, r9   = 0xf76258d0
r10  = 0xf6d669e8, fp   = 0x00000000
ip   = 0xf08ed184, sp   = 0xf08ec9a0
lr   = 0xf5c80ed5, pc   = 0xf5c80ed8
cpsr = 0x00000030

Memory Information
MemTotal:   714608 KB
MemFree:     36508 KB
Buffers:     36176 KB
Cached:     220532 KB
VmPeak:     124756 KB
VmSize:     124752 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32776 KB
VmRSS:       32776 KB
VmData:      46428 KB
VmStk:        6948 KB
VmExe:          20 KB
VmLib:       25340 KB
VmPTE:         148 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 5670 TID = 5786
5670 5770 5771 5772 5785 5786 

Maps Information
f00ef000 f08ee000 rw-p [stack:5786]
f08ef000 f10ee000 rw-p [stack:5785]
f10ee000 f10ef000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f10f7000 f10fa000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f1131000 f113c000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f1144000 f1146000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f114e000 f114f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1157000 f115f000 r-xp /usr/lib/libfeedback.so.0.1.4
f1178000 f1179000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f133e000 f1b3d000 rw-p [stack:5772]
f1f3f000 f273e000 rw-p [stack:5771]
f2b40000 f333f000 rw-p [stack:5770]
f3401000 f3418000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3425000 f342a000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f3432000 f343d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3765000 f3857000 r-xp /usr/lib/libCOREGL.so.4.0
f3870000 f3875000 r-xp /usr/lib/libsystem.so.0.0.0
f387f000 f3880000 r-xp /usr/lib/libresponse.so.0.2.96
f3888000 f388d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f3896000 f3898000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f38a0000 f38a7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f38b0000 f38d2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f38db000 f38e3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f38eb000 f38f1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f38fa000 f38ff000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f3907000 f3928000 r-xp /usr/lib/libexif.so.12.3.3
f393b000 f3954000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f395c000 f3961000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f3969000 f396f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f3977000 f397b000 r-xp /usr/lib/libogg.so.0.7.1
f3983000 f39a5000 r-xp /usr/lib/libvorbis.so.0.4.3
f39ad000 f39af000 r-xp /usr/lib/libttrace.so.1.1
f39b7000 f39b9000 r-xp /usr/lib/libdri2.so.0.0.0
f39c1000 f39c9000 r-xp /usr/lib/libdrm.so.2.4.0
f39d1000 f39d2000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f39db000 f39de000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f39e6000 f39f5000 r-xp /usr/lib/libmdm-common.so.1.1.22
f39fe000 f3a45000 r-xp /usr/lib/libsndfile.so.1.0.26
f3a51000 f3a9a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f3aa3000 f3aa8000 r-xp /usr/lib/libjson.so.0.0.1
f3ab0000 f3ab3000 r-xp /usr/lib/libtinycompress.so.0.0.0
f3abb000 f3ac1000 r-xp /usr/lib/libxcb-render.so.0.0.0
f3ac9000 f3aca000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f3ad3000 f3ad7000 r-xp /usr/lib/libEGL.so.1.4
f3ae7000 f3af8000 r-xp /usr/lib/libGLESv2.so.2.0
f3b08000 f3b13000 r-xp /usr/lib/libtbm.so.1.0.0
f3b1b000 f3b3e000 r-xp /usr/lib/libui-extension.so.0.1.0
f3b47000 f3b5d000 r-xp /usr/lib/libtts.so
f3b66000 f3bae000 r-xp /usr/lib/libmdm.so.1.2.62
f5440000 f5546000 r-xp /usr/lib/libicuuc.so.57.1
f555c000 f56e4000 r-xp /usr/lib/libicui18n.so.57.1
f56f4000 f5701000 r-xp /usr/lib/libail.so.0.1.0
f570a000 f570d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f5715000 f574d000 r-xp /usr/lib/libpulse.so.0.16.2
f574e000 f5751000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f5759000 f57ba000 r-xp /usr/lib/libasound.so.2.0.0
f57c4000 f57da000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f57e2000 f57e9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f57f1000 f57f5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f57fd000 f5808000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f5815000 f5819000 r-xp /usr/lib/libmmfsession.so.0.0.0
f5822000 f5829000 r-xp /usr/lib/libminizip.so.1.0.0
f5831000 f58e9000 r-xp /usr/lib/libcairo.so.2.11200.14
f58f4000 f5906000 r-xp /usr/lib/libefl-assist.so.0.1.0
f590e000 f5913000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f591b000 f5932000 r-xp /usr/lib/libmmfsound.so.0.1.0
f5944000 f5949000 r-xp /usr/lib/libstorage.so.0.1
f5951000 f5972000 r-xp /usr/lib/libefl-extension.so.0.1.0
f597a000 f5981000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.23
f598c000 f5997000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5b31000 f5b3b000 r-xp /lib/libnss_files-2.13.so
f5b44000 f5c13000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5c29000 f5c4d000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5c56000 f5c5c000 r-xp /usr/lib/libappsvc.so.0.1.0
f5c64000 f5c66000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5c6f000 f5c73000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5c7f000 f5c82000 r-xp /opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp
f5c92000 f5c94000 r-xp /usr/lib/libiniparser.so.0
f5c9d000 f5ca2000 r-xp /usr/lib/libappcore-common.so.1.1
f5cab000 f5cb3000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
f5cb4000 f5cb8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5cc5000 f5cc7000 r-xp /usr/lib/libXau.so.6.0.0
f5ccf000 f5cd6000 r-xp /lib/libcrypt-2.13.so
f5d06000 f5d08000 r-xp /usr/lib/libiri.so
f5d11000 f5eba000 r-xp /usr/lib/libcrypto.so.1.0.0
f5eda000 f5f21000 r-xp /usr/lib/libssl.so.1.0.0
f5f2d000 f5f5b000 r-xp /usr/lib/libidn.so.11.5.44
f5f63000 f5f6c000 r-xp /usr/lib/libcares.so.2.1.0
f5f76000 f5f89000 r-xp /usr/lib/libxcb.so.1.1.0
f5f92000 f5f94000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f5f9c000 f5f9e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f5fa7000 f6073000 r-xp /usr/lib/libxml2.so.2.7.8
f6080000 f6082000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f608b000 f6090000 r-xp /usr/lib/libffi.so.5.0.10
f6098000 f6099000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f60a1000 f60a4000 r-xp /lib/libattr.so.1.1.0
f60ac000 f6140000 r-xp /usr/lib/libstdc++.so.6.0.16
f6153000 f6170000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f617a000 f6192000 r-xp /usr/lib/libpng12.so.0.50.0
f619a000 f61b0000 r-xp /lib/libexpat.so.1.6.0
f61ba000 f61fe000 r-xp /usr/lib/libcurl.so.4.3.0
f6207000 f6211000 r-xp /usr/lib/libXext.so.6.4.0
f621a000 f621e000 r-xp /usr/lib/libXtst.so.6.1.0
f6226000 f622c000 r-xp /usr/lib/libXrender.so.1.3.0
f6234000 f623a000 r-xp /usr/lib/libXrandr.so.2.2.0
f6242000 f6243000 r-xp /usr/lib/libXinerama.so.1.0.0
f624c000 f6255000 r-xp /usr/lib/libXi.so.6.1.0
f625d000 f6260000 r-xp /usr/lib/libXfixes.so.3.1.0
f6268000 f626a000 r-xp /usr/lib/libXgesture.so.7.0.0
f6272000 f6274000 r-xp /usr/lib/libXcomposite.so.1.0.0
f627c000 f627e000 r-xp /usr/lib/libXdamage.so.1.1.0
f6286000 f628d000 r-xp /usr/lib/libXcursor.so.1.0.2
f6295000 f6298000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f62a0000 f62a4000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f62ad000 f62b2000 r-xp /usr/lib/libecore_fb.so.1.7.99
f62bb000 f639c000 r-xp /usr/lib/libX11.so.6.3.0
f63a7000 f63ca000 r-xp /usr/lib/libjpeg.so.8.0.2
f63e2000 f63f8000 r-xp /lib/libz.so.1.2.5
f6400000 f6402000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f640a000 f647f000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6489000 f64a3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f64ab000 f64df000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f64e8000 f65bb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f65c6000 f65d6000 r-xp /lib/libresolv-2.13.so
f65da000 f65f2000 r-xp /usr/lib/liblzma.so.5.0.3
f65fa000 f65fd000 r-xp /lib/libcap.so.2.21
f6605000 f6634000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f663c000 f663d000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6645000 f664b000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6653000 f666a000 r-xp /usr/lib/liblua-5.1.so
f6673000 f667a000 r-xp /usr/lib/libembryo.so.1.7.99
f6682000 f6688000 r-xp /lib/librt-2.13.so
f6691000 f66e7000 r-xp /usr/lib/libpixman-1.so.0.28.2
f66f4000 f674a000 r-xp /usr/lib/libfreetype.so.6.11.3
f6756000 f677e000 r-xp /usr/lib/libfontconfig.so.1.8.0
f677f000 f67c4000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f67cd000 f67e0000 r-xp /usr/lib/libfribidi.so.0.3.1
f67e8000 f6802000 r-xp /usr/lib/libecore_con.so.1.7.99
f680b000 f6814000 r-xp /usr/lib/libedbus.so.1.7.99
f681c000 f686c000 r-xp /usr/lib/libecore_x.so.1.7.99
f686e000 f6877000 r-xp /usr/lib/libvconf.so.0.2.45
f687f000 f6890000 r-xp /usr/lib/libecore_input.so.1.7.99
f6898000 f689d000 r-xp /usr/lib/libecore_file.so.1.7.99
f68a5000 f68c7000 r-xp /usr/lib/libecore_evas.so.1.7.99
f68d0000 f6911000 r-xp /usr/lib/libeina.so.1.7.99
f691a000 f6933000 r-xp /usr/lib/libeet.so.1.7.99
f6944000 f69ad000 r-xp /lib/libm-2.13.so
f69b6000 f69bc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f69c5000 f69c6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69ce000 f69f1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69f9000 f69fe000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a06000 f6a30000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a39000 f6a50000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a58000 f6a63000 r-xp /lib/libunwind.so.8.0.1
f6a90000 f6aae000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ab8000 f6bdc000 r-xp /lib/libc-2.13.so
f6bea000 f6bf2000 r-xp /lib/libgcc_s-4.6.so.1
f6bf3000 f6bf7000 r-xp /usr/lib/libsmack.so.1.0.0
f6c00000 f6c06000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6c0e000 f6cde000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cdf000 f6d3d000 r-xp /usr/lib/libedje.so.1.7.99
f6d47000 f6d5e000 r-xp /usr/lib/libecore.so.1.7.99
f6d75000 f6e43000 r-xp /usr/lib/libevas.so.1.7.99
f6e68000 f6fa4000 r-xp /usr/lib/libelementary.so.1.7.99
f6fbb000 f6fcf000 r-xp /lib/libpthread-2.13.so
f6fda000 f6fdc000 r-xp /usr/lib/libdlog.so.0.0.0
f6fe4000 f6fe7000 r-xp /usr/lib/libbundle.so.0.1.22
f6fef000 f6ff1000 r-xp /lib/libdl-2.13.so
f6ffa000 f7007000 r-xp /usr/lib/libaul.so.0.1.0
f7018000 f701e000 r-xp /usr/lib/libappcore-efl.so.1.1
f7027000 f702b000 r-xp /usr/lib/libsys-assert.so
f7034000 f7051000 r-xp /lib/ld-2.13.so
f705a000 f705f000 r-xp /usr/bin/launchpad-loader
f751a000 f76bb000 rw-p [heap]
ff17c000 ff844000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5670)
Call Stack Count: 1
 0: _keep_reading_socket + 0x237 (0xf5c80ed8) [/opt/usr/apps/edu.umich.edu.yctung.devapp/bin/devapp] + 0x1ed8
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
3532)]][0;m
04-18 22:52:08.709-0400 W/W_HOME  ( 2706): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-18 22:52:08.709-0400 W/W_HOME  ( 2706): gesture.c: _manual_render_enable(138) > 0
04-18 22:52:08.709-0400 W/W_HOME  ( 2706): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-18 22:52:08.709-0400 W/SHealthCommon( 3106): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-18 22:52:08.719-0400 W/SHealthWidget( 2848): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (223532), msgName: timeline_summary_updated[0;m
04-18 22:52:08.719-0400 W/SHealthCommon( 2848): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
04-18 22:52:08.719-0400 W/SHealthWidget( 2848): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
04-18 22:52:08.719-0400 W/WSLib   ( 2848): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1492555928733.000000, pattern:[HH:mm][0;m
04-18 22:52:08.719-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2848): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-18 22:52:08.719-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2848): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-18 22:52:08.719-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2848): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-18 22:52:08.719-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2848): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-18 22:52:08.719-0400 E/WSLib   ( 2848): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
04-18 22:52:08.719-0400 W/WSLib   ( 2848): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[22:52][0;m
04-18 22:52:08.719-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2848): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-18 22:52:08.719-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2848): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-18 22:52:08.719-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2848): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-18 22:52:08.719-0400 E/TIZEN_N_SYSTEM_SETTINGS( 2848): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-18 22:52:08.729-0400 I/CAPI_WIDGET_APPLICATION( 2848): widget_app.c: __provider_update_cb(281) > received updating signal
04-18 22:52:08.759-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-18 22:52:08.759-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_lcdon_completed_cb(518) >  event lcdon completed[1]
04-18 22:52:08.759-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer-self.c: clock_viewer_self_hide(1066) >  ===== HIDE =====
04-18 22:52:08.759-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: clock_viewer_hide(1452) >  reservied[0], gesture[0], clock visible[0]
04-18 22:52:08.759-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: _clock_viewer_send_clock_stop(1059) >  clock stop <<
04-18 22:52:08.759-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: _clock_viewer_send_clock_changed(1069) >  clock changed <<
04-18 22:52:08.769-0400 W/WATCH_CORE( 2781): appcore-watch.c: __signal_alpm_handler(1151) > signal_alpm_handler: ambient mode: 0, state: 3
04-18 22:52:08.769-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_ambient_tick(339) > _watch_core_ambient_tick, watch: com.samsung.chronograph16
04-18 22:52:08.769-0400 D/chronograph( 2781): ChronographApp.cpp: _appAmbientTick(186) > [0;34m>>>HIT<<<[0;m
04-18 22:52:08.769-0400 D/chronograph( 2781): ChronographViewController.cpp: _getCurrentDate(2107) > [0;32mBEGIN >>>>[0;m
04-18 22:52:08.769-0400 D/chronograph-common( 2781): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-18 22:52:08.769-0400 D/chronograph-common( 2781): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-18 22:52:08.769-0400 D/chronograph( 2781): ChronographViewController.cpp: _getCurrentDate(2129) > timestamp = 1492570328 :: dateStr = TUE :: dayStr = 18 :: dateText = TUE 18
04-18 22:52:08.769-0400 I/HealthDataService( 2907): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-18 22:52:08.769-0400 W/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_ambient_changed(354) > _watch_core_ambient_changed: 0
04-18 22:52:08.769-0400 D/chronograph( 2781): ChronographApp.cpp: _appAmbientChanged(195) > [0;34m>>>HIT<<<[0;m
04-18 22:52:08.769-0400 D/chronograph( 2781): ChronographViewController.cpp: onEventAmbientMode(338) > onEventAmbientMode >>>> [isAmbientMode=0]
04-18 22:52:08.769-0400 I/chronograph( 2781): ChronographViewController.cpp: onEventAmbientMode(358) > [0;32mAmbient Mode Unset >>>>[0;m
04-18 22:52:08.769-0400 W/chronograph( 2781): ChronographViewController.cpp: _hideAodView(907) > [0;35mhideAodView >>>>[0;m
04-18 22:52:08.769-0400 D/chronograph( 2781): ChronographViewController.cpp: _setWatchTouchEvent(1025) > [0;32mBEGIN >>>>[0;m
04-18 22:52:08.769-0400 D/chronograph( 2781): ChronographViewController.cpp: _setCurrentHandPosition(973) > [0;32mBEGIN >>>>[0;m
04-18 22:52:08.769-0400 D/chronograph( 2781): ChronographViewController.cpp: _getCurrentDate(2107) > [0;32mBEGIN >>>>[0;m
04-18 22:52:08.769-0400 D/chronograph-common( 2781): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-18 22:52:08.769-0400 D/chronograph-common( 2781): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-18 22:52:08.779-0400 D/chronograph( 2781): ChronographViewController.cpp: _getCurrentDate(2129) > timestamp = 1492570328 :: dateStr = TUE :: dayStr = 18 :: dateText = TUE 18
04-18 22:52:08.789-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-18 22:52:08.789-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 19-4-2017, 04:00:00 (UTC).
04-18 22:52:08.789-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-18 22:52:08.789-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-18 22:52:08.789-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1008179025] is removed.
04-18 22:52:08.799-0400 W/STARTER ( 2598): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-18 22:52:08.799-0400 W/STARTER ( 2598): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[1]
04-18 22:52:08.799-0400 D/chronograph( 2781): ChronographApp.cpp: _appResume(161) > [0;34m>>>HIT<<<[0;m
04-18 22:52:08.799-0400 D/chronograph( 2781): ChronographViewController.cpp: onResume(221) > State is Resume[isPaused=0], StopwatchState=0
04-18 22:52:08.799-0400 W/chronograph( 2781): ChronographSweepSecond.cpp: setSweepSecond(55) > [0;35msetSweepSecond >>>>[0;m
04-18 22:52:08.799-0400 D/chronograph( 2781): ChronographSweepSecond.cpp: setSweepSecond(67) > Current sec = 8, msec = 809
04-18 22:52:08.799-0400 D/chronograph( 2781): ChronographSweepSecond.cpp: setSweepSecond(71) > Create sweepSecondAnimation !!
04-18 22:52:08.799-0400 D/chronograph-common( 2781): ChronographSensor.cpp: enableAccelerometer(44) > [0;32mBEGIN >>>>[0;m
04-18 22:52:08.799-0400 D/chronograph-common( 2781): ChronographSensor.cpp: _startAccelerometer(75) > [0;32mBEGIN >>>>[0;m
04-18 22:52:08.799-0400 I/healthData( 3106): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-18 22:52:08.809-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:08.819-0400 I/APP_CORE( 5670): appcore-efl.c: __do_app(453) > [APP 5670] Event: RESUME State: PAUSED
04-18 22:52:08.819-0400 I/CAPI_APPFW_APPLICATION( 5670): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-18 22:52:08.819-0400 W/STARTER ( 2598): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[5670] goes to (3)
04-18 22:52:08.829-0400 W/AUL_AMD ( 2478): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-18 22:52:08.829-0400 W/AUL_AMD ( 2478): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-18 22:52:08.829-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(edu.umich.edu.yctung.devapp) pid(5670) status(fg) type(uiapp)
04-18 22:52:08.829-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_visibility_change_cb(703) >  Window visibility : [HIDE] lcd[2] begin_flag[0]
04-18 22:52:08.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:09.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:09.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:09.519-0400 E/EFL     ( 5670): ecore_x<5670> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4923879 button=1
04-18 22:52:09.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:09.659-0400 E/EFL     ( 5670): ecore_x<5670> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4924010 button=1
04-18 22:52:09.739-0400 D/devapp  ( 5670): button is clicked
04-18 22:52:09.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:09.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:10.069-0400 D/devapp  ( 5670): connect to server successfully
04-18 22:52:10.069-0400 D/devapp  ( 5670): temp = 83886080
04-18 22:52:10.069-0400 D/devapp  ( 5670): write to socket bytes n = 31 / 31
04-18 22:52:10.079-0400 D/devapp  ( 5670): _keep_reading_socket starts
04-18 22:52:10.079-0400 D/devapp  ( 5670): wait to read action
04-18 22:52:10.109-0400 D/devapp  ( 5670): n = 1, reaction = 1
04-18 22:52:10.109-0400 D/devapp  ( 5670): reaction == LIBAS_REACTION_SET_MEDIA
04-18 22:52:10.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:10.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:10.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:10.659-0400 E/EFL     ( 2304): ecore_x<2304> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3000002 time=4924010
04-18 22:52:10.659-0400 E/EFL     ( 5670): ecore_x<5670> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=4924010
04-18 22:52:10.659-0400 E/EFL     ( 2304): ecore_x<2304> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=4924010
04-18 22:52:10.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:10.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:11.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:11.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:11.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:11.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:11.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:12.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:12.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:12.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:12.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:12.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:13.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:13.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:13.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:13.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:13.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:14.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:14.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:14.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:14.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:14.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:15.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:15.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:15.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:15.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:15.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:16.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:16.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:16.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:16.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:16.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:17.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:17.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:17.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:17.609-0400 E/WMS     ( 2431): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23510) > _wms_event_handler_cb_nomove_detector is called
04-18 22:52:17.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:17.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:18.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:18.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:18.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:18.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:18.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:19.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:19.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:19.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:19.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:19.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:20.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:20.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:20.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:20.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:20.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:21.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:21.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:21.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:21.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:21.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:22.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:22.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:22.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:22.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:22.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:23.189-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:23.389-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:23.589-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:23.789-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:23.989-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-18 22:52:24.069-0400 W/WATCH_CORE( 2781): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-18 22:52:24.069-0400 W/W_HOME  ( 2706): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-18 22:52:24.069-0400 W/W_HOME  ( 2706): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-18 22:52:24.069-0400 W/W_HOME  ( 2706): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-18 22:52:24.069-0400 W/W_HOME  ( 2706): gesture.c: _manual_render_enable(138) > 1
04-18 22:52:24.069-0400 W/W_HOME  ( 2706): event_manager.c: _lcd_off_cb(736) > lcd state: 0
04-18 22:52:24.069-0400 W/W_HOME  ( 2706): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-18 22:52:24.079-0400 W/STARTER ( 2598): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-18 22:52:24.079-0400 W/STARTER ( 2598): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-18 22:52:24.079-0400 E/STARTER ( 2598): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
04-18 22:52:24.079-0400 W/STARTER ( 2598): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-18 22:52:24.079-0400 W/STARTER ( 2598): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-18 22:52:24.079-0400 W/WAKEUP-SERVICE( 3184): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -149599476[0;m
04-18 22:52:24.079-0400 W/WAKEUP-SERVICE( 3184): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-18 22:52:24.079-0400 W/WAKEUP-SERVICE( 3184): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-18 22:52:24.079-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_lcdoff_cb(554) >  event pre lcdoff[1]
04-18 22:52:24.079-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(413) >  enabled[1] status[1] setup[0] darkscreen[0]
04-18 22:52:24.079-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_lcdoff_cb(624) >  clock start >> [0] ambient[3] visible[0], self[2]
04-18 22:52:24.079-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_lcdoff_cb(635) >  clock begin >>
04-18 22:52:24.079-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer-self.c: clock_viewer_self_update(987) >  Flush time[22]:[52]:[24].[95], move[1,-1]
04-18 22:52:24.089-0400 I/TDM     ( 1955): tdm_exynos_display.c: exynos_output_set_property(1184) > [4938.440443] id[0]
04-18 22:52:24.089-0400 I/TDM     ( 1955): tdm_exynos_display.c: __exynos_output_aod_set_config(984) > [4938.440468] aod_set_config:mode[3]
04-18 22:52:24.089-0400 E/TBM     ( 1955): tbm_bufmgr.c: tbm_bo_get_handle(1413) > [tbm_bo_get_handle] : '_tbm_bo_is_valid(bo)' failed.
04-18 22:52:24.089-0400 E/TBM     ( 1955): tbm_bufmgr.c: tbm_bo_get_handle(1413) > [tbm_bo_get_handle] : '_tbm_bo_is_valid(bo)' failed.
04-18 22:52:24.089-0400 E/TBM     ( 1955): tbm_bufmgr.c: tbm_bo_get_handle(1413) > [tbm_bo_get_handle] : '_tbm_bo_is_valid(bo)' failed.
04-18 22:52:24.089-0400 W/WATCH_CORE( 2781): appcore-watch.c: __signal_alpm_handler(1151) > signal_alpm_handler: ambient mode: 1, state: 2
04-18 22:52:24.089-0400 D/chronograph( 2781): ChronographApp.cpp: _appPause(150) > [0;34m>>>HIT<<<[0;m
04-18 22:52:24.089-0400 W/chronograph( 2781): ChronographViewController.cpp: onPause(183) > [0;35mState is Pause[isPaused=1], StopwatchState=0[0;m
04-18 22:52:24.089-0400 W/chronograph( 2781): ChronographSweepSecond.cpp: resetSweepSecond(103) > [0;35mresetSweepSecond >>>>[0;m
04-18 22:52:24.089-0400 D/chronograph( 2781): ChronographSweepSecond.cpp: resetSweepSecond(107) > Stop and Clear sweepAnimation !!
04-18 22:52:24.089-0400 D/chronograph-common( 2781): ChronographSensor.cpp: disableAcceleormeter(52) > [0;32mBEGIN >>>>[0;m
04-18 22:52:24.089-0400 D/chronograph-common( 2781): ChronographSensor.cpp: _stopAccelerometer(129) > [0;32mBEGIN >>>>[0;m
04-18 22:52:24.089-0400 E/WAKEUP-SERVICE( 3184): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-18 22:52:24.089-0400 E/WAKEUP-SERVICE( 3184): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-18 22:52:24.089-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer-self.c: clock_viewer_self_show_fake_hands(1083) >  Show fake hands default[0]
04-18 22:52:24.089-0400 E/W_CLOCK_VIEWER( 2727): clock-viewer-self.c: __rotate(1038) >  hand geo[160,-1][40x360]
04-18 22:52:24.089-0400 E/W_CLOCK_VIEWER( 2727): clock-viewer-self.c: __rotate(1038) >  hand geo[160,-1][40x360]
04-18 22:52:24.099-0400 E/WAKEUP-SERVICE( 3184): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-18 22:52:24.109-0400 W/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_ambient_changed(354) > _watch_core_ambient_changed: 1
04-18 22:52:24.109-0400 D/chronograph( 2781): ChronographApp.cpp: _appAmbientChanged(195) > [0;34m>>>HIT<<<[0;m
04-18 22:52:24.109-0400 D/chronograph( 2781): ChronographViewController.cpp: onEventAmbientMode(338) > onEventAmbientMode >>>> [isAmbientMode=1]
04-18 22:52:24.109-0400 I/chronograph( 2781): ChronographViewController.cpp: onEventAmbientMode(344) > [0;32mAmbient Mode Set >>>>[0;m
04-18 22:52:24.109-0400 D/chronograph( 2781): ChronographViewController.cpp: _unsetWatchTouchEvent(1043) > [0;32mBEGIN >>>>[0;m
04-18 22:52:24.109-0400 W/chronograph( 2781): ChronographViewController.cpp: _showAodView(878) > [0;35mshowAodView >>>>[0;m
04-18 22:52:24.109-0400 D/chronograph( 2781): ChronographViewController.cpp: _getCurrentDate(2107) > [0;32mBEGIN >>>>[0;m
04-18 22:52:24.109-0400 D/chronograph-common( 2781): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-18 22:52:24.109-0400 D/chronograph-common( 2781): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-18 22:52:24.109-0400 D/chronograph( 2781): ChronographViewController.cpp: _getCurrentDate(2129) > timestamp = 1492570344 :: dateStr = TUE :: dayStr = 18 :: dateText = TUE 18
04-18 22:52:24.109-0400 E/ALARM_MANAGER( 2781): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(47256), start(19-4-2017, 12:00:00), repeat(1), interval(86400), type(-1073741822)
04-18 22:52:24.119-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.119-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][1] drawdone[0]
04-18 22:52:24.119-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2781].
04-18 22:52:24.139-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.139-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][2] drawdone[0]
04-18 22:52:24.139-0400 I/TIZEN_N_SOUND_MANAGER( 3184): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-18 22:52:24.149-0400 I/TIZEN_N_SOUND_MANAGER( 3184): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-18 22:52:24.149-0400 W/TIZEN_N_SOUND_MANAGER( 3184): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-18 22:52:24.149-0400 W/WAKEUP-SERVICE( 3184): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-18 22:52:24.149-0400 I/HIGEAR  ( 3184): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-18 22:52:24.159-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.159-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][3] drawdone[0]
04-18 22:52:24.179-0400 E/ALARM_MANAGER( 2429): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1827625670, next duetime: 1492617600
04-18 22:52:24.179-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1827625670)
04-18 22:52:24.179-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1492574400), due_time(1492617600)
04-18 22:52:24.189-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.189-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][4] drawdone[0]
04-18 22:52:24.229-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.229-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][5] drawdone[0]
04-18 22:52:24.259-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.259-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][6] drawdone[0]
04-18 22:52:24.299-0400 W/SHealthCommon( 3106): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
04-18 22:52:24.299-0400 W/SHealthService( 3106): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-18 22:52:24.299-0400 W/SHealthCommon( 2848): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
04-18 22:52:24.299-0400 W/W_INDICATOR( 2601): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-18 22:52:24.309-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.309-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][7] drawdone[0]
04-18 22:52:24.329-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.329-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][8] drawdone[0]
04-18 22:52:24.339-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-18 22:52:24.339-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-18 22:52:24.339-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 19-4-2017, 04:00:00 (UTC).
04-18 22:52:24.339-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-18 22:52:24.349-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-18 22:52:24.349-0400 I/CAPI_WATCH_APPLICATION( 2781): watch_app_main.c: _watch_core_ambient_tick(339) > _watch_core_ambient_tick, watch: com.samsung.chronograph16
04-18 22:52:24.349-0400 D/chronograph( 2781): ChronographApp.cpp: _appAmbientTick(186) > [0;34m>>>HIT<<<[0;m
04-18 22:52:24.349-0400 D/chronograph( 2781): ChronographViewController.cpp: _getCurrentDate(2107) > [0;32mBEGIN >>>>[0;m
04-18 22:52:24.349-0400 D/chronograph-common( 2781): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-18 22:52:24.349-0400 D/chronograph-common( 2781): ChronographIcuDataModel.cpp: getFormattedDateString(77) > [0;31mregionFormat = en_US[0;m
04-18 22:52:24.349-0400 D/chronograph( 2781): ChronographViewController.cpp: _getCurrentDate(2129) > timestamp = 1492570344 :: dateStr = TUE :: dayStr = 18 :: dateText = TUE 18
04-18 22:52:24.359-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [1] timer[0]
04-18 22:52:24.359-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [1] timer[0] lcd[3] count[0][9] drawdone[0]
04-18 22:52:24.369-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_clockdraw_cb(415) >  Clock draw done
04-18 22:52:24.369-0400 I/WATCH_CORE( 2781): appcore-watch-signal.c: _watch_core_send_alpm_update_done(282) > send a alpm update done signal
04-18 22:52:24.389-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [2] timer[0]
04-18 22:52:24.389-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [2] timer[0] lcd[3] count[1][10] drawdone[1]
04-18 22:52:24.439-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [2] timer[0]
04-18 22:52:24.439-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [2] timer[0] lcd[3] count[2][11] drawdone[1]
04-18 22:52:24.479-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [2] timer[0]
04-18 22:52:24.479-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [2] timer[0] lcd[3] count[3][12] drawdone[1]
04-18 22:52:24.509-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [2] timer[0]
04-18 22:52:24.509-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [2] timer[0] lcd[3] count[4][13] drawdone[1]
04-18 22:52:24.539-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_pre_cb(317) >  RENDER PRE [2] timer[0]
04-18 22:52:24.539-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_post_cb(351) >  RENDER POST [2] timer[0] lcd[3] count[5][14] drawdone[1]
04-18 22:52:24.589-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_render_check_timer_cb(294) >  Render check timer expired
04-18 22:52:24.649-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_visibility_change_cb(703) >  Window visibility : [VISIBLE] lcd[3] begin_flag[0]
04-18 22:52:24.649-0400 I/APP_CORE( 5670): appcore-efl.c: __do_app(453) > [APP 5670] Event: PAUSE State: RUNNING
04-18 22:52:24.649-0400 I/CAPI_APPFW_APPLICATION( 5670): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-18 22:52:24.669-0400 W/APP_CORE( 5670): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3000002] -> redirected win[604e4f] for edu.umich.edu.yctung.devapp[5670]
04-18 22:52:24.789-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer-self.c: clock_viewer_self_show(1054) >  ===== SHOW =====
04-18 22:52:24.789-0400 E/ALARM_MANAGER( 2727): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(576), start(18-4-2017, 23:02:01), repeat(1), interval(600), type(-1073741822)
04-18 22:52:24.789-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2727].
04-18 22:52:24.809-0400 E/ALARM_MANAGER( 2429): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1827625671, next duetime: 1492570921
04-18 22:52:24.809-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1827625671)
04-18 22:52:24.809-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1492574400), due_time(1492570921)
04-18 22:52:24.809-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-18 22:52:24.809-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-18 22:52:24.809-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 19-4-2017, 03:02:01 (UTC).
04-18 22:52:24.809-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-18 22:52:24.819-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-18 22:52:24.819-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_clockend_timer_cb(257) >  clock end << [1]
04-18 22:52:24.829-0400 W/STARTER ( 2598): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-18 22:52:24.829-0400 W/STARTER ( 2598): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[1]
04-18 22:52:24.839-0400 W/STARTER ( 2598): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-18 22:52:24.839-0400 W/STARTER ( 2598): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
04-18 22:52:24.839-0400 E/ALARM_MANAGER( 2598): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(18-4-2017, 22:52:45), repeat(1), interval(20), type(-1073741822)
04-18 22:52:24.839-0400 E/W_CLOCK_VIEWER( 2727): clock-viewer-smart-lcdoff.c: clock_viewer_smart_lcdoff_start(181) >  smart lcd off is not enabled
04-18 22:52:24.839-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2598].
04-18 22:52:24.839-0400 W/W_INDICATOR( 2601): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-18 22:52:24.839-0400 W/W_INDICATOR( 2601): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-18 22:52:24.839-0400 W/W_INDICATOR( 2601): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-18 22:52:24.849-0400 I/TDM     ( 1955): tdm_display.c: tdm_layer_unset_buffer(1602) > [4939.209342] layer(0x6bb260) now usable
04-18 22:52:24.849-0400 I/TDM     ( 1955): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [4939.209363] layer[0x6bae80]zpos[2]
04-18 22:52:24.849-0400 I/TDM     ( 1955): tdm_exynos_display.c: exynos_output_set_property(1184) > [4939.209545] id[0]
04-18 22:52:24.849-0400 I/TDM     ( 1955): tdm_exynos_display.c: __exynos_output_aod_change_state(1142) > [4939.209559] aod_change_state:mode[3]
04-18 22:52:24.849-0400 I/TDM     ( 1955): tdm_exynos_display.c: __exynos_output_aod_change_state(1149) > [4939.209569] aod_change_state:state[181 -> 1]
04-18 22:52:24.859-0400 E/ALARM_MANAGER( 2429): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1827625672, next duetime: 1492570365
04-18 22:52:24.859-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1827625672)
04-18 22:52:24.859-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1492570921), due_time(1492570365)
04-18 22:52:24.859-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(668) >  event lcdoff completed[1][0]
04-18 22:52:24.859-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-18 22:52:24.859-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-18 22:52:24.859-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 19-4-2017, 02:52:45 (UTC).
04-18 22:52:24.859-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-18 22:52:24.859-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(413) >  enabled[1] status[1] setup[0] darkscreen[0]
04-18 22:52:24.869-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-18 22:52:25.349-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer.c: __clock_viewer_black_cover_timer_cb(231) >  Remove black screen or fake hands
04-18 22:52:25.359-0400 W/W_CLOCK_VIEWER( 2727): clock-viewer-self.c: clock_viewer_self_hide_fake_hands(1152) >  Hide fake hands
04-18 22:52:25.379-0400 I/TDM     ( 1955): tdm_exynos_display.c: exynos_output_commit(1324) > [4939.731712] set aod state[2]
04-18 22:52:25.379-0400 I/TDM     ( 1955): 
04-18 22:52:25.379-0400 I/TDM     ( 1955): tdm_exynos_display.c: exynos_output_commit(1369) > [4939.735600] set aod state[3]
04-18 22:52:25.379-0400 I/TDM     ( 1955): 
04-18 22:52:29.659-0400 I/APP_CORE( 5670): appcore-efl.c: __do_app(453) > [APP 5670] Event: MEM_FLUSH State: PAUSED
04-18 22:52:44.999-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
04-18 22:52:44.999-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-18 22:52:45.019-0400 W/AUL     ( 2429): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(2598) type(wakeup)
04-18 22:52:45.019-0400 E/RESOURCED( 2593): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 2598
04-18 22:52:45.029-0400 E/ALARM_MANAGER( 2598): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1827625672]
04-18 22:52:45.029-0400 W/STARTER ( 2598): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(979) > [__starter_clock_mgr_homescreen_alarm_cb:979] homescreen alarm timer expired [1827625672]
04-18 22:52:45.039-0400 W/AUL     ( 2598): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
04-18 22:52:45.039-0400 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-18 22:52:45.039-0400 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 2598
04-18 22:52:45.049-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2706) type(uiapp) bg(0)
04-18 22:52:45.049-0400 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2706
04-18 22:52:45.049-0400 I/APP_CORE( 2706): appcore-efl.c: __do_app(453) > [APP 2706] Event: RESET State: PAUSED
04-18 22:52:45.049-0400 I/CAPI_APPFW_APPLICATION( 2706): app_main.c: app_appcore_reset(245) > app_appcore_reset
04-18 22:52:45.049-0400 W/CAPI_APPFW_APP_CONTROL( 2706): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): main.c: _app_control_progress(1571) > Service value : show_clock
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): main.c: _app_control_progress(1588) > Show clock operation
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): gesture.c: _clock_show(242) > clock show
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): gesture.c: _clock_show(257) > home raise
04-18 22:52:45.049-0400 E/W_HOME  ( 2706): gesture.c: gesture_win_aux_set(395) > wm.policy.win.do.not.use.deiconify.approve:-1
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): dbus_util.c: home_dbus_home_raise_signal_send(298) > Sending HOME RAISE signal, result:0
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): gesture.c: _clock_show(260) > home raise done
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): gesture.c: _clock_show(267) > show clock
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): index.c: index_hide(337) > hide VI:0 visibility:0 vi:(nil)
04-18 22:52:45.049-0400 W/W_HOME  ( 2706): gesture.c: _manual_render(182) > 
04-18 22:52:45.059-0400 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(22), pid(2706), cmd(0)
04-18 22:52:45.059-0400 W/AUL     ( 2598): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2706)
04-18 22:52:45.069-0400 W/W_INDICATOR( 2601): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-18 22:52:45.069-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_expired(1445) > alarm_id[1827625672] is expired.
04-18 22:52:45.069-0400 E/ALARM_MANAGER( 2429): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1827625672, next duetime: 1492570385
04-18 22:52:45.069-0400 W/WATCH_CORE( 2781): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-18 22:52:45.069-0400 I/WATCH_CORE( 2781): appcore-watch.c: __signal_process_manager_handler(1279) > Skip the process_manager signal in ambient mode
04-18 22:52:45.069-0400 E/ALARM_MANAGER( 2429): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1850700647) is OVER.
04-18 22:52:45.079-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-18 22:52:45.079-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 19-4-2017, 02:53:05 (UTC).
04-18 22:52:45.079-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-18 22:52:45.079-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
04-18 22:52:45.089-0400 I/APP_CORE( 2706): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
04-18 22:52:45.099-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-18 22:52:45.099-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2598].
04-18 22:52:45.099-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1827625672)
04-18 22:52:45.099-0400 E/ALARM_MANAGER( 2429): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1850700647) is OVER.
04-18 22:52:45.099-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-18 22:52:45.099-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-18 22:52:45.099-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 19-4-2017, 03:02:01 (UTC).
04-18 22:52:45.099-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-18 22:52:45.109-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-18 22:52:45.109-0400 E/ALARM_MANAGER( 2429): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1827625672] is removed.
04-18 22:52:45.109-0400 W/STARTER ( 2598): pkg-monitor.c: _app_mgr_status_cb(415) > [_app_mgr_status_cb:415] Resume request [2706]
04-18 22:52:46.059-0400 W/AUL_AMD ( 2478): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-18 22:52:46.059-0400 W/AUL_AMD ( 2478): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
04-18 22:53:05.369-0400 E/devapp  ( 5670): wrong # of byte read, n = 1
04-18 22:53:05.369-0400 E/devapp  ( 5670): wrong # of byte read, n = 3
04-18 22:53:13.249-0400 E/devapp  ( 5670): wrong # of byte read, n = 1
04-18 22:53:13.249-0400 D/devapp  ( 5670): FS = 4689654, chCnt = 12288246, repeatCnt = 12288246
04-18 22:53:13.559-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5670 pgid = 5670
04-18 22:53:13.559-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-18 22:53:13.579-0400 W/AUL_PAD ( 3282): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-18 22:53:13.589-0400 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5670
04-18 22:53:13.589-0400 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5670)
04-18 22:53:13.619-0400 W/CRASH_MANAGER( 5824): worker.c: worker_job(1199) > 1105670646576149257039
