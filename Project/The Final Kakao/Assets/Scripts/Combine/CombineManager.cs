using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CombineManager : Inven {

    public GameObject ResultWindow;
    public Element[] Ele;
    public GameObject Thing1;
    public GameObject Thing2;
    public Popup PlusPopup;
    public GameObject OverlapImage;
    public Inven_Manager InvenManage;
    public Inven_Tema InvenThema;
    private string Name1; //Thing1에 들어간 이름을 저장
    private string Name2; //Thing2에 들어간 이름을 저장
    public CoinText CoinText;

    void Start()
    {

        Thing1 = GameObject.Find("Thing1");
        Thing2 = GameObject.Find("Thing2");

        ResultWindow = GameObject.Find("Window");
        PlusPopup = ResultWindow.GetComponent<Popup>();

        OverlapImage = GameObject.Find("OverlapImage");
        OverlapImage.SetActive(false);

        InvenManage = GameObject.Find("Inventory").GetComponent<Inven_Manager>();
        InvenThema = GameObject.Find("Inventory").GetComponent<Inven_Tema>();

        Ele = Resources.LoadAll<Element>("Elements/");

        ResultWindow.SetActive(false);
        
        CoinText = GameObject.Find("CoinText").GetComponent<CoinText>();

    }

    public void Combine()
    {
        // Update inven list
        Awake();
            
        Element Target;// 리스트에서 찾을 엘리먼트

        Name1 = Thing1.GetComponent<Thing>().thName;
        Name2 = Thing2.GetComponent<Thing>().thName;

        for(int i = 0; i < Ele.Length; i++)
        {

            //조합식이 존재할 경우
            if ((Ele[i].combinemember1 == Name1 && Ele[i].combinemember2 == Name2) || (Ele[i].combinemember2 == Name1 && Ele[i].combinemember1 == Name2))
            {
                Target = Ele[i];
                    
                List<string> temp = new List<string>();
                switch(Target.thema)
                {

                    case "Friend":
                        temp = getFriend();
                        break;

                    case "Emotion":
                        temp = getEmotion();
                        break;

                    case "Thing":
                        temp = getThing();
                        break;

                    case "Food":
                        temp = getFood();
                        break;

                    case "Cloth":
                        temp = getCloth();
                        break;

                    case "Natural":
                        temp = getNatural();
                        break;

                    case "Behavior":
                        temp = getBehavior();
                        break;

                    case "Skin":
                        temp = getSkin();
                        break;

                    default:
                        break;
                        
                }

                // If element is overlap
                for(int j = 0; j < temp.Count; j++)
                {
                    if(temp[j] == Target.name)
                    {
                        PlusPopup.window_open(Target.name, Target.description, OverlapImage);
                        return; 
                    }
                }

                // Element is new
                if (Target.thema == "Friend")
                    PlusPopup.window_open(Target.name, Target.description, 3);
                else
                    PlusPopup.window_open(Target.name, Target.description, 1);

                // Update coin window
                CoinText.ShowCoin();

                int ThemaNumber = 0;

                // Put element by thema
                switch (Target.thema)
                {

                    case "Friend":
                        ThemaNumber = 0;
                        putFriend(Target.name);
                        break;

                    case "Emotion":
                        ThemaNumber = 1;
                        putEmotion(Target.name);
                        break;

                    case "Thing":
                        ThemaNumber = 2;
                        putThing(Target.name);
                        break;

                    case "Food":
                        ThemaNumber = 3;
                        putFood(Target.name);
                        break;

                    case "Cloth":
                        ThemaNumber = 4;
                        putCloth(Target.name);
                        break;

                    case "Natural":
                        ThemaNumber = 5;
                        putNatural(Target.name);
                        break;

                    case "Behavior":
                        ThemaNumber = 6;
                        putBehavior(Target.name);
                        break;

                    case "Skin":
                        ThemaNumber = 0;
                        putSkin(Target.name);
                        break;

                    default:
                        break;

                }

                // Initiate inven management
                InvenManage.Awake();
                InvenThema.selectTema(ThemaNumber);
                return;
            }

        }
    }

    public void BackToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

}
