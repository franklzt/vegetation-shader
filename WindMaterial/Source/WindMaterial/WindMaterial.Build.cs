// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class WindMaterial : ModuleRules
{
	public WindMaterial(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;


		// 4.21 Uncomment if you are using 4.21
		// PublicDependencyModuleNames.AddRange(new string[] { "Core", "ShaderCore", "CoreUObject", "Engine", "InputCore" });

		// 4.25 Comment out if you are using 4.21
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "RenderCore","CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
