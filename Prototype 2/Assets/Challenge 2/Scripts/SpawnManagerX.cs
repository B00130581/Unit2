using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float minTime = 1.5f;
    private float maxTime = 6.0f;

    public float spawnTimeInterval;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomBall();
        spawnTimeInterval = Random.Range(minTime, maxTime);
    }


    void Update()
    {
        spawnTimeInterval = Random.Range(minTime, maxTime);
    }


    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int ballNumber = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);
    }

}
