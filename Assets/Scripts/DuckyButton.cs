using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] // adds audio component 
public class DuckyButton : MonoBehaviour
{
    public AudioSource DuckSound; // the annoying duck sound
    void Awake()
    {
        DuckSound = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        if (DuckSound.isPlaying)
        {
            return; // Exit if we are already playing sound
        }
        DuckSound.Play();
    }
}
