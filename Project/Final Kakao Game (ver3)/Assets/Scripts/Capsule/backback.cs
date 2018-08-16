using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backback : MonoBehaviour
{
    public Button back_button;

    void Start()
    {
        Button Bbtn = back_button.GetComponent<Button>();
        Bbtn.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Capsule");
    }
}
