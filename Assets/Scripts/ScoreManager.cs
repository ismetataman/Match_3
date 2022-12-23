using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    public Image scoreBar;
    private Board board;
    void Start()
    {
        board = FindObjectOfType<Board>();
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        if (board != null && scoreBar != null)
        {
            int lenght = board.scoreGoals.Length;
            scoreBar.fillAmount = (float)score / (float)board.scoreGoals[lenght -1];
        }
    }
}
