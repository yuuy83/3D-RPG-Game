using UnrealBuildTool;

public class ARpgFpsEditorTarget : TargetRules
{
	public ARpgFpsEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ARpgFps");
	}
}
