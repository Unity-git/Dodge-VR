using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHit : MonoBehaviour
{
    public GameObject PlayerV;
    public GameObject Elimination;
    public AudioSource elimSound;

    void Start()
    {
        //finds the player prefab in game as well as the elimination controller
        PlayerV = GameObject.Find("Player");
        Elimination = GameObject.Find("EliminationController");
    }

    //on collision with tag ball the if statement runs which eliminates the player
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
             PlayerV.transform.position = Elimination.transform.position;
             if (PlayerV.transform.position == Elimination.transform.position)
            {
                //sets player tag to untagged as well as plays elim sound
                elimSound.Play();
                PlayerV.tag = "Untagged";
            }
        }
    }

}
