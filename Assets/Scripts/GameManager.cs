using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Stats stats;
    public GameObject ball;
    public Vector3 spawnPosition;
    public GameObject barrier;
    public GameObject launchingArea;
    void Start()
    {
        stats.score = 0;
        stats.lives = 3;
    }
    public void Death()
    {
        stats.lives--;
        if(stats.lives < 0)
        {
            if (stats.score > stats.highScore)
                stats.highScore = stats.score;
            Debug.Log("gameover");
        }
        ball.transform.position = spawnPosition;
        barrier.SetActive(false);
        launchingArea.SetActive(true);
    }
}
