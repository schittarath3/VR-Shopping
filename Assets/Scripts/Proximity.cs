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
    [SerializeField] public Transform self;
    [SerializeField] public Transform object_to_detect = null;
    [SerializeField] public float detect_distance = 5.0f;

    private Vector3 distance;

    // Logic:
    private void Start()
    {
        self = this.transform;
        distance = self.position - object_to_detect.position;
    }

    private void Update()
    {
        distance = self.position - object_to_detect.position;
        if (distance.magnitude <= detect_distance)
        {
            // implement checkout UI screen pop-up
        }
    }
}