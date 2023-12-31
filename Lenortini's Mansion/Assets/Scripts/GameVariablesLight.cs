using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameVariablesLight
{
    public static int maxIntensity = 2;
    public static bool isABatteryGrab = false;
    public static bool isResetTimeNeedeed = false;
    public static GameObject light = GameObject.Find("flashLight 1");
    public static Light spotlightChild = light.GetComponentInChildren<Light>();
    public static float timeRemaining = 0.0f;
    public static float timeRemaning3BatteryLevel = 50.0f;
    public static float timeRemaning2BatteryLevel = 60.0f;
    public static float timeRemaning1BatteryLevel = 70.0f;
}
