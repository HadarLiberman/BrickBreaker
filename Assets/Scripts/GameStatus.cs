using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStatus : MonoBehaviour
{
   [Range(0.1f,10f)] [SerializeField] float gameSpeed=1f;
    [SerializeField] int pointsPerBlockDestroyed = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI lifeText;
    [SerializeField] TextMeshProUGUI coinsText;


    [SerializeField] bool isAutoPlayEnabled;

    public GameObject completeLevelUI;
    public GameObject extraBall;






    [SerializeField] int currentScore=0;
    [SerializeField] public int currentLife=3;
    [SerializeField] public int currentCoints = 0;



    private void Awake()
    {

        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            
        }
    }
    private void Start()
    {


        scoreText.text = currentScore.ToString();
        lifeText.text = currentLife.ToString();
        coinsText.text = currentCoints.ToString();
   

    }
    public void UpdateLife()
    {
        lifeText.text = currentLife.ToString();

    }
    public void UpdateCoins()
    {
        coinsText.text = currentCoints.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }

    public void LoseLife()
    {
        currentLife--;
        lifeText.text = currentLife.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
    public void CompleteLevelUI()
    {
      completeLevelUI.SetActive(true);
        Debug.Log("gamestatus");

    }
    public void AddingExtraBall()
    {
        extraBall.SetActive(true);
        Debug.Log("extraball");

    }


}
