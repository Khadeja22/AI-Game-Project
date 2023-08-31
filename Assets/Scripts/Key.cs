using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.CompareTag("TrueKey"))
            {
                // Load the next scene since the true key was found
                SceneManager.LoadScene("LabScene");
            }

            Destroy(gameObject); // Remove the key object
        }
    }
}
