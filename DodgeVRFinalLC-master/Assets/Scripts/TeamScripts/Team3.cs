using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team3 : MonoBehaviour
{

    public GameObject PlayerV;

    //when team3 button is pushed assigns the tag "team1"

    public void ButtonToggle()
    {
        PlayerV.tag = "Team3";
    }
}