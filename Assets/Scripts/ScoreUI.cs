using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    public Stats stats;
    public Text scoreText;
    void Update()
    {
        scoreText.text = "Score: " + stats.score;
    }
}
