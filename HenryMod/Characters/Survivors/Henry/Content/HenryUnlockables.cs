using UndertakerMod.Survivors.Undertaker.Achievements;
using RoR2;
using UnityEngine;

namespace UndertakerMod.Survivors.Undertaker
{
    public static class UndertakerUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                UndertakerMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(UndertakerMasteryAchievement.identifier),
                UndertakerSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
