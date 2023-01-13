using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    public int numberOfPlatforms;
    public float platformSpacing;
    public float platformStartX;

    private void Start()
    {
        platformStartX = transform.position.x;
        GenerateLevel();
      
    }
    private void GenerateLevel()
    {
        for (int i = 0; i < 20; i++)
        {
            Vector3 spawnPosition = new Vector3();
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefabs[Random.Range(0, platformPrefabs.Length)], spawnPosition, Quaternion.identity);
        }
    }
}
