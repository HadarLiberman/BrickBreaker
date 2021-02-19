using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Block : MonoBehaviour
{
    [SerializeField] AudioClip blockSound;
    [SerializeField] GameObject blockSparklesVFX;
    [SerializeField] Sprite[] hitSprites;
    [SerializeField] GameObject present;
    [SerializeField] GameObject coin;





    Level level;

    [SerializeField] int timesHit;


    private void Start()
    {
        CountBreakableBlock();
    }

    private void CountBreakableBlock()
    {
        level = FindObjectOfType<Level>();
        if (tag != "Unbreakable")
        {
            level.CountBlocks();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {
            HandleHit();
        }
         if (tag == "prize")
        {
            PrizeHit();
        }
        if (tag == "Have coin")
        {
            DestroyBlock();
            Instantiate(coin, transform.position, transform.rotation);

        }


    }

    private void PrizeHit()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1;

        if (timesHit >= maxHits)
        {
            DestroyBlock();
            Instantiate(present, transform.position, transform.rotation);
        }
    }

    private void HandleHit()
    {
      
            timesHit++;
            int maxHits = hitSprites.Length + 1;

            if (timesHit >= maxHits)
            {
                DestroyBlock();
            }
            else
            {
                ShowNextHirSprite();
            }
        
        
    }

  
    private void ShowNextHirSprite()
    {
        int spriteIndex=timesHit-1;
        if (hitSprites[spriteIndex] != null)
        {
            GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        else
        {
            Debug.LogError("Block sprite is missing from array at "+ gameObject.name);
        }
    }

    private void DestroyBlock()
    {
    
            PlayingBreakSounds();
            Destroy(gameObject);
            TriggerSparklesVFX();
            level.BlockDestroyed();


    }

    private void PlayingBreakSounds()
    {
        AudioSource.PlayClipAtPoint(blockSound, Camera.main.transform.position);
        FindObjectOfType<GameStatus>().AddToScore();
    }

    public void TriggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkles, 1f);
    }

}
