using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : Good
{
    public static string strTime;
    public static int ticket = 0;
    public static double startTime = -1;

    private const int DELAY = 1200;
    private static bool isLoad = false;

    void Start()
    {
        
        // If not data load
        if(!isLoad)
        {
            initiate();
            startTime = (getTime() - DateTime.Now).TotalSeconds;
            isLoad = true;
        }

	}

	void Update()
    {

        if (ticket == 1) return;

        double T = Time.time - startTime;
        int delta = DELAY - (int)(Math.Floor(T));

        if (delta <= 0)
        {
            ticket += -delta / DELAY + 1;
            delta = DELAY - (-delta % DELAY);

            startTime = Time.time - (DELAY - delta);
        }
        
        int minutes = delta / 60;
        int seconds = delta % 60;
        
        strTime = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

}