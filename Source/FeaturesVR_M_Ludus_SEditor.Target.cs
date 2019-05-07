// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FeaturesVR_M_Ludus_SEditorTarget : TargetRules
{
	public FeaturesVR_M_Ludus_SEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "FeaturesVR_M_Ludus_S" } );
	}
}
