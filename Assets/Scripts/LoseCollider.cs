using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseCollider : MonoBehaviour
{

    GameStatus gameStatus;
    Ball ball;

    private void Start()
    {
        gameStatus =FindObjectOfType<GameStatus>();
        ball = FindObjectOfType<Ball>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);

        if (collision.name == "Ball") {
            gameStatus.LoseLife();
            if (gameStatus.currentLife <= 0)
            {
                SceneManager.LoadScene("Game Over");
            }
            else
            {
                ball.hasSarted = false;
            }
        }
    }
}
