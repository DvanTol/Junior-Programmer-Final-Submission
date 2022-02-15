using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public Dictionary<string, int> scoreDict;
    public int totalScore { get; private set; } //encapsulation
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI blueText;
    public TextMeshProUGUI yellowText;
    public TextMeshProUGUI pinkText;
    public TextMeshProUGUI orangeText;

    // singleton:
    public static ScoreManager Instance { get; private set; }
 
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        scoreDict = new Dictionary<string, int>
        {
          {"blue", 0 }, {"yellow", 0 }, {"pink", 0}, {"orange", 0}
        };
        CalculateTotalScore();
        UpdateScoreText();
    }

    public void UpdatePoints(string color) 
    {
        scoreDict[color]++; 
    }

    public void CalculateTotalScore()
    {
        int total = scoreDict["blue"] + scoreDict["yellow"] + scoreDict["pink"] + scoreDict["orange"];
        totalScore = total;
    }

    public void ResetScore()
    {
        scoreDict["blue"] = 0;
        scoreDict["yellow"] = 0;
        scoreDict["pink"] = 0;
        scoreDict["orange"] = 0;
        CalculateTotalScore();
        UpdateScoreText();
        UpdateBoxScores();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + totalScore;
    }

    public void UpdateBoxScores()
    {
        blueText.text = "" + scoreDict["blue"];
        pinkText.text = "" + scoreDict["pink"];
        yellowText.text = "" + scoreDict["yellow"];
        orangeText.text = "" + scoreDict["orange"];
    }
}
