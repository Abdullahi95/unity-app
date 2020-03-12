using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool GameHasEnded = false;
    public float restartDelay = 0.5f;
    public GameObject LevelCompleteUI;
    public PlayerMovement PlayerMovement;
    public GameObject PauseMenuUI;
    
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
           
            Debug.Log("Game Has Ended");
            GameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    
    public void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
        PlayerMovement.enabled = false;
        
        if (SceneManager.GetActiveScene().buildIndex + 1 < 4)
        {
            Invoke("LoadNextLevel", 2f);
        }

    }


    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
