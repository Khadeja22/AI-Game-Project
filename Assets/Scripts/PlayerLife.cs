using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    //uncomment animator lines once the death animation is added
    private Animator anim;
    private Rigidbody2D rb;
    public healthScript healthScript;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Gaurd"))
        {
            Die();
        }
    }

      private void Die()
    {
        anim.SetTrigger("death");
        rb.bodyType = RigidbodyType2D.Static;

        // Call the TakeDamage method from the Health script
        healthScript.TakeDamage(1); // Assuming 1 is the damage amount
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
