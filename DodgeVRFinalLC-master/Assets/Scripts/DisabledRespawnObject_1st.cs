using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class DisabledRespawnObject_1st : MonoBehaviour
{
    private Interactable interactable;
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable.attachedToHand != null)
        {
            GameObject varGameObject = GameObject.Find("Ball");
            varGameObject.GetComponent<BallRespawn>().enabled = false;

        }
        else
        {
            GameObject varGameObject = GameObject.Find("Ball");
            varGameObject.GetComponent<BallRespawn>().enabled = true;
        }


    }
}
