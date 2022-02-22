using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BadBall : Balls // inheritance
{
    private AudioSource explodeAudio;
    private GameObject Audio;

    void OnMouseDown()
    {
        Audio = GameObject.Find("explosionAudio");
        explodeAudio = Audio.GetComponent<AudioSource>();
        explodeAudio.Play();
        
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


