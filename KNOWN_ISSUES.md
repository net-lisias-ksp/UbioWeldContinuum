# Welding Ltd. Continuum :: Known Issues

* Module Manager 4 is broken for UbioWelding (all of them, not only this fork)
	+ Use Module Manager 3
	+ Or use my [Personal Fork](https://github.com/net-lisias-ksp/ModuleManager/releases)
	    - (it is fixed to work with UbioWelding and any other Add'On that need the feature that MM4 broke) 
* Welding is 100% supported only on KSP 1.4.x for now.
	+ However, it will run fine on later KSPs (tested up to 1.12.5 at the time of this release).
		- Parts with `ModulePartVariant` are now being welded - but with issues. Mixing different parts with Variants may render undesired results.
	+ Welding on KSP 1.4 and coping the parts to be used on any later KSP is still an option.
		- as long the textures used were not moved to `zDeprecated` =/
