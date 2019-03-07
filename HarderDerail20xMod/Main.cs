using System;
using System.Reflection;
using UnityModManagerNet;
using Harmony12;
using UnityEngine;

namespace HarderDerail20xMod
{
    public class Main
    {
        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = HarmonyInstance.Create(modEntry.Info.Id);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            // Something
            return true; // If false the mod will show an error.
        }
    }

    [HarmonyPatch(typeof(SimManager), "Awake")]
    class SimManager_Awake_Patch
    {
        static void Postfix(SimManager __instance)
        {
            __instance.derailBuildUpThreshold = 2f;
        }
    }
}