using UnrealBuildTool;

public class DreamRunnerEditorTarget : TargetRules
{
	public DreamRunnerEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DreamRunner");
	}
}
