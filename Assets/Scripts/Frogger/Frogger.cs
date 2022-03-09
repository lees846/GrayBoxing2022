using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    public float SteppingSize = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W))
       {
           print("W key was pressed");
        //    Debug.Log("W key was pressed");
           transform.Translate(Vector3.forward * SteppingSize);
       }
    }
}
