using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Rendering;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour
{
    public GameObject roadPrefab;
    public GameObject player;
    public List<GameObject> roadPrefabs;

    public Vector3 spawnPoint;
    public bool spawned;
    
    private void Awake()
    {
        player = GameObject.Find("PlayerCoin");
    }
    private void Start()
    {
        InstantiateFirstGround();
    }

    private void Update()
    {
        spawned = false;
        CalculateTheDistance();
        
        if(CanSpawn(CalculateTheDistance()))
            SpawnandDestroyGrounds();
    }

    private void InstantiateFirstGround()
    {
        roadPrefab = roadPrefabs[0];
        GameObject temp = Instantiate(roadPrefab, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(0).transform.position;
        spawned = true;

        Destroy(temp, 10);
    }

    private float CalculateTheDistance()
    {
        float distance = Math.Abs(player.transform.position.z - spawnPoint.z);
        return distance;

    }
    private bool CanSpawn(float aDistance)
    {
        if (aDistance < 30f && !spawned)
            return true;
        else
            return false;
    }
    private void SpawnandDestroyGrounds()
    {
        roadPrefab = roadPrefabs[Random.Range(0, 3)];
        GameObject temp = Instantiate(roadPrefab, spawnPoint, Quaternion.identity);
        spawnPoint = temp.transform.GetChild(0).transform.position;
        Destroy(temp, 10);

       

    }
}
