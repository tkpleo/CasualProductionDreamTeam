using UnrealBuildTool;

public class DreamRunnerTarget : TargetRules
{
	public DreamRunnerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DreamRunner");
	}
}
