using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    // Start is called before the first frame update

    public GameManager GameManager;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            GameManager.LevelComplete();
        }
        
    }


  
}
