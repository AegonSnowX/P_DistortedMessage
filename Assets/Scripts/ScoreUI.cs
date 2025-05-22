using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void OnEnable() //when ScoreUI is enabled, it subscribes to ScoreManager.Instance.OnScoreChanged
    {
        ScoreManager.Instance.OnScoreChanged += UpdateScore;
    }

    private void OnDisable()
    {
        ScoreManager.Instance.OnScoreChanged -= UpdateScore; 
    }

    private void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
