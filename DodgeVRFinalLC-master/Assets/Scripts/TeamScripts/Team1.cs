using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team1 : MonoBehaviour
{

    public GameObject PlayerV;
    
    //when the "team1" button is pressed the game will assign a tag
    public void ButtonToggle()
    {
        PlayerV.tag = "Team1";
    }
}
