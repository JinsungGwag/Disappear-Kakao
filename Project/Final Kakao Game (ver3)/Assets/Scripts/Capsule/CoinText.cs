using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : Good
{

    Text CurrentCoin;

    void Start()
    {
        CurrentCoin = GetComponent<Text>();
        ShowCoin();
    }

    public void ShowCoin()
    {
        initiate();
        CurrentCoin.text = getMoney() + "";
    }

}