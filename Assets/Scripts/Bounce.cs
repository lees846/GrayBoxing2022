using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    // public fields show up in the unity editor
    public float amplitude = 2f;
    public float frequency = 0.03f;
    public float offset = 0f;

    public float speed;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        // Vector3 direction = new Vector3(0, 1, 0);
        // transform.Translate(direction);

        // sets position exactly
        // transform.position = direction;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.localPosition = new Vector3(
        //     transform.localPosition.x,
        //     amplitude * Mathf.Sin(Time.frameCount * frequency + offset) + 2f,
        //     transform.localPosition.z
        // );

        Vector3 newPosition = new Vector3(transform.position.x,
        height * Mathf.Sin(speed * Time.frameCount + offset) + 5,
        transform.position.z);
        transform.position = newPosition;
    }
}
