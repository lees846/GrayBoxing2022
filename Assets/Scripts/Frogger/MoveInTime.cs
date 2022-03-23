using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInTime : MonoBehaviour
{
    // the time in seconds that the object will take to move
    public float MovementTime = 1.0f;
    //the location that the object will move to
    private Vector3 TargetLocation;
    //the Target that we will move towards
    public GameObject Target;
    // keeps track of ellapsed time
    float totalTime = 0f;

    public Vector3 StartingPosition;
    void Start()
    {
        // All variable manipulation is local to start
        // Making sure the counter starts at 0
        totalTime = 0f;
        // Set StartingPostion to the Transform's current position
        StartingPosition = transform.position;
        // Set TagetLocation to the Target's position
        TargetLocation = Target.transform.position;
    }

    void Update()
    {
        // counts up from 0 each time Update is run
        totalTime += Time.deltaTime;
        // Linear intERPolation = lerp
        if(totalTime >= MovementTime) totalTime = MovementTime;
        UpdateTargetLocation();
        // totalTime = Mathf.Clamp01(totalTime/MovementTime);
        transform.position = Vector3.Lerp(StartingPosition, TargetLocation, totalTime/MovementTime);
        
    }

    void UpdateTargetLocation()
    {
        // Set TargetLocation to the Target's position
        TargetLocation = Target.transform.position;
    }
}
