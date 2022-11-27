using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingToFollow : MonoBehaviour
{
    public GameObject objectToFollow;

    void Update()
    {
        this.transform.position = objectToFollow.transform.position + new Vector3(0,5,-7);   
    }
}
