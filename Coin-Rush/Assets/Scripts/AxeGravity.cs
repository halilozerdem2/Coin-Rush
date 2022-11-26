using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeGravity : MonoBehaviour
{
    //public GameObject player;
    public Rigidbody axeRb;
    public PlayerMovement player;
   
    
    private void Start()
    {
        axeRb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
       // if(Mathf.Abs(player.transform.position.z- this.transform.position.z)<=30f)

    }


}
