using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    public Button currentBtn;
    public Text statusTxt;

	void Start ()
    {
        currentBtn = GetComponent<Button>();
        statusTxt = GetComponentInChildren<Text>();
	}

	void Update ()
    {
        if (Timer.ticket == 1) //무료 티켓이 있을 경우,
        {
            statusTxt.text = "무료 뽑기";
            currentBtn.onClick.AddListener(GetGacha);
        }

        //else if (Timer.ticket == 0) // 조건문에 '&& 보유 골드량 >= 필요 골드량' 추가 필요
        //{
        //    GetComponent<Button>().interactable = true;
        //    GameObject.Find("Gacha").GetComponentInChildren<Text>().text = "골드 x개를 이용하여 뽑기 (보유 골드 수: y)"; //유료 재화로 뽑기, x: 필요량, y: 보유량
        //    gacha.onClick.AddListener(GetGacha);
        //}

        else if (Timer.ticket == 0) // 조건문에 '&& 보유 골드량 < 필요 골드량' 추가 필요 
        {
            statusTxt.text = Timer.time + " 무료 뽑기";
        }
    }

    void GetGacha() //함수 추가 필요
    {
        if (Timer.ticket == 1)
        {
            Timer.ticket--;
            //결과창 출력 후. return
        }

        //골드로 뽑을 때, 골드 감소 
        //결과창 출력 후, return
    }
}
