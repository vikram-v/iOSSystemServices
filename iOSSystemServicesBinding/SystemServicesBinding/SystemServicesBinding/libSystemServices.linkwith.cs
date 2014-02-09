using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSystemServices.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
