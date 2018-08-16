using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSkins : Inven {

    public RectTransform rt;
    public Image[] imgs;
    public Image basicImg;
    public string str;
    private List<string> st = new List<string>();
    private bool[] chk_skins = new bool[9];


	public void Click()
    {
        rt.gameObject.SetActive(true);
        st = getSkin();
        basicImg.gameObject.SetActive(true);

        for(int i=0; i<st.Count; i++)
        {
            if (st[i] == "TV보는 라이언")
                chk_skins[0] = true;
            else if (st[i] == "왕관을 든 라이언")
                chk_skins[1] = true;
            else if (st[i] == "술먹는 라이언")
                chk_skins[2] = true;
            else if (st[i] == "복숭아 코스프레 콘")
                chk_skins[3] = true;
            else if (st[i] == "라이언 코스프레 어피치")
                chk_skins[4] = true;
            else if (st[i] == "큐피트 코스프레 어피치")
                chk_skins[5] = true;
            else if (st[i] == "자신감 있는 제이지")
                chk_skins[6] = true;
            else if (st[i] == "화난 튜브")
                chk_skins[7] = true;
            else if (st[i] == "고독한 네오")
                chk_skins[8] = true;

        }

        if (str == "Ryan")
        {
            if (chk_skins[0])
                imgs[1].gameObject.SetActive(true);
            else
                imgs[0].gameObject.SetActive(true);

            if (chk_skins[1])
                imgs[3].gameObject.SetActive(true);
            else
                imgs[2].gameObject.SetActive(true);

            if (chk_skins[2])
                imgs[5].gameObject.SetActive(true);
            else
                imgs[4].gameObject.SetActive(true);
        }else if(str == "Con")
        {
            if (chk_skins[3])
                imgs[1].gameObject.SetActive(true);
            else
                imgs[0].gameObject.SetActive(true);
        }else if (str == "Apeach")
        {
            if (chk_skins[4])
                imgs[1].gameObject.SetActive(true);
            else
                imgs[0].gameObject.SetActive(true);

            if (chk_skins[5])
                imgs[3].gameObject.SetActive(true);
            else
                imgs[2].gameObject.SetActive(true);
        }else if (str == "JayG")
        {
            if (chk_skins[6])
                imgs[1].gameObject.SetActive(true);
            else
                imgs[0].gameObject.SetActive(true);
        }else if (str == "Tube")
        {
            if (chk_skins[7])
                imgs[1].gameObject.SetActive(true);
            else
                imgs[0].gameObject.SetActive(true);
        }
        else if (str == "Neo")
        {
            if (chk_skins[8])
                imgs[1].gameObject.SetActive(true);
            else
                imgs[0].gameObject.SetActive(true);
        }
    }

    public void Start()
    {
        putSkin("TV보는 라이언");
        st = getSkin();
        
        for(int i=0; i<9; i++)
        {
            chk_skins[i] = true;
        }
    }
}
