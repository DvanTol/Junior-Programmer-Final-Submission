using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Balls : MonoBehaviour 
{
    private Rigidbody rb;
    private int speed = 50; // Abstraction

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        rb.AddForce(new Vector3(0, -speed, 0), ForceMode.Force);
    }

    public virtual void OnTriggerEnter(Collider other) // virtual to be able to override in BadBall class
    {   
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
