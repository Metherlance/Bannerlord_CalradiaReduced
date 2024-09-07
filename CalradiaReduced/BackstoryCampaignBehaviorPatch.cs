using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.LogEntries;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace CalradiaReduced
{

    [HarmonyPatch(typeof(BackstoryCampaignBehavior))]
    class BackstoryCampaignBehaviorPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("OnNewGameCreated")]
        static bool OnNewGameCreated()
        {

            //Hero heroObject3 = Game.Current.ObjectManager.GetObject<CharacterObject>("lord_4_1").HeroObject;
            //Hero heroObject4 = Game.Current.ObjectManager.GetObject<CharacterObject>("lord_4_16").HeroObject;
            //Hero wrongedLord = heroObject4;
            //LogEntry.AddLogEntry((LogEntry)new OverruleInfluenceLogEntry(heroObject3, wrongedLord), CampaignTime.Years(1080f) + CampaignTime.Weeks(4f) + CampaignTime.Days(2f));
            //Settlement settlement = Game.Current.ObjectManager.GetObject<Settlement>("town_V6");
            //LogEntry.AddLogEntry((LogEntry)new SettlementClaimedLogEntry(heroObject4, settlement), CampaignTime.Years(1080f) + CampaignTime.Weeks(4f) + CampaignTime.Days(2f));
            //ClaimSettlementAction.Apply(heroObject4, settlement);

            //Hero heroObject1 = Game.Current.ObjectManager.GetObject<CharacterObject>("lord_1_7").HeroObject;
            //Hero heroObject2 = Game.Current.ObjectManager.GetObject<CharacterObject>("lord_1_1").HeroObject;
            //LogEntry.AddLogEntry((LogEntry)new CharacterInsultedLogEntry(heroObject1, heroObject2, (CharacterObject)null, ActionNotes.ValorStrategyQuarrel), CampaignTime.Years(1075f) + CampaignTime.Weeks(3f) + CampaignTime.Days(2f));
            //ChangeRelationAction.ApplyRelationChangeBetweenHeroes(heroObject1, heroObject2, -50, false);

            //Hero heroObject5 = Game.Current.ObjectManager.GetObject<CharacterObject>("lord_2_1").HeroObject;
            //Hero heroObject6 = Game.Current.ObjectManager.GetObject<CharacterObject>("dead_lord_2_2").HeroObject;
            //LogEntry.AddLogEntry((LogEntry)new CharacterKilledLogEntry(heroObject6, heroObject5, KillCharacterAction.KillCharacterActionDetail.Murdered), CampaignTime.Years(1080f) + CampaignTime.Weeks(4f) + CampaignTime.Days(2f));
            //if (!heroObject6.Clan.IsMapFaction && heroObject6.Clan.Leader != null)
            //    ChangeRelationAction.ApplyRelationChangeBetweenHeroes(heroObject5, heroObject6.Clan.Leader, -75, false);
            //Hero heroObject7 = Game.Current.ObjectManager.GetObject<CharacterObject>("lord_3_5").HeroObject;
            //Hero nimr = Game.Current.ObjectManager.GetObject<CharacterObject>("dead_lord_3_1").HeroObject;
            //LogEntry.AddLogEntry((LogEntry)new CharacterKilledLogEntry(nimr, heroObject7, KillCharacterAction.KillCharacterActionDetail.Murdered), CampaignTime.Years(1080f) + CampaignTime.Weeks(4f) + CampaignTime.Days(2f));
            //foreach (Hero hero in (List<Hero>)nimr.Clan.Heroes)
            //{
            //    if (hero.IsLord && (double)hero.Age < 35.0 && !hero.IsFemale && hero.GetTraitLevel(DefaultTraits.Mercy) < 1)
            //        LogEntry.AddLogEntry((LogEntry)new CharacterInsultedLogEntry(hero, heroObject7, nimr.CharacterObject, ActionNotes.VengeanceQuarrel), CampaignTime.Years(1080f) + CampaignTime.Weeks(4f) + CampaignTime.Days(2f));
            //}
            //// ISSUE: method pointer
            //foreach (Hero insultee in Hero.DeadOrDisabledHeroes.Where<Hero>(h=> sameClan(h,nimr)))
            //{
            //            if (insultee.IsLord && (double)insultee.Age < 35.0 && !insultee.IsFemale && insultee.GetTraitLevel(DefaultTraits.Mercy) < 1)
            //                LogEntry.AddLogEntry((LogEntry)new CharacterInsultedLogEntry(insultee, heroObject7, nimr.CharacterObject, ActionNotes.VengeanceQuarrel), CampaignTime.Years(1080f) + CampaignTime.Weeks(4f) + CampaignTime.Days(2f));
            //}
            //if (nimr.Clan.Leader == null)
            //{
            //    return false;
            //}
            //ChangeRelationAction.ApplyRelationChangeBetweenHeroes(heroObject7, nimr.Clan.Leader, -75, false);
            return false;
        }

        static bool sameClan(Hero h1, Hero h2)
        {
            return h1.Clan == h2.Clan;
        }

    }


}
