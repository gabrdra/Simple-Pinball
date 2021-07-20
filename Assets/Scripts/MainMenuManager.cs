using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public GameObject howToPlayPanel;
    private bool howToPlayPanelStatus = false;
    public void StartButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void HowToPlayButton()
    {
        howToPlayPanelStatus = !(howToPlayPanelStatus);
        howToPlayPanel.SetActive(howToPlayPanelStatus);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}

