using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    //public Transform rotataion;

    void Update()
    {
        this.transform.Rotate(new Vector3(0,0,0.5f));
    }
}
