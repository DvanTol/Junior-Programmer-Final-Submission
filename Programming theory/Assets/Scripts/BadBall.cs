using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBall : Balls // inheritance
{
    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    public override void OnTriggerEnter(Collider other) // polymorphism
    {  
        string color = other.tag;
        ScoreManager.Instance.scoreDict[color] = 0;
        ScoreManager.Instance.CalculateTotalScore();
        ScoreManager.Instance.UpdateScoreText();
        ScoreManager.Instance.UpdateBoxScores();
    }
}


