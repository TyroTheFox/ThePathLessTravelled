using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ORKFramework;

public class MenuScreenHandler : MonoBehaviour
{
    public GameObject menuObject;
    public GameObject menuButtonObject;
    public bool openMenu = false;

    private int numberOfChoicesToBeMade = 1;

    public MenuButtonsPopulator menuButtonsPopulatorObject;

    private ORKFramework.Combatant combatant;

    private bool updateList = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!menuObject){ return; }
        openMenu = menuObject.activeSelf;
    }

    // Update is called once per frame
    void Update()
    {
        if (combatant == null || menuObject == null || menuButtonObject == null || menuButtonsPopulatorObject == null) return;
        if (updateList)
        {
            menuButtonsPopulatorObject.buttons = menuButtonObject;
            var abilities = combatant.Abilities.GetAbilities(UseableIn.Both, IncludeCheckType.No);
            foreach (var ability in abilities)
            {
                menuButtonsPopulatorObject.AddButton(ability, combatant);
            }
            updateList = false;
        }

        if (menuButtonsPopulatorObject.transform.childCount == 0)
        {
            var abilities = combatant.Abilities.GetAbilities(UseableIn.Both, IncludeCheckType.No);
            if (abilities.Count > 0)
            {
                updateList = true;
            }
        }
    }

    public void UpdateList()
    {
        if (menuButtonsPopulatorObject == null) return;
        menuButtonsPopulatorObject.Clear();
        updateList = true;
    }

    public void SetCombatant(ORKFramework.Combatant c)
    {
        combatant = c;
    }

    public void Open()
    {
        menuObject.SetActive(true);
    }

    public void Close()
    {
        menuObject.SetActive(false);
    }

    public void choiceMade()
    {
        numberOfChoicesToBeMade--;
        if (numberOfChoicesToBeMade == 0)
        {
            
        }
    }
}
