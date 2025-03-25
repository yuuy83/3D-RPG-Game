using UnrealBuildTool;

public class ARpgFpsClientTarget : TargetRules
{
	public ARpgFpsClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ARpgFps");
	}
}
