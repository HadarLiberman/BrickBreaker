using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour
{
    [SerializeField] int breakbleBlocks;

    SceneLoader SceneLoader;
    GameStatus gameStatus;
    Decorations decorations;




    private void Start()
    {
        SceneLoader = FindObjectOfType<SceneLoader>();
        gameStatus = FindObjectOfType<GameStatus>();
        decorations = FindObjectOfType<Decorations>();

    }

    public void CountBlocks()
    {
       
            breakbleBlocks++;
    }

    public void BlockDestroyed()
    {
        breakbleBlocks--;
        if (breakbleBlocks <= 0)
        {
            gameStatus.currentLife = 3;
            gameStatus.UpdateLife();
            gameStatus.CompleteLevelUI();
            
            //SceneLoader.LoadNextScene();

        }
    }

   
    public void CompleteLevelUI()
    {
        gameStatus.completeLevelUI.SetActive(true);
    }



}
