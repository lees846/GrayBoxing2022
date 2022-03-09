using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleBobbing : MonoBehaviour
{
    public float offset = 0f;
    public float amplitude = 0.5f;
    public float frequency = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition =
            new Vector3(transform.localPosition.x, 
            amplitude * Mathf.Sin(Time.frameCount * frequency + offset) + 1.2f,
            transform.localPosition.z);
    }
}
