using HarmonyLib;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.GoldAndMoney;
using MelonLoader;

[assembly: MelonInfo(typeof(FreeShadyGuy.MelonLoaderMod.Core), "FreeShadyGuy", "1.0.0", "Slimaeus", null)]
[assembly: MelonGame("Ved", "Megabonk")]

namespace FreeShadyGuy.MelonLoaderMod
{
    public class Core : MelonMod
    {
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
}