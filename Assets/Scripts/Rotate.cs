using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float keyDelay = 1f;  
    private float timePassed = 0f;
    public float rotationFactor = 1f;
    void Update()
    {
        timePassed += Time.deltaTime;
        if (Input.GetKey("left") && timePassed >= keyDelay)
        {
            RotateCounterClockwise();
        }

        if (Input.GetKey("right") && timePassed >= keyDelay)
        {
            RotateClockwise();   
        }

    }   

    void RotateClockwise()
    {
        transform.Rotate(Vector3.forward * -rotationFactor);
    }
    void RotateCounterClockwise()
    {
        transform.Rotate(Vector3.forward * rotationFactor);
    }
}
