using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ORKFramework;
using ORKFramework.Events;
using ORKFramework.Events.Steps;
using ORKFramework.Menu;
using UnityEngine.UI;

//A handler for the Ability Menus

public class MenuScreenHandler : MonoBehaviour
{
	//Menu Object Prefab
    public GameObject menuObject;
	//Menu Button Object
    public GameObject menuButtonObject;
	//Toggle for an open menu
    public bool openMenu = false;
	//Number of ability levels that needs to be removed
    private int numberOfChoicesToBeMade = 1;
	//An object that populates it's game object with buttons to click
    public MenuButtonsPopulator menuButtonsPopulatorObject;
	//Character Combatant Object
    private ORKFramework.Combatant combatant;
	//Whether to update the button list on next update loop
    private bool updateList = true;
	//Number of ability levels to be removed
    public Text choiceCount;
	//Title of the menu
    public Text menuTitle;
	//Base ORK event object
    private BaseEvent baseEvent;
	//List of previous events that have been passed to this objects from other game menus
    private List<KeyValuePair<BaseEvent, int>> previousEvents;
	//Next Event Node ID
    private int next;
	//ORK Menu Screen Object
    private MenuScreen screen;
	//Order Number
    public int order;
    
    // Start is called before the first frame update
    void Start()
    {
		//Initialize list
        previousEvents = new List<KeyValuePair<BaseEvent, int>>();
		//If there's no combatant or menu object, do nothing
        if (combatant == null || menuObject == null){ return; }
		//Update title text
        menuTitle.text = "The actions of " + combatant.GetName() + " have taken their toll...";
    }

    // Update is called once per frame
    void Update()
    {
		//Update choice text
        choiceCount.text = numberOfChoicesToBeMade.ToString();
		//If needed components or objects are missing, do nothing
        if (combatant == null || menuObject == null || menuButtonObject == null || menuButtonsPopulatorObject == null) return;
        //If the list needs to be updated
		if (updateList)
        {
			//Update Populator with button Prefab
            menuButtonsPopulatorObject.buttons = menuButtonObject;
			//Get all combatant abilities that are both used in Battle and are passive
            var abilities = combatant.Abilities.GetAbilities(UseableIn.Battle, IncludeCheckType.No);
            abilities.AddRange(combatant.Abilities.GetAbilities(UseableIn.None, IncludeCheckType.No));
            foreach (var ability in abilities)
            {
				//For each ability, check that they're not a type 5 ability (an Equipment ability which is ignored)
                if(ability.TypeID != 5)
				//Add a button to the menu for each valid ability
                menuButtonsPopulatorObject.AddButton(ability, combatant);
            }
			//No need to update list anymore
            updateList = false;
        }
		//If there's no more buttons left in the menu
        if (menuButtonsPopulatorObject.transform.childCount == 0)
        {
			//Find all valid abilities the character has
            var abilities = combatant.Abilities.GetAbilities(UseableIn.Battle, IncludeCheckType.No);
            abilities.AddRange(combatant.Abilities.GetAbilities(UseableIn.None, IncludeCheckType.No));
            List<AbilityShortcut> checkedAbilities = new List<AbilityShortcut>();
            foreach (var ability in abilities)
            {
				//Make sure they're not Equipment Abilities
                if(ability.TypeID != 5)
                    checkedAbilities.Add(ability);
            }
			//Aslong as there's still abilities that are valid, update the menu
            if (checkedAbilities.Count > 0)
            {
                updateList = true;
            }
            else
            {
				//Otherwise, close the menu
                Close();
            }
        }
    }

    public void UpdateList()
    {
		//If there's no populator object, do nothing
        if (menuButtonsPopulatorObject == null) return;
		//Clear all of the buttons in the populator
        menuButtonsPopulatorObject.Clear();
		//Update the list with new buttons
        updateList = true;
    }

    public void SetBaseEvent(BaseEvent e, int next, MenuScreen s)
    {
		//Set the base event for the menu handler
        baseEvent = e;
        this.next = next;
        screen = s;
    }

    public void SetCombatant(ORKFramework.Combatant c)
    {
		//Set the combatant for the handler
        combatant = c;
    }

    public Combatant GetCombatant()
    {
		//Return the combatant
        return combatant;
    }

    public void Open()
    {
		//Display the menu
        menuObject.SetActive(true);
		//Tell ORK a menu screen is active
        screen.Show((IEventStarter) baseEvent);
    }
    
    public void Open(BaseEvent bE, int n)
    {
		//Display the menu
        menuObject.SetActive(true);
		//Update with a previous menu's event objects
        previousEvents.Add(new KeyValuePair<BaseEvent, int>(bE, n));
		//Tell ORK a menu screen has been displayed
        screen.Show((IEventStarter) baseEvent);
    }
    
    public void Open(BaseEvent bE, int n, List<KeyValuePair<BaseEvent, int>> pE)
    {
		//Activate the menu object
        menuObject.SetActive(true);
		//Add all previous events to this menu
        previousEvents.Add(new KeyValuePair<BaseEvent, int>(bE, n));
        foreach (var previousEvent in pE)
        {
            previousEvents.Add(previousEvent);
        }
		//Tell ORK a menu screen is being displayed
        screen.Show((IEventStarter) baseEvent);
    }

    public void Close()
    {
		//Stop displaying the menu object
        menuObject.SetActive(false);
		//Tag the object with something else to remove from search
        tag = "Untagged";
		//Check for other open menus
        var menusOpen = GameObject.FindGameObjectsWithTag("CustomMenu");
		//If no other menus are open
        if(menusOpen.Length == 0)
        {
			//if there's previous events from other menus
            if (previousEvents.Count > 0)
            {
                foreach (var previousEvent in previousEvents)
                {
                    //Finish every event
                    previousEvent.Key.StepFinished(previousEvent.Value);
                }
            }
            //Finish event step, moving on to the next one
            baseEvent.StepFinished(next);
        }
        else
        {
			//Find the next menu in the given order
            foreach (var menu in menusOpen)
            {
                MenuScreenHandler menuHandler = menu.GetComponent<MenuScreenHandler>();
                if (menuHandler.order == order + 1)
                {
                    //Open that menu and pass in each new event
                    menuHandler.Open(baseEvent, next, previousEvents);
                    break;
                }
            }
        }
		//Close and destory the menu object
        screen.Close();
        Destroy(gameObject);
    }

    public void choiceMade()
    {
		//Decreate the number of ability levels that need to be removed
        numberOfChoicesToBeMade--;
		//If there's no more required levels to be removed from abilities
        if (numberOfChoicesToBeMade == 0)
        {
			//Then close the menu
            Close();
        }
    }

	//Add to the number of ability levels that need to be removed from the combatant's abilities
    public void addToChoiceNo()
    {
        numberOfChoicesToBeMade++;
    }
}
