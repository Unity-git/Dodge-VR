using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject PlayerV;
    public GameObject Team1Spawn;
    public GameObject Team2Spawn;
    public GameObject Team3Spawn;
    public GameObject Team4Spawn;
    public GameObject Team5Spawn;
    public GameObject Team6Spawn;
    public void ButoonToggle()
    {
        //when the ready up button is pushed the player is teleported to team1 or team2 side depending on which tag they have
        if (PlayerV.tag != "Team1")
        {
            PlayerV.transform.position = Team1Spawn.transform.position;
        }
        if (PlayerV.tag != "Team2")
        {
            PlayerV.transform.position = Team2Spawn.transform.position;
        }
        if (PlayerV.tag != "Team3")
        {
            PlayerV.transform.position = Team3Spawn.transform.position;
        }
        if (PlayerV.tag != "Team4")
        {
            PlayerV.transform.position = Team4Spawn.transform.position;
        }
        if (PlayerV.tag != "Team5")
        {
            PlayerV.transform.position = Team5Spawn.transform.position;
        }
        if (PlayerV.tag != "Team6")
        {
            PlayerV.transform.position = Team6Spawn.transform.position;
        }

    }
}
