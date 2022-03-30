using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayToPlace : MonoBehaviour
{
    
    public Camera PlacementCamera;
    public GameObject PlacementObject;

    public LayerMask Mask; // declare a public layer mask to ignore a layer
    
    
    // Update is called once per frame
    void Update()
    {
        Ray ray = PlacementCamera.ScreenPointToRay(Input.mousePosition);

        // have to declare as hit to know it will 
        RaycastHit hit;
        // Tell the raycast to ignore the layer
        // And give a range limit of 1000f
        bool didRayHit = Physics.Raycast(ray, out hit, 1000f, Mask);
        
        if (didRayHit)
        {
            PlacementObject.transform.position = hit.point;
            PlacementObject.transform.localRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            
            if(Input.GetMouseButtonDown(0)) // mouse down on 0 is left click
            {
                // Instantiate covers placing an object in the scene 
                // Makes prefab while the game is actually running
                GameObject go = Instantiate(PlacementObject, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                go.name = "New Object";
                go.layer = 0; // set to Default layer
            }
        }
    }
}
