using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float ScreenWidthUnits=8f;
    [SerializeField] float minX = 5f;
    [SerializeField] float maxX = 10f;
    [SerializeField] float scalePresent = 1f;
    bool presentMode = false;

    GameStatus myGameStatus;
    Ball myBall;


    // Start is called before the first frame update
    void Start()
    {
        myGameStatus = FindObjectOfType<GameStatus>();
        myBall = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
   
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
       paddlePos.x= Mathf.Clamp(GetXPos(), minX, maxX);
       transform.position = paddlePos;
    }
    public void UppdateScale()
    {
        Debug.Log("here");
        scalePresent-=0.2f;
        transform.localScale = new Vector3(scalePresent, transform.localScale.y, transform.localScale.z);
        minX += 0.7f;
        maxX -= 0.7f;
        Update();
    }

    private float GetXPos()
    {
        if (myGameStatus.IsAutoPlayEnabled())
        {
            return myBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * ScreenWidthUnits;
        }
    }
}
