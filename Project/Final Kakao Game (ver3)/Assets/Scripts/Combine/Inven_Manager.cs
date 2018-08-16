using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inven_Manager : Inven
{

    public List<string> items;
    public Image[] objs;
    public Item_Manager[] its;
    public GameObject nextBtn;
    public GameObject prevBtn;
    
    // Game Start
    void Start()
    {
        
        // Load first tema
        items = getFriend();

        // Load child objects
        for(int i = 8; i < 17; i++)
        {
            objs[i - 8] = transform.GetChild(i).GetComponent<Image>();
            its[i - 8] = transform.GetChild(i).gameObject.GetComponent<Item_Manager>();
        }

        prevBtn = transform.GetChild(17).gameObject;
        nextBtn = transform.GetChild(18).gameObject;
        
        // Load inventory
        showInventory("Friend");

    }

    public void showInventory(string temaName)
    {

        // Get tema items
        switch (temaName)
        {
            case "Friend":
                items = getFriend();
                break;

            case "Emotion":
                items = getEmotion();
                break;

            case "Thing":
                items = getThing();
                break;

            case "Food":
                items = getFood();
                break;

            case "Cloth":
                items = getCloth();
                break;

            case "Natural":
                items = getNatural();
                break;

            case "Behavior":
                items = getBehavior();
                break;

            default:
                break;
        }

        // Check items' count
        if (items.Count > 9)
        {
            nextBtn.SetActive(true);
            prevBtn.SetActive(false);

            for (int i = 0; i < 9; i++)
            {
                objs[i].gameObject.SetActive(true);
                objs[i].sprite = Resources.Load<Sprite>("Sprites/" + items[i]);
                its[i].itemName = items[i];
            }
        }
        else
        {
            nextBtn.SetActive(false);
            prevBtn.SetActive(false);

            for (int i = 0; i < items.Count; i++)
            {
                objs[i].gameObject.SetActive(true);
                objs[i].sprite = Resources.Load < Sprite>("Sprites/" + items[i]);
                its[i].itemName = items[i];
            }
            for(int i = items.Count; i < 9; i++)
            {
                objs[i].gameObject.SetActive(false);
            }
        }
    
    }

    // Click next list
    public void showNext()
    {
        for(int i = 9; i < items.Count; i++)
        {
            objs[i - 9].gameObject.SetActive(true);
            objs[i - 9].sprite = Resources.Load<Sprite>("Sprites/" + items[i]);
            its[i - 9].itemName = items[i];
        }
        for(int i = items.Count; i < 18; i++)
        {
            objs[i - 9].gameObject.SetActive(false);
        }

        nextBtn.SetActive(false);
        prevBtn.SetActive(true);
    }

    // Click previous list
    public void showPrevious()
    {
        for (int i = 0; i < 9; i++)
        {
            objs[i].gameObject.SetActive(true);
            objs[i].sprite = Resources.Load<Sprite>("Sprites/" + items[i]);
            its[i].itemName = items[i];
        }

        nextBtn.SetActive(true);
        prevBtn.SetActive(false);
    }

}