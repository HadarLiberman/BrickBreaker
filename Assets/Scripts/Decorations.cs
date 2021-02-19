using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Decorations : MonoBehaviour
{
   [SerializeField] public Sprite[] winItems;
  static public Sprite prize;
    public GameObject img;
    

    // Start is called before the first frame update
    private void Awake()
    {
        ChaneImage();
    }

    private void ChaneImage()
    {
        prize = winItems[1];
        Debug.Log("decoration");
        img.GetComponent<Image>().sprite = prize;
        Debug.Log(prize.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
