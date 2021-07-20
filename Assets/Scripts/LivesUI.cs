using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LivesUI : MonoBehaviour
{
    public Stats stats;
    public Text livesText;
    void Update()
    {
        livesText.text = "Lives: " + stats.lives;
    }
}
