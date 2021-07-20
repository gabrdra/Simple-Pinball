using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{
    public Stats stats;
    public Text scoreText;
    private void Start()
    {
        for(int i = stats.highScores.Length-1; i > 0; i--)
        {
            if(stats.highScores[i] > stats.highScores[i - 1])
            {
                (stats.highScores[i], stats.highScores[i - 1]) = (stats.highScores[i - 1], stats.highScores[i]);
            }
        }
        scoreText.text = "Score: " + stats.score + "\n \n";
        for (int i = 0; i < stats.highScores.Length-1; i++)
        {
            scoreText.text += (i+1) + " Score: " + stats.highScores[i] + "\n";
        }
    }
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
