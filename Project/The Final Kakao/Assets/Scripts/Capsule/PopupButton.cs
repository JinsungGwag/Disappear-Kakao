using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupButton : Good {

    public RandomDraw randomDraw;
    public CoinText coinText;

    void Start()
    {
        coinText = GameObject.Find("CoinText").GetComponent<CoinText>();    
    }

    // Close window function
    public void CloseWindow()
    {
        gameObject.SetActive(false);
        GameObject.Find("BackGround").GetComponent<CanvasGroup>().alpha = 1f;
        GameObject.Find("BackGround").GetComponent<CanvasGroup>().interactable = true;
    }

    // Open draw window and close pop-up window
    public void OpenDrawWindow(GameObject drawWindow)
    {
        // Set data setting first
        initiate();

        drawWindow.SetActive(true);
        gameObject.SetActive(false);

        RandomDraw.ItemExplain DrawItem = randomDraw.RandomDrawItem();
        drawWindow.GetComponent<Popup>().window_open(DrawItem.Name, DrawItem.Explain);

        // Update money data by using money
        useMoney();

        coinText.ShowCoin();
    }

}
