using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameStatus gameStatus;
    Paddle paddle;


    private void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
        paddle = FindObjectOfType<Paddle>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(collision.name);
        if (collision.name == "Paddle")
        {
            GetCoin();
            Destroy(gameObject);
        }
    }

   private void GetCoin()
    {
        gameStatus.currentCoints = gameStatus.currentCoints + 2;
        gameStatus.UpdateCoins();
    }
}

