using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.CampaignSystem.GameState;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using HarmonyLib;

using System.Linq;


namespace CalradiaReduced
{
    public static class StartingPositionPatch
    {
        [HarmonyPatch(typeof(SandboxCharacterCreationContent))]
        [HarmonyPatch("OnCharacterCreationFinalized")]
        public static class OnCharacterCreationFinalizedPatch
        {
            public static void Postfix()
            {
                CultureObject culture = CharacterObject.PlayerCharacter.Culture;

                // TODO look character creation for choose town or village
                var towns = Campaign.Current.Settlements.Where(s => (s.IsTown || s.IsVillage) && s.Culture == culture).ToList();
                
                // in case of no cultural settlements
                if (towns.IsEmpty())
                {
                    towns = Campaign.Current.Settlements.Where(s => (s.IsTown || s.IsVillage)).ToList();
                }

                towns.Shuffle();
                MobileParty.MainParty.Position2D = towns[0].GatePosition;

                if (!(GameStateManager.Current.ActiveState is MapState activeState))
                    return;
                activeState.Handler.ResetCamera(true, true);
                activeState.Handler.TeleportCameraToMainParty();
            }
        }
    }
}

