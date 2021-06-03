using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team5 : MonoBehaviour
{
    public GameObject PlayerV;

    //when team5 button is pushed assigns the tag "team5"
    public void ButtonToggle()
    {
        PlayerV.tag = "Team5";
    }
}
