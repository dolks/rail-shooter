using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{

    int score = 0;
    TMP_Text scoreText = null;

    private void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        if (scoreText)
        {
            scoreText.text = score.ToString();
        }
    }


    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }
}
