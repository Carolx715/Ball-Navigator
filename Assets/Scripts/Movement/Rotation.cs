using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float keyDelay = 1f;  
    private float timePassed = 0f;
    void Update()
    {
        // hello
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
        transform.Rotate(Vector3.forward * -1);
    }
    void RotateCounterClockwise()
    {
        transform.Rotate(Vector3.forward * 1);
    }
}
