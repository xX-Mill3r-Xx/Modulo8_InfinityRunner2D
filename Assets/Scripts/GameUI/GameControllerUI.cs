using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerUI : MonoBehaviour
{
    public int score;
    public Text ScoreText;
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

}
