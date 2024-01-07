using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    ScoreKeeper scoreKeeper;
    LevelManager levelManager;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Dirty" && scoreKeeper.dirtyPassed != 3)
        {
            scoreKeeper.IncrementDirtyPassed();
        }
        else if (scoreKeeper.dirtyPassed == 3)
        {
            levelManager.LoadGameOver();
        }
    }

}
