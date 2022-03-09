using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    public float SteppingSize = 1f;
    private Vector3 _startingPosition;
    // Start is called before the first frame update
    void Start()
    {
         _startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W))
       {
        //    print("W key was pressed");
        //    Debug.Log("W key was pressed");
           transform.Translate(Vector3.forward * SteppingSize);
       }
       if(Input.GetKeyDown(KeyCode.S))
       {
           transform.Translate(Vector3.back * SteppingSize);
       }

       if(Input.GetKeyDown(KeyCode.A)){
           transform.Translate(Vector3.left * SteppingSize);
       }
       if(Input.GetKeyDown(KeyCode.D)){
           transform.Translate(Vector3.right * SteppingSize);
       }

    }
    private void OnTriggerEnter(Collider other)
    {
        // reset position if we collide with the wall
        if (other.gameObject.name == "Wall" || other.gameObject.name == "Lilypads" || other.gameObject.name == "Lilypads 1" || other.gameObject.name == "Lilypads 2" || other.gameObject.name == "Lilypads 3")
        {
            transform.position = _startingPosition;
        } 
    }
}
