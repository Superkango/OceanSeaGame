using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefabObstacle;
    public GameObject PointCollider; 
    public float randomRange = 1.5f;
    public float repeatingTime = 0f; 
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 3f, repeatingTime);
           
    }

    void SpawnObstacle()
    {
        Vector3 spawnposition;
        spawnposition.x = Random.Range(randomRange, -randomRange);
        spawnposition.y = transform.position.y; //Random.Range(randomRange, -randomRange)
        spawnposition.z = transform.position.z;
        Instantiate(prefabObstacle, spawnposition, Quaternion.identity);
    }

}
