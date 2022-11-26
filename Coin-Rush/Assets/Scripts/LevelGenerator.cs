using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour
{
    public GameObject roadPrefab;
    public GameObject player;
    public List<GameObject> roadPrefabs;

    public Vector3 spawnPoint;
    public bool canSpawn;
    
    private void Start()
    {
        spawnPoint = Vector3.zero;
        roadPrefab = roadPrefabs[0];
        InstantiateFirstGround();
    }

    private void Update()
    {
        CalculateTheDisance();
        
        if(canSpawn)
            SpawnandDestroyGrounds();
        
    }

    private void InstantiateFirstGround()
    {
        GameObject temp = Instantiate(roadPrefab, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(0).transform.position;
        Destroy(temp, 10);
    }

    private void CalculateTheDisance()
    {
        canSpawn = Math.Abs(player.transform.position.z - spawnPoint.z) <= 50f;
    }
    private void SpawnandDestroyGrounds()
    {
        roadPrefab = roadPrefabs[Random.Range(0, 3)];
        GameObject temp = Instantiate(roadPrefab, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(0).transform.position;
        Destroy(temp, 10);

    }
}
