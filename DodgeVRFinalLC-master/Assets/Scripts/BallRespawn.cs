using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class BallRespawn : MonoBehaviour
{
    public Vector3 startPosition; 
    public GameObject ball;
    public Rigidbody rb;
    public RealtimeTransform rtTransform;

    public Transform child;
    public float timeLeft = 15F;
    public float timeGap = 15F;
    private bool isMoving = false;

    void Awake()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    
    void Update()
    {
        //keeps the child's rotation(the countdown timer in this case) stable while the parent's rotation is changing
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, gameObject.transform.rotation.z * -1.0f);
        //Ball is reset when the time remaining is zero
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            timeLeft += timeGap;
            transform.position = startPosition;
            rb.velocity = Vector3.zero;
            if (rb.velocity == Vector3.zero)
            {
                rb.Sleep();
            }
        }
        
    }
}
