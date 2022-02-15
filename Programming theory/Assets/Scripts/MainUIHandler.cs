using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIHandler : MonoBehaviour
{
    public bool isGameActive = true;
    public GameObject startUI;
    public SpawnManager spawnManager;

    // singleton:
    public static MainUIHandler Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (isGameActive == false)
        {
            startUI.SetActive(true);
            isGameActive = true;
        }
    }

    public void StartNew()
    {
        spawnManager.ballCount = 0;
        ScoreManager.Instance.ResetScore();
        spawnManager.Restart();
        startUI.SetActive(false);
    }
}
