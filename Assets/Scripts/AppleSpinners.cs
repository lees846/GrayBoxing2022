using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpinners : MonoBehaviour
{

    public Vector3 rotation = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation); 
    }
}
