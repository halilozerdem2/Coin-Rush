using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollision : MonoBehaviour
{
    public bool isHit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
            isHit= true;
    }
}
