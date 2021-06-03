using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team1 : MonoBehaviour
{

    public GameObject PlayerV;
    

    public void ButtonToggle()
    {
        PlayerV.tag = "Team1";
    }
}
