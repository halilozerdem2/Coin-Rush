using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeGravity : MonoBehaviour
{
    //public GameObject player;
    public Rigidbody axeRb;

    public GameObject player;

    private void Awake()
    {
        player = GameObject.Find("PlayerCoin");
    }
    
    private void Update()
    {
        if(Mathf.Abs(player.transform.position.z-this.transform.position.z)<=20f)
        {
            axeRb.isKinematic = false;
            axeRb.useGravity= true;
        }
    }

}
