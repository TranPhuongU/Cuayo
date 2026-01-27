using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private int score;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        currentScoreText.text = score.ToString();

        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            SoundManager.instance.PlayRandomSFX();
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
    }

    public void UpdateScore()
    {
        score++;
        SoundManager.instance.PlayRandomSFX();
        currentScoreText.text = score.ToString();
        UpdateHighScore();
    }
}
