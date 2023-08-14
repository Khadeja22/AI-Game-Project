using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    //uncomment animator lines once the death animation is added
    //private Animator anim;
    private Rigidbody2D rb;
    
    private void Start()
    {
        //anim = GetComponent<Animator>();
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
        //anim.SetTrigger("death");
        rb.bodyType = RigidbodyType2D.Static;
    }
   
}
