using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Start() {
        EventManager.OnTrashOutOfBounds += SubtractHealth;
    }

    private void SubtractHealth()
    {
        health -= 1;
    }

    private void Update() {

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (health <= 0)
        {
            EventManager.GameOverEvent();
        }
    }

    private void OnDestroy() {
        EventManager.OnTrashOutOfBounds -= SubtractHealth;
    }
}
