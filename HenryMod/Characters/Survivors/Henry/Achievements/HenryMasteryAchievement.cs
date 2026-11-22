using RoR2;
using UndertakerMod.Modules.Achievements;

namespace UndertakerMod.Survivors.Undertaker.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class UndertakerMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = UndertakerSurvivor.UNDERTAKER_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = UndertakerSurvivor.UNDERTAKER_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => UndertakerSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}