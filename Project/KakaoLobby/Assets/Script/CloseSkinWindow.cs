using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseSkinWindow : MonoBehaviour {

    public RectTransform rt;
    public Image[] imgs;

    public void Click()
    {
        rt.gameObject.SetActive(false);
        for(int i=0; i<imgs.Length; i++)
        {
            imgs[i].gameObject.SetActive(false);
        }
    }

    void Awake()
    {
        rt.gameObject.SetActive(false);
        for (int i = 0; i < imgs.Length; i++)
        {
            imgs[i].gameObject.SetActive(false);
        }
    }

}
