using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuButtons : MonoBehaviour
{
    public Text ScoreFinal;
    public Text HS;
    private void Start()
    {

        if (SceneManager.GetActiveScene().name == "WinMenu" || 
            SceneManager.GetActiveScene().name == "LostMenu")
            ScoreFinal.text = ScoreController.finalScore;
        if (SceneManager.GetActiveScene().name == "MainMenu")
            HS.text = ScoreController.HS;

    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Bye!");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
