using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inven_Tema : MonoBehaviour {

    public Image[] temaImage;

    public Sprite noTema;
    public Sprite yesTema;

    public Inven_Manager invenMananger;

	// Use this for initialization
	void Start () {

        for(int i = 0; i < 7; i++)
        {
            temaImage[i] = transform.GetChild(i).GetComponent<Image>();//차일드에 있는 이미지를 갖고온다
        }

        temaImage[0].sprite = yesTema; //0번은 무조건 테마가 있다는 건가
        for(int i = 1; i < 7; i++)
        {
            temaImage[i].sprite = noTema;//나머지는 잠겨있는 테마
        }

        invenMananger = GetComponent<Inven_Manager>();

    }

    // Select tema
    public void selectTema(int num)
    {

        for (int i = 0; i < 7; i++)
        {
            if (i == num)
                temaImage[i].sprite = yesTema;
            else
                temaImage[i].sprite = noTema;
        }

        switch(num)
        {
            case 0:
                invenMananger.showInventory("Friend");
                break;

            case 1:
                invenMananger.showInventory("Emotion");
                break;

            case 2:
                invenMananger.showInventory("Thing");
                break;

            case 3:
                invenMananger.showInventory("Food");
                break;

            case 4:
                invenMananger.showInventory("Cloth");
                break;

            case 5:
                invenMananger.showInventory("Natural");
                break;

            case 6:
                invenMananger.showInventory("Behavior");
                break;

            default:
                break;
        }

    }
    
}
