using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    float score;
    public void IncreaseScore(float amount)
    {
        score += amount;
        UpdateScoreDisplay();
    }
    public void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}
