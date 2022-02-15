using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float startDelay = 1;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBalls", startDelay, spawnInterval); // TODO make the interval a Random range
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnBalls()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], new Vector3(12, 31, 0), ballPrefabs[ballIndex].transform.rotation);
       
    }
}
