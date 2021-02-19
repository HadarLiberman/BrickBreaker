using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /*   float seconds = 2;
       bool loading = false;
       public void start()
       {
          Debug.Log("start");
          if (!loading) {
               Invoke("LoadNextScene", seconds);
               loading = true;
           }

       }*/
    static public int currentLevel;
    Tree tree;

    public void LoadNextScene()
    {
        
    int curentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(curentSceneIndex + 1);

    }

    public void LoadStartScene()
    {

        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().ResetGame();
        

    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
