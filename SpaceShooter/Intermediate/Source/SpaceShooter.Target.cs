using UnrealBuildTool;

public class SpaceShooterTarget : TargetRules
{
	public SpaceShooterTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SpaceShooter");
	}
}
