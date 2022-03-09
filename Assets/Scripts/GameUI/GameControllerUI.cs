using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerUI : MonoBehaviour
{
    private PlayerLife player;

    public int score;
    public Text ScoreText;

    public int scorePoints;
    public Text TextPoints;

    public static GameControllerUI instance;

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
