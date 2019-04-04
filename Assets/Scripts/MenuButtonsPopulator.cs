using System.Collections;
using System.Collections.Generic;
using ORKFramework;
using UnityEngine;

//Populates and handles menu buttons

public class MenuButtonsPopulator : MonoBehaviour
{
	//Button prefab objects
    public GameObject buttons;
	//Menu Screen Handler Object that manages the button menus
    public MenuScreenHandler handler;

    public void AddButton(AbilityShortcut ability, Combatant combatant)
    {
		//Instantiate a button and get it's AbilityMenuButton component
        AbilityMenuButton menuButton = Instantiate(buttons, transform).GetComponent<AbilityMenuButton>();
        //If there is one
		if (menuButton != null)
        {
			//Set up values
            menuButton.SetUp(ability, combatant);
        }
    }

    public void Clear()
    {
		//For every child attached to this transform
        foreach (Transform child in transform) {
			//Destroy it
            GameObject.Destroy(child.gameObject);
        }
    }

    public void ChoiceMade()
    {
		//Update the handler object that a choice has been made
        handler.choiceMade();
    }
}
