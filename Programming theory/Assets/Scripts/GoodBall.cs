using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBall : Balls
{
    /*private void OnTriggerEnter(Collider other) /// make virtual to be able to override from BAD class
    {   // only the 4 boxes have a collider set to trigger
        // check if other is box in same color  
        if (gameObject.tag == other.tag)
        {
            string color = other.tag;


            ScoreManager.Instance.UpdatePoints(color);
            ScoreManager.Instance.CalculateTotalScore();
            ScoreManager.Instance.UpdateScoreText();
        }
    }*/

    
}
