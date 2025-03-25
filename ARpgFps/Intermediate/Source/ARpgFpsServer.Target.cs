using UnrealBuildTool;

public class ARpgFpsServerTarget : TargetRules
{
	public ARpgFpsServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ARpgFps");
	}
}
