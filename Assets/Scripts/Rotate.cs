﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float keyDelay = 1f;  
    private float timePassed = 0f;
    public float rotationFactor = 1f;
    // POGGERS
    void Update()
    {
        timePassed += Time.deltaTime;
        if (Input.GetKey("left") && timePassed >= keyDelay)
        {
            RotateClockwise();
        }

        if (Input.GetKey("right") && timePassed >= keyDelay)
        {
            RotateCounterClockwise();   
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
