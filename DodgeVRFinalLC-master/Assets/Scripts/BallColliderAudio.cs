using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColliderAudio : MonoBehaviour
{
    public GameObject Ball;
    public AudioSource ballBounce;

    //this plays the bounce sound on collision with anything
    void OnCollisionEnter(Collision collision)
    {
        ballBounce.Play();
    }

}
