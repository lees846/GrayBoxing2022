using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    // public Vector3 transformation = new Vector3(0, 1, 0);
    public float amplitude = 2f;
    public float frequency = 0.03f;
    public float offset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(
            transform.localPosition.x,
            amplitude * Mathf.Sin(Time.frameCount * frequency + offset) + 2f,
            transform.localPosition.z
        );
    }
}
