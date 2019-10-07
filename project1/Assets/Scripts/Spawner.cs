using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public float _timeBetweenSpawns = 5f;

    public GameObject Cube;

    BoxCollider spawncollider;
    Bounds _spawnBounds;
    float currentTimer = 0f;
    bool check;

    //intitialization
    void Start()
    {
        check = true;
        spawncollider = GetComponent<BoxCollider>();

        //if (spawncollider == null)
        //{
            //Debug.LogError("No Box Collider attached to game object.");
          //  check = false;
        //}
      //  else
        {
            _spawnBounds = spawncollider.bounds;
        }

    }



    void Update()
    {
        if (check)
        {
            currentTimer += Time.deltaTime;

            if (currentTimer >= _timeBetweenSpawns)
            {
                currentTimer = 0;

                float spawnX = Random.Range(-_spawnBounds.extents.x, _spawnBounds.extents.x);
                float spawnY = Random.Range(-_spawnBounds.extents.y, _spawnBounds.extents.y);
                float spawnZ = transform.position.z;

                //spawn object
                Instantiate(Cube, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
            }
        }
    }
}