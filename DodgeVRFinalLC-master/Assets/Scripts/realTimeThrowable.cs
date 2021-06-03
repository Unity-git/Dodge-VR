using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using Valve.VR.InteractionSystem;

public class realTimeThrowable : Throwable
{
    //calls the throwable script
    private RealtimeTransform rtTransform;
    // Start is called before the first frame update
    void Start()
    {
        rtTransform = GetComponent<RealtimeTransform>();
    }
    
    //when grabbed player gains ownership as long as no one else has control of it
    public void Grabbed()
    {
        rtTransform.RequestOwnership();
    }

    //referenced from Mikes rtThrowable script
    protected override void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();

        if (startingGrabType != GrabTypes.None && rtTransform.ownerIDSelf == -1)
        {
            hand.AttachObject(gameObject, startingGrabType, attachmentFlags, attachmentOffset);
            hand.HideGrabHint();
        }
    }
}

