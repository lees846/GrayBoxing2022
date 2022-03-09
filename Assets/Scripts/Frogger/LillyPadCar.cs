using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LillyPadCar : MonoBehaviour
{
    private Vector3 _startingPosition;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        _startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime converts values into units per second
        // So we can use Speed to determine how fast the car movs in units per second
        // while using the Vector3/left to choose the direction of the car
       transform.Translate(Vector3.left * speed * Time.deltaTime); 

       // Loop to the original pisition if we pass the side of teh road
       if(transform.position.x < 1.6f){
           transform.position = _startingPosition;
       }
    }
}
