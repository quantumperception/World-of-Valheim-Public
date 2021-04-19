﻿using HarmonyLib;


namespace ValheimPermissions
{
    // Debug Patch Class
    [HarmonyPatch]
    public static class Debug
    {

        public static void Assert(bool cond)
        {
        }

        public static void Log(string str)
        {
            System.Console.WriteLine($"{ModInfo.Title}: " + str);
        }
        public static void Loguntagged(string str)
        {
            System.Console.WriteLine(str);
        }
    }
}
