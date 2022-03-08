using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public int health = 3;
    public int heartsCount;
    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite empHeart;

    void Update()
    {
        for(int i = 0; i< hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = empHeart;
            }

            if (i < heartsCount)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
