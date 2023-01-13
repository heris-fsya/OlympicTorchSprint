using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRunner : MonoBehaviour
{
    public LevelGenerator levelGen;
    public float platformSpeed = -2f;
    private float platformStartX;

    private void Start()
    {
        platformStartX = levelGen.transform.position.x;
    }

    private void Update()
    {
        levelGen.transform.position = new Vector3(levelGen.transform.position.x + platformSpeed * Time.deltaTime, levelGen.transform.position.y);

        if (levelGen.transform.position.x < platformStartX - levelGen.levelWidth)
        {
            levelGen.transform.position = new Vector3(platformStartX, levelGen.transform.position.y);
        }
    }
}
