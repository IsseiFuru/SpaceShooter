using UnrealBuildTool;

public class G_ShooterTarget : TargetRules
{
	public G_ShooterTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("G_Shooter");
	}
}
