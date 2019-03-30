using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ORKFramework;
using ORKFramework.Events;
using ORKFramework.Events.Steps;
using ORKFramework.Menu;
using UnityEngine.UI;

public class MenuScreenHandler : MonoBehaviour
{
    public GameObject menuObject;
    public GameObject menuButtonObject;
    public bool openMenu = false;

    private int numberOfChoicesToBeMade = 1;

    public MenuButtonsPopulator menuButtonsPopulatorObject;

    private ORKFramework.Combatant combatant;

    private bool updateList = true;

    public Text choiceCount;
    public Text menuTitle;
    private BaseEvent baseEvent;
    private List<KeyValuePair<BaseEvent, int>> previousEvents;
    private int next;
    private MenuScreen screen;

    public int order;
    
    // Start is called before the first frame update
    void Start()
    {
        previousEvents = new List<KeyValuePair<BaseEvent, int>>();
        if (combatant == null || menuObject == null){ return; }
        //openMenu = menuObject.activeSelf;
        menuTitle.text = "The actions of " + combatant.GetName() + " have taken their toll...";
    }

    // Update is called once per frame
    void Update()
    {
        choiceCount.text = numberOfChoicesToBeMade.ToString();
        if (combatant == null || menuObject == null || menuButtonObject == null || menuButtonsPopulatorObject == null) return;
        if (updateList)
        {
            menuButtonsPopulatorObject.buttons = menuButtonObject;
            var abilities = combatant.Abilities.GetAbilities(UseableIn.Battle, IncludeCheckType.No);
            abilities.AddRange(combatant.Abilities.GetAbilities(UseableIn.None, IncludeCheckType.No));
            foreach (var ability in abilities)
            {
                if(ability.TypeID != 5)
                menuButtonsPopulatorObject.AddButton(ability, combatant);
            }
            updateList = false;
        }

        if (menuButtonsPopulatorObject.transform.childCount == 0)
        {
            var abilities = combatant.Abilities.GetAbilities(UseableIn.Battle, IncludeCheckType.No);
            abilities.AddRange(combatant.Abilities.GetAbilities(UseableIn.None, IncludeCheckType.No));
            List<AbilityShortcut> checkedAbilities = new List<AbilityShortcut>();
            foreach (var ability in abilities)
            {
                if(ability.TypeID != 5)
                    checkedAbilities.Add(ability);
            }
            if (checkedAbilities.Count > 0)
            {
                updateList = true;
            }
            else
            {
                Close();
            }
        }
    }

    public void UpdateList()
    {
        if (menuButtonsPopulatorObject == null) return;
        menuButtonsPopulatorObject.Clear();
        updateList = true;
    }

    public void SetBaseEvent(BaseEvent e, int next, MenuScreen s)
    {
        baseEvent = e;
        this.next = next;
        screen = s;
    }

    public void SetCombatant(ORKFramework.Combatant c)
    {
        combatant = c;
    }

    public Combatant GetCombatant()
    {
        return combatant;
    }

    public void Open()
    {
        menuObject.SetActive(true);
        screen.Show((IEventStarter) baseEvent);
    }
    
    public void Open(BaseEvent bE, int n)
    {
        menuObject.SetActive(true);
        previousEvents.Add(new KeyValuePair<BaseEvent, int>(bE, n));
        screen.Show((IEventStarter) baseEvent);
    }
    
    public void Open(BaseEvent bE, int n, List<KeyValuePair<BaseEvent, int>> pE)
    {
        menuObject.SetActive(true);
        int i = 0;
        previousEvents.Add(new KeyValuePair<BaseEvent, int>(bE, n));
        foreach (var previousEvent in pE)
        {
            previousEvents.Add(previousEvent);
            i++;
        }
        screen.Show((IEventStarter) baseEvent);
    }

    public void Close()
    {
        menuObject.SetActive(false);
        tag = "Untagged";
        var menusOpen = GameObject.FindGameObjectsWithTag("CustomMenu");
        if(menusOpen.Length == 0)
        {
            if (previousEvents.Count > 0)
            {
                int i = 0;
                foreach (var previousEvent in previousEvents)
                {
                    Debug.Log("PREVIOUS EVENT CLOSE (NO MENUS): " + previousEvent.Key.nodeName);
                    previousEvent.Key.StepFinished(previousEvent.Value);
                    i++;
                }
            }
            Debug.Log("CLOSE EVENT (NO MENUS): " + baseEvent.GetNodeName());
            baseEvent.StepFinished(next);
        }
        else
        {
            foreach (var menu in menusOpen)
            {
                MenuScreenHandler menuHandler = menu.GetComponent<MenuScreenHandler>();
                if (menuHandler.order == order + 1)
                {
                    Debug.Log("PASS TO NEXT MENU: " + baseEvent.GetNodeName());
                    menuHandler.Open(baseEvent, next, previousEvents);
                    break;
                }
            }
        }
        screen.Close();
        Destroy(gameObject);
    }

    public void choiceMade()
    {
        numberOfChoicesToBeMade--;
        if (numberOfChoicesToBeMade == 0)
        {
            Close();
        }
    }

    public void addToChoiceNo()
    {
        numberOfChoicesToBeMade++;
    }
}
