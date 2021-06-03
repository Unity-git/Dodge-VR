using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    
    public GameObject gameEndChecker;
    public AudioSource GameStart;

    //script is ran when the start game button is pressed in game
    public void ButtonToggle()
    {
        gameEndChecker.SetActive(true);

        GameStart.Play();
    }
}
