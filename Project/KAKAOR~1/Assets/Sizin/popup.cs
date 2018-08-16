using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popup : MonoBehaviour {

    GameObject m_Window;
    Image m_Item;
    Text m_Name;
    Text m_Explanation;
    Button m_Button;

	void Start () {
        m_Window = GameObject.Find("Window");
        m_Item = GameObject.Find("Item_Image").GetComponent<Image>();
        m_Name = GameObject.Find("Name").GetComponent<Text>();
        m_Explanation = GameObject.Find("Explanation").GetComponent<Text>();
        m_Button = GameObject.Find("Button").GetComponent<Button>();
        m_Window.SetActive(false);
        window_open("apple", "delicious");
    }

    // Update is called once per frame
    void Update () {
	    
	}

    void window_open(string name, string explain)
    {
        m_Name.text = name;
        m_Item.sprite = Resources.Load<Sprite>(name);
        m_Explanation.text = explain;
        m_Window.SetActive(true);
    }

    public void window_close()
    {
        m_Name.text = null;
        m_Item.sprite = null;
        m_Explanation.text = null;
        m_Window.SetActive(false);
    }
}
