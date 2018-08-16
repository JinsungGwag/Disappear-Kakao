using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCtrl : MonoBehaviour {

    public Popup pop;

    public void button_clicked()
    {
        
        // If overlap image is exist
        if(GameObject.Find("OverlapImage") != null)
            GameObject.Find("OverlapImage").SetActive(false);

        // If gold text is exist
        if (GameObject.Find("GoldText") != null)
            GameObject.Find("GoldText").SetActive(false);

        pop.window_close();
        
        GameObject.Find("BackGround").GetComponent<CanvasGroup>().alpha = 1f;
        GameObject.Find("BackGround").GetComponent<CanvasGroup>().interactable = true;
    }

}
