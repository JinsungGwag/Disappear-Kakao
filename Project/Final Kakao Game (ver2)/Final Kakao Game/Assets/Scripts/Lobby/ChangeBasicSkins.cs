using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBasicSkins : Inven {

    public Image[] oldImage;
    public Image[] newImage;
    private List<string> fr = new List<string>();

    public void Click()
    {
        for(int i=0; i<7; i++)
        {
            oldImage[i].gameObject.SetActive(false);
            newImage[i].gameObject.SetActive(true);
        }
    }

    public void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            newImage[i].gameObject.SetActive(false);
        }
        fr = getFriend();
        for(int i=0; i<fr.Count; i++)
        {
            if(fr[i] == "어피치")
            {
                oldImage[0].gameObject.SetActive(false);
                newImage[0].gameObject.SetActive(true);
            }else if (fr[i] == "제이지")
            {
                oldImage[1].gameObject.SetActive(false);
                newImage[1].gameObject.SetActive(true);
            }else if(fr[i] == "콘")
            {
                oldImage[2].gameObject.SetActive(false);
                newImage[2].gameObject.SetActive(true);
            }
            else if (fr[i] == "튜브")
            {
                oldImage[3].gameObject.SetActive(false);
                newImage[3].gameObject.SetActive(true);
            }
            else if (fr[i] == "프로도")
            {
                oldImage[4].gameObject.SetActive(false);
                newImage[4].gameObject.SetActive(true);
            }
            else if (fr[i] == "네오")
            {
                oldImage[5].gameObject.SetActive(false);
                newImage[5].gameObject.SetActive(true);
            }
            else if (fr[i] == "무지")
            {
                oldImage[6].gameObject.SetActive(false);
                newImage[6].gameObject.SetActive(true);
            }
        }
    }
}
