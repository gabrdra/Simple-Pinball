using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/Stats")]
public class Stats : ScriptableObject
{
    public int score;
    public int[] highScores;
    public int lives = 3;
}
