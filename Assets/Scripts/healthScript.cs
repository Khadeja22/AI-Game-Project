using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthScript : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update() {

        if (health > numOfHearts){
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i<health){
                hearts[i].sprite = fullHeart;
            }
            else{
                hearts[i].sprite = emptyHeart;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else{
                hearts[i].enabled = false;
            }
        }
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        // Check if health is less than or equal to zero, and handle death or other logic if needed.
        if (health <= 0)
        {
            // Handle death or any other logic here.
            SceneManager.LoadScene("Restart");
        }
    }

}
