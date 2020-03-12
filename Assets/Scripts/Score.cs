using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;


    void FixedUpdate()
    {
        //scoreText.text = player.position.z.ToString("0");
        float score = (player.position.z / 5);
        scoreText.text = score.ToString("0");   // formats score to be whole values.
    }
}
