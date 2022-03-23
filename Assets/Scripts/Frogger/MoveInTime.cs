using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInTime : MonoBehaviour
{
    // the time in seconds that the object will take to move
    public float MovementTime = 1.0f;
    //the location that the object will move to
    public Vector3 TargetLocation;

    float totalTime = 0f;
    void Start()
    {
        // All variable manipulation is local to start
        totalTime = 0f;
    }

    void Update()
    {
        
        totalTime += Time.deltaTime;
        // Linear intERPolation = lerp
        if(totalTime >= MovementTime) totalTime = MovementTime;
        Vector3.Lerp(transform.position, TargetLocation, totalTime/MovementTime);
    }
}
