using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour
{
    GameStatus gameStatus;
    [SerializeField] string[] opttionalPresents= {"life","scale","extra ball"};
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
            GetMyPresent();
            Destroy(gameObject);
        }
    }

    private void GetMyPresent()
    {
        int index=Random.Range(0,1);
        index = 2;

        Debug.Log(index);
        if (opttionalPresents[index] == "life")
        {
            gameStatus.currentLife = gameStatus.currentLife + 1;
            gameStatus.UpdateLife();
        }
        else if (opttionalPresents[index] == "scale")
        {
            Debug.Log("update scale");
            paddle.UppdateScale();
        }
        else if (opttionalPresents[index] == "extra ball")
        {
            Debug.Log("extra ball");
            gameStatus.AddingExtraBall();

        }

    }
}
