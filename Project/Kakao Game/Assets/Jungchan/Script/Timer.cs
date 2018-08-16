using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static string time;
    public static int ticket = 0;

    private const int DELAY = 10;
    private static float startTime = -1;

    void Start()
    {
        if (startTime == -1f)
        {
            startTime = Time.time;
        }
	}

	void Update()
    {
        if (ticket == 1) return;

        float T = Time.time - startTime;
        int delta = DELAY - (int)(Mathf.Floor(T));

        if (delta <= 0)
        {
            ticket += -delta / DELAY + 1;
            delta = DELAY - (-delta % DELAY);

            startTime = Time.time - (DELAY - delta);
        }
        
        int minutes = delta / 60;
        int seconds = delta % 60;
        
        time = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
