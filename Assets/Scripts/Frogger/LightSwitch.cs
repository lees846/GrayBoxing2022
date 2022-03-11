using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        // start with the light off
        myLight.enabled = false;
    }

    void OnTriggerEnter(Collider other) {
        // The code to turn the light on and off
        if(other.gameObject.CompareTag("Player")){
            FlipLightSwitch();
        }
    }
    // Aa function to turn the light off and on
    void FlipLightSwitch(){
        // Use ! to switch between booleans on/off for the light
        myLight.enabled = !myLight.enabled;

        // You can also directly set intensity
        // myLight.intensity = myLight.intensity == 0 ? 1 : 0;
    }
}
