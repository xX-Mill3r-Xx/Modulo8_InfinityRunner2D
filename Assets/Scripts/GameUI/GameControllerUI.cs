using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerUI : MonoBehaviour
{
    private PlayerLife player;

    public static GameControllerUI instance;
    public Text ScoreText;
    public Text TextPoints;
    public int score;
    public int scorePoints;

    private void Awake()
    {
        instance = this;
        
        if(PlayerPrefs.GetInt("Moedas") > 0)
        {
            score += PlayerPrefs.GetInt("Moedas");
            scoreText.text = "x " + score.ToString();
        }
        
        if(PlayerPrefs.GetInt("Points") > 0)
        {
            scorePoints += PlayerPrefs.GetInt("Points");
            TextPoints.text = "x " + TextPoints.ToString();
        }
    }

    public void GetCoin()
    {
        score++;
        ScoreText.text = "x " + score.ToString();
        PlayerPrefs.SetInt("Moedas", score);
    }

    public void GetPoints()
    {
        scorePoints += 100;
        TextPoints.text = scorePoints.ToString();
        PlayerPrefs.SetInt("Points", scorePoints);
    }
}
