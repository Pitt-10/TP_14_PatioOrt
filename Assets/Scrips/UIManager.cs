using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public GameObject YouWin;
    public GameObject GameOver;

    public void Start()
    {
        YouWin.SetActive(false);
        GameOver.SetActive(false);
    }

    public void GameOverPanel()
    {
        GameOver.SetActive(true);
    }

    public void YouWinPanel()
    {
        YouWin.SetActive(true);
    }

    public void UpdateScore (int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimer(float time)
    {
        int seconds = Mathf.CeilToInt(time);

        timerText.text = "00:" + seconds.ToString("00");
    }
}
