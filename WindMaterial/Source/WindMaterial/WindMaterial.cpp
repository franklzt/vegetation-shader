// Fill out your copyright notice in the Description page of Project Settings.

#include "WindMaterial.h"
#include "Modules/ModuleManager.h"

#include "Misc/Paths.h"
#include "Misc/FileHelper.h"

void FWindMaterialModule::StartupModule()
{
	FString ShaderDirectory = FPaths::Combine(FPaths::ProjectDir(), TEXT("Shaders"));
	AddShaderSourceDirectoryMapping("/Project", ShaderDirectory);
}

void FWindMaterialModule::ShutdownModule()
{

}


IMPLEMENT_PRIMARY_GAME_MODULE(FWindMaterialModule, WindMaterial, "WindMaterial" );
