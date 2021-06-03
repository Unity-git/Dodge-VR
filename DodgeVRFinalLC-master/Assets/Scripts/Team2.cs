using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team2 : MonoBehaviour
{
    public GameObject PlayerV;

    //when team2 button is pushed assigns the tag "team2"
    public void ButtonToggle()
    {
        PlayerV.tag = "Team2";
    }
}
