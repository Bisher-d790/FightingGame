using UnrealBuildTool;
using System.Collections.Generic;

public class FightingGameTarget : TargetRules
{
	public FightingGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("FightingGame");
	}
}
