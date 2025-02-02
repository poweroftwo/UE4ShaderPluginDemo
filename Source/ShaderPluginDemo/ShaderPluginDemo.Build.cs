// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ShaderPluginDemo : ModuleRules
{
	public ShaderPluginDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		//PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "RHI", "PixelShader", "ComputeShader" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
