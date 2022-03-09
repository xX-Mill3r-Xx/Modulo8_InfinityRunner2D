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
    }

    public void GetCoin()
    {
        score++;
        ScoreText.text = "x " + score.ToString();
    }

    public void GetPoints()
    {
        scorePoints += 100;
        TextPoints.text = scorePoints.ToString();
    }
}
