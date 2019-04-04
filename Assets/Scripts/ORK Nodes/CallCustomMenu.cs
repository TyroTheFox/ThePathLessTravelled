using ORKFramework.Menu;
using System.Collections.Generic;
using UnityEngine;

namespace ORKFramework.Events.Steps
{
	//Calls a Custom External Menu Screen from the ORK Event System
	//ORK Editor tags to give information for the help panel
	[ORKEditorHelp("Call Custom Menu Screen", "Calls a menu screen.\n" +
	                                   "The event continues after the menu is closed.", "")]
   //Node Tags to place the node in the event menus
	[ORKEventStep(typeof(BaseEvent))]
	[ORKNodeInfo("UI/Menu", "Game/Menu")]
	public class CallCustomMenuScreenStep : BaseEventStep
	{
		//Node Options with Tags to explain what they do
		[ORKEditorHelp("Menu Screen", "Select the menu screen that will be called.", "")]
		public GameObject externalMenuObject;

		[ORKEditorHelp("Wait", "Wait for the menu screen to be closed before this event continues.\n" +
		                       "If disabled, the event will continue immediately.", "")]
		public bool wait = true;

		// user
		[ORKEditorHelp("Set User", "Use a defined combatant as the user of the menu screen.", "")]
		[ORKEditorInfo(separator = true, labelText = "Menu Screen User (Combatant)")]
		public bool setUser = false;

		[ORKEditorHelp("Select Combatant", "Calls the combatant selection menu before calling the menu screen.\n" +
		                                   "If disabled, a defined combatant will be used.", "")]
		[ORKEditorLayout("setUser", true)]
		public bool selectCombatant = false;

		[ORKEditorHelp("Can Cancel", "The combatant selection can be canceled.", "")]
		[ORKEditorLayout("selectCombatant", true)]
		public bool canCancelSelection = true;

		[ORKEditorHelp("Own Com. Selection", "Define a combatant selection that will be used.\n" +
		                                     "If disabled, the default combatant selection (menu user) will be used.",
			"")]
		[ORKEditorLayout(setDefault = true, defaultValue = false)]
		public bool ownSelection = false;

		[ORKEditorHelp("Combatant Selection", "Select the combatant selection that will be used.", "")]
		[ORKEditorInfo(ORKDataType.CombatantSelection)]
		[ORKEditorLayout("ownSelection", true, endCheckGroup = true, endGroups = 2)]
		public int selectionID = 0;

		[ORKEditorLayout(endCheckGroup = true, autoInit = true)]
		public EventObjectSetting userObject;

		// in-game
		private BaseEvent bEvent;

		public CallCustomMenuScreenStep()
		{

		}

		//Perform the code
		public override void Execute(BaseEvent baseEvent)
		{
			ORK.Menu.CloseAllMenus(false);
			//If there is a user set for this node
			if (this.setUser)
			{
				//Get the combatants of the event
				List<Combatant> list = this.userObject.GetCombatant(baseEvent);
				//For each combatant found
				for (int i = 0; i < list.Count; i++)
				{
					//They they're not null and not dead
					if (list[i] != null && (!list[i].Status.IsDead))
						//Call a menu screen for them
						this.CallMenuScreen(baseEvent, list[i]);
					break;	
				}
			}
			else
			{
				//Wait if needed or do nothing
				if (this.wait)
					return;
				baseEvent.StepFinished(this.next);
			}
		}

		private void CallMenuScreen(BaseEvent baseEvent, Combatant combatant)
		{
			//Final all ability menus
			var menusOpen = GameObject.FindGameObjectsWithTag("CustomMenu");
			//If there's none
			if (menusOpen.Length == 0)
			{
				//Create a menu screen handler
				MenuScreenHandler menuScreenHandler =
					UnityWrapper.Instantiate(externalMenuObject).GetComponent<MenuScreenHandler>();
				//Create ORK Menu Screen
				MenuScreen screen = ORK.MenuScreens.Get(8);
				//If the developer wants us to wait
				if (this.wait)
				{
					//Tell the base event what the next event is
					baseEvent.SetNextStep(this.next);
					//Update the screen with a combatant
					screen.Combatant = combatant;
					//If there's a menuScreenHandler object to work with
					if (menuScreenHandler != null)
					{
						//Set up menuscreen values
						menuScreenHandler.SetCombatant(combatant);
						menuScreenHandler.SetBaseEvent(baseEvent, this.next, screen);
						menuScreenHandler.order = 0;
					}
				}
				else
				{
					//If there's a menuScreenHandler object to work with
					if (menuScreenHandler != null)
					{
						//Set up menuscreen values
						menuScreenHandler.SetCombatant(combatant);
						menuScreenHandler.SetBaseEvent(baseEvent, this.next, screen);
						menuScreenHandler.order = 0;
                    }
				}
			}
			else
			{
				//get the first menu of the list
				MenuScreenHandler menu = menusOpen[0].GetComponent<MenuScreenHandler>();
				if (menu != null)
				{
					//Create ORK Menu Screen
					MenuScreen screen = ORK.MenuScreens.Get(8);
					//Update the screen with a combatant
					screen.Combatant = combatant;
					//If an ability menu is being called for a combatant that already has an ability menu created
					if (menu.GetCombatant().ID == combatant.ID)
					{
						//Increase number of ability decrease choices required before closing
						menu.addToChoiceNo();
					}
					else
					{
						//Create new menu screen handler
						MenuScreenHandler menuScreenHandler = 
							UnityWrapper.Instantiate(externalMenuObject).GetComponent<MenuScreenHandler>();
							//If the developer wants us to wait
						if (this.wait)
						{
							//Tell the base event what the next event is
							baseEvent.SetNextStep(this.next);
							//If there's a menuScreenHandler object to work with
							if (menuScreenHandler != null)
							{
								//Set up menuscreen values
								menuScreenHandler.SetCombatant(combatant);
								menuScreenHandler.SetBaseEvent(baseEvent, this.next, screen);
								//Update order number
								menuScreenHandler.order = menusOpen.Length;
							}
							
						}
						else
						{
							//If there's a menuScreenHandler object to work with
							if (menuScreenHandler != null)
							{
								//Set up menuscreen values
								menuScreenHandler.SetCombatant(combatant);
								menuScreenHandler.SetBaseEvent(baseEvent, this.next, screen);
								//Update order number
								menuScreenHandler.order = menusOpen.Length;
							}
							
						}
					}
				}
			}
		}

		/*
		============================================================================
		Node name functions
		============================================================================
		*/
		public override string GetNodeDetails()
		{
			//Returns node values for use in ORK.
			return "Custom Ability" +
			       (this.wait ? " (wait)" : "");
		}
	}
}