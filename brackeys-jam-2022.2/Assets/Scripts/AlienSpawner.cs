using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AlienSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject alien;
    public float spawnTime;
    public float time;

    private void Start()
    {
        RestartTime();
    }

    void RestartTime()
    {
        time = spawnTime;
    }
    
    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            SpawnAlien();
            RestartTime();
        }
        else
        {
            
        }
    }

    void SpawnAlien()
    {
        int randPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(alien, spawnPoints[randPoint].position, transform.rotation);
    }
}

