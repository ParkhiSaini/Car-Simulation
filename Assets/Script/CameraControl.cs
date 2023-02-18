using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target; // The target to follow (the car)
    public float rotationSpeed = 5.0f; // The speed at which the camera rotates

    public Vector3 offset=new Vector3(0,0,0); // The offset between the camera and the target

    void Start()
    {
         // Set the initial offset
    }

    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Get the horizontal input

        if (horizontal != 0)
        {
            // Rotate the camera around the target
            transform.RotateAround(target.position, Vector3.up, horizontal * rotationSpeed * Time.deltaTime);
        }

        transform.position = target.position + offset; // Set the camera position to be offset from the target
        transform.LookAt(target); // Make the camera look at the target
    }

}
