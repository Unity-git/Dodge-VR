using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class DisabledUI : MonoBehaviour
{
    
    private Interactable interactable;
    private GameObject childObj ;
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
        childObj = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable.attachedToHand != null)
        {

            childObj.active = false;
        }
        else
        {
            childObj.active = true;
        }
    }
}
