using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnRate = 1;
    private float timeLeftBeforeSpawn = 0;
    private SpawnPoint[] spawnPoints;
    public GameObject ennemiTrianglePrefab;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = FindObjectsOfType<SpawnPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSpawn();
    }

    private void UpdateSpawn()
    {
        timeLeftBeforeSpawn -= Time.deltaTime;
        if (timeLeftBeforeSpawn <= 0)
        {
            SpawnEnnemiTriangle();
            timeLeftBeforeSpawn = spawnRate;
        }
    }

    private void SpawnEnnemiTriangle()
    {
        int countSpawnPoints = spawnPoints.Length;
        int randomSpawnPointIndex = Random.Range(0, countSpawnPoints);
        SpawnPoint currentSpawnPoint = spawnPoints[randomSpawnPointIndex];
        Instantiate(ennemiTrianglePrefab, currentSpawnPoint.transform.position, Quaternion.identity);
    }
}
