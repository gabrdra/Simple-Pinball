using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/Stats")]
public class Stats : ScriptableObject
{
    public int score;
    public int highScore;
    public int lives = 3;
}
