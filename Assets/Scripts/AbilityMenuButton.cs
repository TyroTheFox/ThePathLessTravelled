using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ORKFramework;

//Needs a button component to function
[RequireComponent (typeof(Button))]
public class AbilityMenuButton : FlexibleUI
{
	//Button component
    private Button button;
	//ORK Combatant Object
    private ORKFramework.Combatant combatant;
	//ORK Ability Object
    private ORKFramework.AbilityShortcut ability;
	//Name Text
    public Text nameText;
	
	//Initialize values
    public void SetUp(AbilityShortcut ability, Combatant combatant)
    {
        this.combatant = combatant;
        this.ability = ability;
        nameText.text = ability.GetName();
    }
	
    void Awake()
    {
        button = GetComponent<Button>();
        base.Initialize();
    }
	
	//If Skin changes, then update colour values
    protected override void OnSkinUI()
    {
        base.OnSkinUI();
        button.colors = flexibleUIData.buttonColorBlock;
    }

    public void ButtonPressed()
    {
		//If the ability level is not 1
        if (ability.Level != 1)
        {
			//Lower level
            ability.Level--;
			//Notify the button handler that a choice as been made
            transform.parent.GetComponent<MenuButtonsPopulator>().ChoiceMade();
        }
        else
        {
			//Make the combatant forget the ability
            combatant.Abilities.Forget(ability.ID, true, true);
            var parent = transform.parent;
			//Update the handler that a choice has been made and then force an update
            parent.GetComponent<MenuButtonsPopulator>().ChoiceMade();
            parent.GetComponent<MenuButtonsPopulator>().Clear();
        }
    }

}
