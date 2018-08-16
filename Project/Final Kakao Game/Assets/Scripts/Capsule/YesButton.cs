using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesButton : Good {

    // Current numbers of coin
    int currentCoin = 0;
    
    void OnEnable()
    {
        // Set first setting
        initiate();

        // Get current coin from bin file
        currentCoin = getMoney();
        
        // If not enough coin
        if(currentCoin < 3)
        {
            // Set button's text and interactable
            GetComponentInChildren<Text>().text = "예(코인부족)";
            GetComponent<Button>().interactable = false;        
        }
        // Have enough coin
        else
        {
            // Set button's text and interactable
            GetComponentInChildren<Text>().text = "예";
            GetComponent<Button>().interactable = true;
        }

    }
   
}
