using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public GameObject gameOverPannel;
    public GameObject gamePause;
    public static GameController instance;

    void Start()
    {
        instance = this;
        Time.timeScale = 1f;
    }

    public void ShowGameOver()
    {
        gameOverPannel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseMenu()
    {
        gamePause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void NoPauseMenu()
    {
        gamePause.SetActive(false);
        Time.timeScale = 1f;
    }
}
