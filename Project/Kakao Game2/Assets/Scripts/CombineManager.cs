using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombineManager : MonoBehaviour {

    public Image resultImage;
    public Element[] Ele;
    public GameObject Thing1;
    public GameObject Thing2;
    private string Name1; //Thing1에 들어간 이름을 저장
    private string Name2; //Thing2에 들어간 이름을 저장

    public void Combine()
    {
        Element target;// 리스트에서 찾을 엘리먼트

        Name1 = Thing1.GetComponent<Thing>().thName;
        Name2 = Thing2.GetComponent<Thing>().thName;

        Debug.Log(Name1);
        Debug.Log(Name2);

        for(int i=0;i<54;i++)
        {
            if((Ele[i].combinemember1==Name1 && Ele[i].combinemember2==Name2) || (Ele[i].combinemember2==Name1 && Ele[i].combinemember1==Name2))
            {//조합식이 존재할 경우
                target = Ele[i];
                Debug.Log(target);

                resultImage.gameObject.SetActive(true);//이미지 활성화
                resultImage.sprite = Ele[i].artwork; //이미지 넣어주고
                 //이름 넣는 건 어떻게 하더라  
            }
        }
    }

	void Start () {

        resultImage.gameObject.SetActive(false);//평소에는 이미지 꺼놓음

    }

}
