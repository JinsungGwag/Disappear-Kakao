using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item_Manager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public Vector3 startPosition;
    public GameObject Thing1;
    public GameObject Thing2;
    public RectTransform rectThing1;
    public RectTransform rectThing2;
    public Thing thingThing1;
    public Thing thingThing2;
    public RectTransform rectCurrent;
    public Image itemImage;
    public string itemName;
    public Vector3 clickPosition;

    private bool mouseDown;

    void Start()
    {
        mouseDown = false;

        // Save start position
        startPosition = transform.position;

        // Load things' gameobject
        Thing1 = GameObject.Find("Thing1");
        Thing2 = GameObject.Find("Thing2");

        // Save things' recttransform
        rectThing1 = Thing1.GetComponent<RectTransform>();
        rectThing2 = Thing2.GetComponent<RectTransform>();

        // Save things' thing script
        thingThing1 = Thing1.GetComponent<Thing>();
        thingThing2 = Thing2.GetComponent<Thing>();

        // Save item's rect information
        rectCurrent = GetComponent<RectTransform>();

        // Save item's item image
        itemImage = GetComponent<Image>();

    }

    void Update()
    {

        // If pointer is down
        if (mouseDown)
        {
            // Drag item
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                clickPosition = new Vector3(touch.position.x, touch.position.y, transform.position.z);
            }
            else
            {
                Vector3 mPosition = Input.mousePosition;
                clickPosition = new Vector3(mPosition.x, mPosition.y, transform.position.z);
            }
            transform.position = clickPosition;
        }

    }

    // If item click
    public void OnPointerDown(PointerEventData ped)
    {

        mouseDown = true;

    }

    // If pointer is up
    public void OnPointerUp(PointerEventData ped)
    {

        // If item is in thing1
        if (clickPosition.x > thingThing1.LB.position.x && clickPosition.x < thingThing1.RT.position.x &&
            clickPosition.y > thingThing1.LB.position.y && clickPosition.y < thingThing1.RT.position.y)
        {
            Debug.Log("Thing1!");
            thingThing1.thName = itemName;
            thingThing1.thText.text = itemName;
            thingThing1.thImage.sprite = itemImage.sprite;
            thingThing1.thImage.color = new Color(255, 255, 255, 1);
        }

        // If item is in thing2
        if (clickPosition.x > thingThing2.LB.position.x && clickPosition.x < thingThing2.RT.position.x &&
            clickPosition.y > thingThing2.LB.position.y && clickPosition.y < thingThing2.RT.position.y)
        {
            Debug.Log("Thing2!");
            thingThing2.thName = itemName;
            thingThing2.thText.text = itemName;
            thingThing2.thImage.sprite = itemImage.sprite;
            thingThing2.thImage.color = new Color(255, 255, 255, 1);
        }

        // Go to start position
        transform.position = startPosition;
        mouseDown = false;

    }

}
