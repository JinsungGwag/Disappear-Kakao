using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : Good
{
    public Button currentBtn;
    public Text statusTxt;
    public GameObject resultWindow;
    public Popup pop;
    public CanvasGroup backgroundGroup;
    public GameObject popupWindow;
    public RandomDraw randomDraw;
    
	void Start ()
    {

        resultWindow.SetActive(false);
        currentBtn = GetComponent<Button>();
        statusTxt = GetComponentInChildren<Text>();
        backgroundGroup = GameObject.Find("BackGround").GetComponent<CanvasGroup>();

	}

	void Update ()
    {
        if (Timer.ticket >= 1) //무료 티켓이 있을 경우,
        {
            statusTxt.text = "무료 뽑기";
            
            currentBtn.onClick.RemoveListener(openPopupWindow);
            currentBtn.onClick.AddListener(GetGacha);
        }

        else if (Timer.ticket == 0) // 조건문에 '&& 보유 골드량 < 필요 골드량' 추가 필요 
        {
            statusTxt.text = Timer.strTime + " 후 무료 뽑기";

            currentBtn.onClick.RemoveListener(GetGacha);
            currentBtn.onClick.AddListener(openPopupWindow);
        }
    }

    // Open gacha window
    void GetGacha()
    {

        // Set data setting first
        initiate();
            
        if (Timer.ticket >= 1)
        {
            RandomDraw.ItemExplain drawItem = randomDraw.RandomDrawItem();

            resultWindow.SetActive(true);
            pop.window_open(drawItem.Name, drawItem.Explain);
            Timer.ticket = 0;

            // Set time data in bin file
            saveTime(DateTime.Now);

            // Set timer's start time
            Timer.startTime = Time.time;
        }
        
    }

    // Open popup window
    void openPopupWindow()
    {

        // Set background false
        backgroundGroup.alpha = 0.4f;
        backgroundGroup.interactable = false;
        
        popupWindow.SetActive(true);

    }

}
