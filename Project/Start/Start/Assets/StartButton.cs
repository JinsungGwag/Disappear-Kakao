using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Button startButton;

    void Start ()
    {
        Button sButton = startButton.GetComponent<Button>();
        sButton.onClick.AddListener(TaskOnClick);
	}
	
	void Update ()
    {
		
	}

    void TaskOnClick()
    {
        SceneManager.LoadScene("Temp");
    }
}
