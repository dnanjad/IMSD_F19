using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeVelocity : MonoBehaviour
{
    float speedup = 10;
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
        MoveTheCubeTowardCamera();
        if (Input.GetKey(KeyCode.Space))
        {
            speedup = 100;
        }
        else
        {
            speedup = 10;
        }
    }

    void MoveTheCubeTowardCamera()
    {
        transform.position += Vector3.back * Time.deltaTime * speedup;
        transform.Rotate(0, 0, 700 * Time.deltaTime);
    }
}