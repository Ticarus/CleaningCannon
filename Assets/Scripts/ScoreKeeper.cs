using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int score;
    public int dirtyPassed;
    public int GetScore()
    {
        return score;
    }

    public void ModifyScore(int value)
    {
        score += value;
        Mathf.Clamp(score, 0, int.MaxValue);
        Debug.Log(score);
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void IncrementDirtyPassed()
    {
        dirtyPassed++;
    }

    public void ResetDirtyPassed()
    {
        dirtyPassed = 0;
    }
}