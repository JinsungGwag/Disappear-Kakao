using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : Good {

    public Image m_Item;
    public Text m_Nick;
    public Text m_Explanation;
    public Button m_Button;

    private GameObject GoldText;

    public void Start () {
        
        m_Item = GameObject.Find("Item_Image").GetComponent<Image>();
        m_Nick = transform.Find("Name").GetComponent<Text>();
        m_Explanation = GameObject.Find("Explanation").GetComponent<Text>();
        m_Button = GameObject.Find("Button").GetComponent<Button>();

        GoldText = (GameObject.Find("GoldText") != null) ? GameObject.Find("GoldText") : null;
        if(GoldText != null)
            GoldText.SetActive(false);
    
        initiate();

    }

    public void window_open(string name, string explain)
    {
        m_Nick.text = name;
        m_Item.sprite = Resources.Load<Sprite>("Sprites/" + name);
        m_Explanation.text = explain;
        gameObject.SetActive(true);
    }

    // Use in combine scene
    public void window_open(string name, string explain, GameObject OverlapImage)
    {
        m_Nick.text = name;
        m_Item.sprite = Resources.Load<Sprite>("Sprites/" + name);
        m_Explanation.text = explain;
        OverlapImage.SetActive(true);
        gameObject.SetActive(true); 
    }

    // Use in combine scene (when element is new)
    public void window_open(string name, string explain, int gold)
    {
        m_Nick.text = name;
        m_Item.sprite = Resources.Load<Sprite>("Sprites/" + name);
        m_Explanation.text = explain;
        saveMoney(gold);
        GoldText.GetComponent<Text>().text = "+" + gold + " GOLD";
        GoldText.SetActive(true);
        gameObject.SetActive(true);
    }

    public void window_close()
    {
        m_Nick.text = null;
        m_Item.sprite = null;
        m_Explanation.text = null;
        gameObject.SetActive(false);
    }

}
 