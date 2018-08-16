using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackMain : MonoBehaviour {

    public Button backButton;

    void Start()
    {
        Button bButton = backButton.GetComponent<Button>();
        bButton.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
