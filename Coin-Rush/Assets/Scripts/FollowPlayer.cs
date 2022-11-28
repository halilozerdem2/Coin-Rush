using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{/*
    public GameObject playerCoin;
    public StackCoin coin;

    public Vector3[] targetPositions;

    private void Awake()
    {
        coin= GetComponent<StackCoin>();
        targetPositions=new Vector3[30];
        playerCoin = GameObject.Find("PlayerCoin");

    }
    private void FixedUpdate()
    {
        if (coin.isTouched)
        {
            StartCoroutine(FollowingPlayer(targetPositions[0]));
        }
    }
    IEnumerator FollowingPlayer(Vector3 aTarget)
    {
        while (true)
        {
            coin.transform.position = 
                Vector3.MoveTowards(coin.transform.position, aTarget, 25);

            yield return null;
        }
    }
    private void Update()
    {
        AssignTargetPositions();
    }

    public void AssignTargetPositions()
    {
        targetPositions[0] = playerCoin.transform.position;
        
        for (int i = 1; i < targetPositions.Length; i++)
        {
            targetPositions[i]=playerCoin.transform.position+ new Vector3(0,0,i+2);
        }

    }*/
}
