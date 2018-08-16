using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setMute : MonoBehaviour
{
    public Button muteButton;
    public AudioSource music;
    public Sprite muteImage;
    public Sprite soundImage;

    private static bool isMute = false;

	void Start ()
    {
        music = GameObject.Find("MusicManager").GetComponent<AudioSource>();
        muteButton = GetComponent<Button>();
        muteButton.GetComponent<Image>().sprite = isMute ? muteImage : soundImage;
        muteButton.onClick.AddListener(TaskOnClick);
	}

    void TaskOnClick()
    {
        if(!isMute)
        {
            music.volume = 0;
            isMute = true;
            muteButton.GetComponent<Image>().sprite = muteImage;
        }

        else
        {
            music.volume = 1;
            isMute = false;
            muteButton.GetComponent<Image>().sprite = soundImage;
        }
    }
}
