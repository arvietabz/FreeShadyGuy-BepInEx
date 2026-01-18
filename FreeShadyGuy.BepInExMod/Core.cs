using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Assets.Scripts.Inventory__Items__Pickups.GoldAndMoney;

namespace FreeShadyGuy.BepInExMod;

[BepInPlugin("Slimaeus.FreeShadyGuy", "FreeShadyGuy", "1.0.1")]
public class Core : BasePlugin
{
    public override void Load()
    {
        Harmony.CreateAndPatchAll(typeof(MoneyUtilityPatches));
    }

    [HarmonyPatch(typeof(MoneyUtility))]
    internal static class MoneyUtilityPatches
    {
        [HarmonyPatch("GetItemPriceShadyGuy")]
        [HarmonyPrefix]
        private static bool GetItemPriceShadyGuy_Prefix(ref int __result)
        {
            __result = 0;
            return false;
        }
    }
}