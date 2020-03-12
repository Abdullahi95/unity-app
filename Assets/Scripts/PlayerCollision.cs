using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update

    public PlayerMovement Player;
    public GameManager GameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Player.enabled = false;
            GameManager.EndGame();
            
        }
    }






}

