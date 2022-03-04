using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertHover : MonoBehaviour
{


    public float offset = 0f;
    public float amplitude = 5f; 
    // public Vector3 hover = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, Mathf.Sin(Time.frameCount * 0.2f) + offset, 0);
        transform.localPosition = 
            new Vector3(transform.localPosition.x, 
                amplitude * Mathf.Sin(Time.frameCount * 0.2f + offset), 
                transform.localPosition.z);
    }
}
