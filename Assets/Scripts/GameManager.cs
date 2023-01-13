using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LevelGenerator levelGen;
    public InfiniteRunner infiniteRunner;
    public PlayerMovement playerMovement;
    public PlayerCollision playerCollision;
    public Text scoreText;
    public Text highScoreText;
    public int score;
    public int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        score = 0;
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;

    }

    private void Update()
    {
        scoreText.text = "Score: " + score;
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
            highScoreText.text = "High Score: " + highScore;
        }
    }

    public void EndGame()
    {
        infiniteRunner.enabled = false;
        playerMovement.enabled = false;
        playerCollision.enabled = false;
        score = 0;
        levelGen.transform.position = new Vector3(levelGen.platformStartX, levelGen.transform.position.y);
        infiniteRunner.enabled = true;
        playerMovement.enabled = true;
        playerCollision.enabled = true;
        highScoreText.gameObject.SetActive(true);
    }
}

