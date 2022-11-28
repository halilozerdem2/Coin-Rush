using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCoin : MonoBehaviour
{
    public GameObject player;
    public GameObject stackCoin;

    public float speed=25;

    public Vector3 targetPosition;
    public Vector3 currentPosition;
    public bool isTouched;

    private void Awake()
    {
        player = GameObject.Find("PlayerCoin");
        
    }
    void Update()
    {
        targetPosition = player.transform.position-new Vector3(0,0,2);
    }
    public void InstantiateStackCoin(Vector3 aPosition)
    {
        Instantiate(stackCoin,aPosition, Quaternion.identity);
    }
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 10, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        isTouched = true;
        
    }
    public Vector3 CalculateCoinSpawnPosition()
    {
        float zAxisVector = Random.Range(25, 100);
        float xAxisVector = Random.Range(-5, 5);

        return new Vector3(xAxisVector, 1, zAxisVector);
    }
    private void Follow()
    {

    }
}
