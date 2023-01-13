using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            playerMovement.enabled = true;
            gameManager.score++;
        }
        else
        {
            playerMovement.enabled = false;
            gameManager.EndGame();
        }
    }
}

