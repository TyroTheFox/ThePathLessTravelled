using UnityEngine;
using ORKFramework;
using System.Collections.Generic;

namespace ORKFramework.Events.Steps
{
    [ORKEditorHelp("Collect Custom Battle Gains",
        "Collect the battle gains (loot, experience) and optionally display the gains and level up texts.", "")]
    [ORKEventStep(typeof(BaseEvent))]
    [ORKNodeInfo("Battle/Gains")]

    public class CollectCustomBattleGains : BaseEventStep
    {
        [ORKEditorHelp("Wait", "Wait for the battle gains dialogue to be closed (if displayed).", "")]
        public bool wait = true;
        
        public CollectBattleGainsSettings collectGains = new CollectBattleGainsSettings();
        
        List<Tuple<BattleGainsTextType, Combatant, string>> endTexts = new List<Tuple<BattleGainsTextType, Combatant, string>>();

        string moneyText = "";
        string itemText = "";
        string expText = "";
        string normalSVText = "";
        int[] totalMoney = new int[ORK.Currencies.Count];
     
        public CollectCustomBattleGains()
        {

        }
        
        public override void SetData(DataObject data)
        {
            base.SetData(data);

            if(data.Contains<bool>("display"))
            {
                data.Get("display", ref this.collectGains.display);
                data.Get("autoClose", ref this.collectGains.autoClose);
                data.Get("closeTime", ref this.collectGains.closeTime);
                data.Get("blockAccept", ref this.collectGains.blockAccept);
            }
        }
        
        public override void Execute(BaseEvent baseEvent)
        {
            if(ORK.Battle.HasGains())
            {
                ORK.Battle.CollectGainsAndNegativeExperience(
                    collectGains.collectLoot,
                    collectGains.collectExp, collectGains.display,
                    collectGains.autoClose ? collectGains.closeTime : -1,
                    collectGains.autoClose ? collectGains.blockAccept : false,
                    collectGains.useItemBox, collectGains.useAddType,
                    collectGains.useItemBox ? collectGains.itemBoxID.GetValue() : "",
                    baseEvent, this.next);

                if(!this.collectGains.display || !this.wait)
                {
                    baseEvent.StepFinished(this.next);
                }
            }
            else
            {
                baseEvent.StepFinished(this.next);
            }
        }
        
        /*
============================================================================
Node next functions
============================================================================
*/
        public override string GetNodeDetails()
        {
            return this.wait ? "Wait" : "";
        }
    }

}