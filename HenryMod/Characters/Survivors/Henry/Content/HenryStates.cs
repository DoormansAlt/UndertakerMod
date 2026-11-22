using UndertakerMod.Survivors.Undertaker.SkillStates;

namespace UndertakerMod.Survivors.Undertaker
{
    public static class UndertakerStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Shoot));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}
