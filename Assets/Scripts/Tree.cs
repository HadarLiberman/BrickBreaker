using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tree : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winPrize;

    [SerializeField] public GameObject[] decor;

   /* public void FadeIn()
    {
        StartCoroutine(FadeGameObject(winPrize[0], winPrize[0].alpha, 1));
    }
    public IEnumerator FadeGameObject(CanvasGroup img, float start, float end, float lerpTime=0.5f)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;

        while (true)
        {

            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;
            float currentValue = Mathf.Lerp(start, end, percentageComplete);

            img.alpha = currentValue;

            if (percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("done corountine");
    }*/
    void Start()
    {


        /*   for (int i = 0; i < Decorations.winItems.Length; i++)
           {
               Debug.Log(Decorations.winItems[i].ToString() + "=="+Decorations.prize.ToString());
               if( Decorations.winItems[i].ToString() == Decorations.prize.ToString())
               {
                   Debug.Log("opacity");
               }
           }*/
        BackFromLevel(0);


    }

    public void BackFromLevel(int num)
    {
        decor[num].GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
