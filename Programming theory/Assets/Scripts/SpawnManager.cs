using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public int ballCount = 0;
    private int maxBalls = 20;

    void Start()
    {
        Invoke("SpawnBalls", 1);
    }

    void SpawnBalls()
    {
        if (ballCount < maxBalls)
        {
            float randomInterval = Random.Range(1.2f, 3f);
            int ballIndex = Random.Range(0, ballPrefabs.Length);
            Instantiate(ballPrefabs[ballIndex], new Vector3(12, 31, 0), ballPrefabs[ballIndex].transform.rotation);
            ballCount++;
            Invoke("SpawnBalls", randomInterval);
        }
        else
        {
           Invoke("SetGameInactive", 4.5f);
        }
    }

    public void Restart()
    {
        Invoke("SpawnBalls", 1);
    }

    private void SetGameInactive()
    {
        MainUIHandler.Instance.isGameActive = false;
    }

}
