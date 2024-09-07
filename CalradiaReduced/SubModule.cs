using TaleWorlds.MountAndBlade;
using TaleWorlds.Library;
using TaleWorlds.CampaignSystem;
using TaleWorlds.ObjectSystem;
using HarmonyLib;
using TaleWorlds.CampaignSystem.Settlements;
using System.Reflection;
using System.Runtime.Serialization;

namespace CalradiaReduced
{

    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

            var harmony = new Harmony("bannerlord.calradiareduced");
            harmony.PatchAll();

        }
    }

}


