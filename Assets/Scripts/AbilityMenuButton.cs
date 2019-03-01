using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ORKFramework;

[RequireComponent (typeof(Button))]
public class AbilityMenuButton : FlexibleUI
{
    private Button button;
    private ORKFramework.Combatant combatant;
    private ORKFramework.AbilityShortcut ability;

    public Text nameText;

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

    protected override void OnSkinUI()
    {
        base.OnSkinUI();
        button.colors = flexibleUIData.buttonColorBlock;
    }

    public void ButtonPressed()
    {
        if (ability.Level != 1)
        {
            Debug.Log("BEFORE: " + ability.Level);
            ability.Level--;
            Debug.Log("AFTER: " + ability.Level);
            transform.parent.GetComponent<MenuButtonsPopulator>().ChoiceMade();
        }
        else
        {
            combatant.Abilities.Forget(ability.ID, true, true);
            var parent = transform.parent;
            parent.GetComponent<MenuButtonsPopulator>().ChoiceMade();
            parent.GetComponent<MenuButtonsPopulator>().Clear();
        }
    }

}
