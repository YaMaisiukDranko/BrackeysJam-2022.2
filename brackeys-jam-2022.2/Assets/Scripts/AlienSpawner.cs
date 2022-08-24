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

    private void Update()
    {
        SpawnAlien();
    }

    void SpawnAlien()
    {
        int randPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(alien, spawnPoints[randPoint].position, transform.rotation);
    }
}

