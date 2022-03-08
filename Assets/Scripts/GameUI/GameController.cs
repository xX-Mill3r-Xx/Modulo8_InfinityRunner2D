using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public GameObject gameOverPannel;
    public static GameController instance;


    void Start()
    {
        instance = this;
        Time.timeScale = 1f;
    }



    public void ShowGameOver()
    {
        gameOverPannel.SetActive(true);
        Time.timeScale = 0.5f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
