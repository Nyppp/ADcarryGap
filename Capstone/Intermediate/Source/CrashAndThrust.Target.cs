using UnrealBuildTool;

public class CrashAndThrustTarget : TargetRules
{
	public CrashAndThrustTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CrashAndThrust");
	}
}
