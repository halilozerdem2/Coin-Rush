using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public PlayerCollision player;

    public void Update()
    {
        if(player.isHit)
            SceneManager.LoadScene(0);
        
    }
}
