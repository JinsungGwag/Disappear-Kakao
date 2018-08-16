using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public Button back_button;

    void Start()
    {
        Button Bbtn = back_button.GetComponent<Button>();
        Bbtn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Lobby");
    }
}
