using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public void
    OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Spawned"))
        {
            Destroy(other.gameObject);
        }
    }
}