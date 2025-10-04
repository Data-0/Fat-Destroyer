using HarmonyLib;
using Il2Cpp;
using Il2CppSystem.Buffers;
using Il2CppTLD.IntBackedUnit;
using MelonLoader;
using SharpArrows;

namespace FatDestroyer
{

    public class DespawnFat : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg(System.ConsoleColor.White, "Fat Destroyer Started");
            Settings.instance.AddToModSettings("Fat Destroyer");
        }

        [HarmonyPatch(typeof(GearItem), nameof(GearItem.Deserialize))]
        public class GearItem_Awake
        {
            public static void Postfix(ref GearItem __instance)
            {
                if (__instance == null) return;
                if (string.IsNullOrWhiteSpace(__instance.name)) return;

                float hp = __instance.GetNormalizedCondition() * 100;
                float limit = Settings.instance.minAmount;

                if ( __instance.name.StartsWith("GEAR_AnimalFat") && hp<=limit)
                {    
                                          
                    Melon<DespawnFat>.Logger.Msg("Despawned RUINED GEAR_AnimalFat");
                    GameManager.DestroyObject(__instance);
                    
                }


            }
        }
    }

}
