using System.Collections;
using System.Collections.Generic;
using ORKFramework;
using ORKFramework.Events;
using UnityEngine;
using UnityEngine.UI;

//Displays Gains from Battles

public class GainsDisplayHandler : MonoBehaviour
{
	//Displayed text for the battle's rewards
    public Text gainsText;
	//Menu Object
    public GameObject menuObject;
	//Position in the Battle End Messages
    private int position = 0;
	//Battle End Messages
    private List<Tuple<BattleGainsTextType, Combatant, string>> endTexts;
	//Base ORK Event
    private BaseEvent baseEvent;
	//Next event ID
    private int next;

	//Initialize values
    public void SetUp(List<Tuple<BattleGainsTextType, Combatant, string>> eT, BaseEvent e, int next)
    {
        endTexts = eT;
        baseEvent = e;
        this.next = next;
    }

    public void Open()
    {
		//Upon opening, show menu
        menuObject.SetActive(true);
		//If there's anything to display
        if (endTexts.Count > 0)
        {
			//Display each Battle End Message
            gainsText.text = endTexts[position].Item3;
        }
        else
        {
			//Otherwise close
            Close();
        }
    }

    public void Close()
    {
		//Close object
        menuObject.SetActive(false);
		//Find any objects with the tag 'CustomMenu'. These are ability menus waiting to be used
        var menusOpen = GameObject.FindGameObjectsWithTag("CustomMenu");
		//If there's no extra menus to display
        if(menusOpen.Length == 0)
        {
			//End the event and continue
            baseEvent.StepFinished(next);
        }
        else
        {
			//If there are menus to display, find every one of them and look for the one with the lowest 'order' number
            foreach (var menu in menusOpen)
            {
                MenuScreenHandler menuHandler = menu.GetComponent<MenuScreenHandler>();
                if (menuHandler.order == 0)
                {
					//The first menu in the list is opened and handed the event data from this object
                    menuHandler.Open(baseEvent, next);
                    break;
                }
            }
        }
		//Delete the object
        Destroy(gameObject);
    }

    public void Next()
    {
		//Advance to the next page in the Battle End Messages
        position++;
		//If there's any left yet to be displayed or any to display
        if (endTexts.Count > 0 && position < endTexts.Count)
        {
			//Write to the menu box
            gainsText.text = endTexts[position].Item3;
        }
        else
        {
			//Otherwise, close the menu
            Close();
        }
    }
}
