// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FeaturesVR_M_Ludus_STarget : TargetRules
{
	public FeaturesVR_M_Ludus_STarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "FeaturesVR_M_Ludus_S" } );
	}
}
