﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform objectToSpawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnSelectedObject()
    {
        Instantiate(objectToSpawn, objectToSpawnLocation.position, Quaternion.identity);
    }
}
