using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Proximity Script:
* Determines
* Attach to an object/transform and specify 
* the object/transform to detect.
*/
public class Proximity : MonoBehaviour
{
    // Adaptive Fields
    [SerializeField] public Transform self = this.transform.position;
    [SerializeField] public Transform object_to_detect = null;
    [SerializeField] public float detect_distance = 5.0f;

    private Vector3 distance;

    // Logic:
    private void Start()
    {
        curr_distance = self.position - object_to_detect.position;
    }

    private void Update()
    {
        curr_distance = self.position - object_to_detect.position;
        if (curr_distance.magnitude <= detect_distance)
        {
            // implement checkout UI screen pop-up
        }
    }
}