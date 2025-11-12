using UnrealBuildTool;

public class DreamRunnerClientTarget : TargetRules
{
	public DreamRunnerClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("DreamRunner");
	}
}
