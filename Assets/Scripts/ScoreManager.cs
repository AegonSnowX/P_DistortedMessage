using System;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    public event Action<int> OnScoreChanged;

    private int score = 0;
    
    public void AddScore(int amount)
    {
        score += amount;
        OnScoreChanged?.Invoke(score);
    }
    public void RemoveScore(int amount)
    {
        score -= amount;
        OnScoreChanged?.Invoke(score);
    }

    public int CurrentScore => score;
}
