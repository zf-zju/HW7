// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HW3 : ModuleRules
{
	public HW3(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
