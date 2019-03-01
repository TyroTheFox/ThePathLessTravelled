using System.Collections;
using System.Collections.Generic;
using ORKFramework;
using UnityEngine;

public class MenuButtonsPopulator : MonoBehaviour
{
    public GameObject buttons;
    public MenuScreenHandler handler;

    public void AddButton(AbilityShortcut ability, Combatant combatant)
    {
        AbilityMenuButton menuButton = Instantiate(buttons, transform).GetComponent<AbilityMenuButton>();
        if (menuButton != null)
        {
            menuButton.SetUp(ability, combatant);
        }
    }

    public void Clear()
    {
        foreach (Transform child in transform) {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void ChoiceMade()
    {
        handler.choiceMade();
    }
}
