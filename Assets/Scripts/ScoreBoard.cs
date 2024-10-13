using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public Image medal;
    public Sprite[] medals;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public GameObject scoreBoard;

    public void ShowScoreBoard(int score)
    {
        scoreBoard.SetActive(true);
        scoreBoard.text = score.ToString("D4");

        medal.sprite = medals[Random.Range(0, medals.Lenght)];
    }
}
