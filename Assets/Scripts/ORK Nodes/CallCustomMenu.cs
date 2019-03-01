using ORKFramework.Menu;
using System.Collections.Generic;
using UnityEngine;

namespace ORKFramework.Events.Steps
{
	[ORKEditorHelp("Call Custom Menu Screen", "Calls a menu screen.\n" +
	                                   "The event continues after the menu is closed.", "")]
	[ORKEventStep(typeof(BaseEvent))]
	[ORKNodeInfo("UI/Menu", "Game/Menu")]
	public class CallCustomMenuScreenStep : BaseEventStep
	{
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
		private BaseEvent baseEvent;

		public CallCustomMenuScreenStep()
		{

		}

		public override void Execute(BaseEvent baseEvent)
		{
			if (this.setUser)
			{
				List<Combatant> list = this.userObject.GetCombatant(baseEvent);

				for (int i = 0; i < list.Count; i++)
				{
					if (list[i] != null && (!list[i].Status.IsDead))
						this.CallMenuScreen(baseEvent, list[i]);
					break;	
				}
			}	
		}

		private void CallMenuScreen(BaseEvent baseEvent, Combatant combatant)
		{
			//TODO - too many menus spawning - have to limit down to just one per character leveling down
			var menusOpen = GameObject.FindGameObjectsWithTag("CustomMenu");
			if (menusOpen.Length == 0)
			{
				MenuScreenHandler menuScreenHandler =
					UnityWrapper.Instantiate(externalMenuObject).GetComponent<MenuScreenHandler>();
				if (this.wait)
				{
					baseEvent.SetNextStep(this.next);

					if (menuScreenHandler != null)
					{
						menuScreenHandler.SetCombatant(combatant);
						menuScreenHandler.Open();
					}
					//screen.Show(baseEvent);
				}
				else
				{

					if (menuScreenHandler != null)
					{
						menuScreenHandler.SetCombatant(combatant);
						menuScreenHandler.Open();
					}

					//screen.Show(null);
				}
			}
			else
			{
				
			}
		}

		/*
		============================================================================
		Node name functions
		============================================================================
		*/
		public override string GetNodeDetails()
		{
			return "Custom" +
			       (this.wait ? " (wait)" : "");
		}
	}
}