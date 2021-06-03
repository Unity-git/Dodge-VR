using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameEnd : MonoBehaviour
{
    public Text timerText;
    public static bool TimesUp = false;
    public float timeLeft = 3F;
    public float timeGap = 15;
    public AudioSource BlueWin;
    public AudioSource OrangeWin;

    void Start()
    {
        TimesUp = false;
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Team1").Length == 0)
        {

            //displays time countdown in units
            float t = timeLeft -= Time.deltaTime;
            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("00");
            string milliseconds = ((int)(t * 100f) % 100).ToString("00");

            timerText.text = minutes + ":" + seconds + ":" + milliseconds;
            //Removes the minute unit from the display time when all units drop to 0

            OrangeWin.Play();
            //when the time left is 0 it will quit out of the application
            if (timeLeft <= 0)
            {
                timeLeft += timeGap;
                timerText.text = minutes + ":" + seconds;
                TimesUp = true;

                Application.Quit();
            }

        }


        if (GameObject.FindGameObjectsWithTag("Team2").Length == 0)
        {

            //displays time countdown in units
            float t = timeLeft -= Time.deltaTime;
            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("00");
            string milliseconds = ((int)(t * 100f) % 100).ToString("00");

            timerText.text = minutes + ":" + seconds + ":" + milliseconds;
            //Removes the hour unit from the display time when all units drop to 0

            BlueWin.Play();
            
            //when the time left is 0 it will quit out of the application
            if (timeLeft <= 0)
            {
                timeLeft += timeGap;
                timerText.text = minutes + ":" + seconds;
                TimesUp = true;

                Application.Quit();
            }


        }
    }
}
