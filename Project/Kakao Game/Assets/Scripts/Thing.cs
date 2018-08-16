using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thing : MonoBehaviour {

    public string thName; 
    public Image thImage;
    public Text thText;

    public Transform LB;
    public Transform RT;
    
    void Awake()
    {

        thImage = transform.GetChild(0).GetComponent<Image>();
        thText = transform.GetChild(1).GetComponent<Text>();
        thName = "None";

    }

    // Use this for initialization
    void Start () {

        thImage.color = new Color(255, 255, 255, 0);
        thText.text = "";

	}
	
}
