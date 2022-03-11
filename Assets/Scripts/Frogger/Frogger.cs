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
        // print($"Collision with {other.gameObject.name}");
        // reset position if we collide with the wall
        if (other.gameObject.name == "Wall" || other.gameObject.CompareTag("Obstacle"))
        {
            transform.position = _startingPosition;
        } 

        if (other.gameObject.CompareTag("Checkpoint"))
        {
            _startingPosition = other.transform.position;

            // 1. Get the volume by name
            // 2. Reference its Game Object that's attached to the collision
            // 3. Use GetComponent<>() to access the LightSwitch script
            // 4. USe the LightSwitch script's myLight variable to change the light color
            // other.gameObject.GetComponent<LightSwitch>().myLight.color = Color.blue;
      
            // Can also make a new script and apply to light

            // Another way that references the light directly
            // volume.gameObject.GetComponent<Light>().color = Color.green;
        }
    }


}
