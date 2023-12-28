using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle; //this varable contains the obstacle that we want to spawn
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    //we need these 4 variables because we want our obstacles to spawn within the maximum and minimum range for each axis
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {

        if(Time.time > spawnTime) //if the time passed > spawn time 
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX); //we dont want our obstacle to spawn the same position
        float randomY = Random.Range(minY, maxY);


        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }





}
