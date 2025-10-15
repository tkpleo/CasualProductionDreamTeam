using UnrealBuildTool;

public class DreamRunnerServerTarget : TargetRules
{
	public DreamRunnerServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("DreamRunner");
	}
}
