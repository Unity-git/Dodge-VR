using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTimer : MonoBehaviour
{
    public Text timerText;
    public static bool TimesUp = false;
    public float timeLeft = 3F;
    public float timeGap = 15;
    // Start is called before the first frame update
    void Start()
    {
        TimesUp = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        //displays time countdown in units
        float t = timeLeft -= Time.deltaTime;
        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
        string milliseconds = ((int)(t * 100f) % 100).ToString("00");

        timerText.text = minutes + ":" + seconds + ":" + milliseconds;
        //Removes the hour unit from the display time when all units drop to 0
        if (timeLeft <= 0)
        {
            timeLeft += timeGap;
                timerText.text = minutes + ":" + seconds;
            TimesUp = true;
        }

    }
}
