using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour
{
    int i;
    public GameObject[] cubes;
    public GameObject audioManager;


    void Update()
    {
        
        for (i = 0; i < 4; i++)
        {
            //float cubes up and down
            cubes[i].transform.position = new Vector3(cubes[i].transform.position.x, Mathf.Sin(Time.time), 0);
        }

    //check if Space pressed
    IfSpacePlaySound();

    }

    void IfSpacePlaySound()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        //grab audio from another object
        AudioSource source = audioManager.GetComponent<AudioSource>();
        source.Play();
    }
}
}
