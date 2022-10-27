using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private EndGameTrigger endGameTriggerScript;
    //public TextMeshPro scoreText;

    float score = 0;
    //sstring lost = "YOU LOST";
    public void IncreaseScore()
    {
        score += 1;
        UpdateScoreDisplay();
    }
    public void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;

        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            IncreaseScore();
        }
    }
    
}
