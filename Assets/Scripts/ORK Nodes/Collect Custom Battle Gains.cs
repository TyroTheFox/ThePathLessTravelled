using UnityEngine;
using ORKFramework;
using System.Collections.Generic;

namespace ORKFramework.Events.Steps
{
	//ORK Tags for Help Box
    [ORKEditorHelp("Collect Custom Battle Gains",
        "Collect the battle gains (loot, experience) and optionally display the gains and level up texts.", "")]
		//ORK Event tags used for handling placement in menus
    [ORKEventStep(typeof(BaseEvent))]
    [ORKNodeInfo("Battle/Gains")]

    public class CollectCustomBattleGains : BaseEventStep
    {
		//Event options with tags to illustrate what they do
        [ORKEditorHelp("Wait", "Wait for the battle gains dialogue to be closed (if displayed).", "")]
        public bool wait = true;
        
        [ORKEditorHelp("Gains Screen", "Select the menu object that will be called to display gains.", "")]
        public GameObject externalMenuObject;
        
		//External node settings object
        private CollectBattleGainsSettings collectGains = new CollectBattleGainsSettings();
        //Battle End Messages
        List<Tuple<BattleGainsTextType, Combatant, string>> endTexts;
		//Report Strings for each aspect of the Battle End Messages
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
			//Set Event Data
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
			//If there's gains to report on
            if(ORK.Battle.HasGains())
            {
				//Collect gains and return all Battle End Messages
                endTexts = 
                    ORK.Battle.CollectGainsAndNegativeExperience(
                    collectGains.collectLoot,
                    collectGains.collectExp, false,
                    collectGains.autoClose ? collectGains.closeTime : -1,
                    collectGains.autoClose ? collectGains.blockAccept : false,
                    collectGains.useItemBox, collectGains.useAddType,
                    collectGains.useItemBox ? collectGains.itemBoxID.GetValue() : "",
                    baseEvent, this.next);
                //Create a gains display handler object
                GainsDisplayHandler gainsHandler =
                    UnityWrapper.Instantiate(externalMenuObject).GetComponent<GainsDisplayHandler>(); 
                //Set up values
                gainsHandler.SetUp(endTexts, baseEvent, this.next);
				//Display the menu
                gainsHandler.Open();
            }
            else
            {
				//Otherwise end event
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