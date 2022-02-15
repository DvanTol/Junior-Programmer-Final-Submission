using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Balls : MonoBehaviour 
{
    public virtual void OnTriggerEnter(Collider other) // virtual to be able to override in BAD class
    {   // only the 4 boxes have a collider set to trigger
        // check if other is box in same color  
        if (gameObject.tag == other.tag) 
        {
            string color = other.tag;

            ScoreManager.Instance.UpdatePoints(color);
            ScoreManager.Instance.CalculateTotalScore();
            ScoreManager.Instance.UpdateScoreText();
            ScoreManager.Instance.UpdateBoxScores();
        }
    }
}
