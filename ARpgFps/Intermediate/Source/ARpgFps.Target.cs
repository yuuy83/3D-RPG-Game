using UnrealBuildTool;

public class ARpgFpsTarget : TargetRules
{
	public ARpgFpsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ARpgFps");
	}
}
