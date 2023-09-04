# Welding Ltd. Continuum :: Changes

* 2023-0904: 2.6.0.11 (Lisias) for KSP >= 1.4.1
	+ Changed the Dependencies to [Modular Management](https://github.com/net-lisias-ksp/ModularManagement/releases)
		- One download to isntall them all!  
	+ Updated the welding definitions to cope with `PartModuleVariants`.
		- Not a fully supported feature, but it works for most cases.
	+ And, yeah, it still works down to KSP 1.4.1
		- Tested on KSP 1.4.3
		- It's possible it works on 1.3.1, but why bother? If you are on 1.3.1, the official fork will work perfectly for you!
* 2023-0626: 2.6.0.10 (Lisias) for 1.4.1 <= KSP <= 1.4.5
	+ Updated the thingy for the latest [KSPe](https://github.com/net-lisias-ksp/KSPAPIExtensions/releases).
* 2022-0212: 2.6.0.9 (Lisias) for 1.4.1 <= KSP <= 1.4.5
	+ Updated the thingy for the latest [KSPe](https://github.com/net-lisias-ksp/KSPAPIExtensions/releases).
		- Bug fixes
		- Better borderline use cases handling
		- Performance improvements 
	+ More sensible configuration handling:
		- Some configuration files are now **optional** on `PluginData`
		- Templates are now on `GameData` and copied to `PluginData` as needed
		- Some configurations can be overruled by changing them on a `PluginData` copy.
	+ Fixing some links on README
		- Thanks to [fwiffo](https://forum.kerbalspaceprogram.com/index.php?/profile/148084-fwiffo/) for the [report](https://forum.kerbalspaceprogram.com/index.php?/topic/96670-14-253-2018-04-06-ubiozur-welding-ltd-continued/&do=findComment&comment=4072206). 
* 2020-0711: 2.6.0.8 (Lisias) for 1.4.1 <= KSP <= 1.4.5
	+ A less than ideal way of detecting ModuleManager was fixed.
		- Thanks for the [heads up](https://github.com/net-lisias-ksp/UbioWeldContinuum/issues/2), [Braste](https://forum.kerbalspaceprogram.com/index.php?/profile/206105-braste/)!  
* 2020-0606: 2.6.0.7 (Lisias) for 1.4.1 <= KSP <= 1.4.5
	+ Another incredibly idiotic mistake was detected and fixed, this time from KSPe.
		- Thanks for the heads up, [The Space Man](https://forum.kerbalspaceprogram.com/index.php?/topic/96670-14-253-2018-04-06-ubiozur-welding-ltd-continued/&do=findComment&comment=3798335) 
* 2019-0727: 2.6.0.6 (Lisias) for 1.4.1 <= KSP <= 1.4.5 REISSUE
	+ An incredibly idiotic mistake was detected and fixed.
		- Thanks for the heads up, [w00tguy](https://forum.kerbalspaceprogram.com/index.php?/topic/96670-14-253-2018-04-06-ubiozur-welding-ltd-continued/&do=findComment&comment=3641610) 
* 2019-0525: 2.6.0.5 (Lisias) for 1.4.1 <= KSP <= 1.4.5
	+ After almost a Year, Continuum goes gold! :-)
		- Finally fully supporting KSP 1.4.5... =P
		- KSP >= 1.5 depends on implementing proper support for `ModulePartVariant`, something that will be tricky to say the least.
	+ Using KSPe Facilities (hard dependency):
		- File facilities (user configurable files are not on <KSP_ROOT>/PluginData)
		- UI facilities (transparent proxy to ClickTroughBlocker)
		- Log facilities
	+ Bug fixes
		- Toolbar registering fix
		- Log level select now works
		- Preventing empty `.cfg` files to be created 

