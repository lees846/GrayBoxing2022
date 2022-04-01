using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    AudioSource myAudioSource;

    // public Vector3 door
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            myAudioSource.Play();

            // when triggered, rotate the door from the hinge
            transform.Rotate(0, 0, -90);

        }
    }

}