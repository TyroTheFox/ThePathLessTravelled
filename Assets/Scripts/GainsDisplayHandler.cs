using System.Collections;
using System.Collections.Generic;
using ORKFramework;
using ORKFramework.Events;
using UnityEngine;
using UnityEngine.UI;

public class GainsDisplayHandler : MonoBehaviour
{
    public Text gainsText;
    public GameObject menuObject;
    private int position = 0;
    private List<Tuple<BattleGainsTextType, Combatant, string>> endTexts;
    private BaseEvent baseEvent;
    private int next;

    public void SetUp(List<Tuple<BattleGainsTextType, Combatant, string>> eT, BaseEvent e, int next)
    {
        endTexts = eT;
        baseEvent = e;
        this.next = next;
    }

    public void Open()
    {
        menuObject.SetActive(true);
        if (endTexts.Count > 0)
        {
            gainsText.text = endTexts[position].Item3;
        }
        else
        {
            Close();
        }
    }

    public void Close()
    {
        menuObject.SetActive(false);
        var menusOpen = GameObject.FindGameObjectsWithTag("CustomMenu");
        if(menusOpen.Length == 0)
        {
            baseEvent.StepFinished(next);
        }
        else
        {
            foreach (var menu in menusOpen)
            {
                MenuScreenHandler menuHandler = menu.GetComponent<MenuScreenHandler>();
                if (menuHandler.order == 0)
                {
                    menuHandler.Open(baseEvent, next);
                    break;
                }
            }
        }
        Destroy(gameObject);
    }

    public void Next()
    {
        position++;
        if (endTexts.Count > 0 && position < endTexts.Count)
        {
            gainsText.text = endTexts[position].Item3;
        }
        else
        {
            Close();
        }
    }
}
