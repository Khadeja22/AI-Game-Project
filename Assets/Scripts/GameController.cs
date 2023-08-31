using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class GameController : MonoBehaviour
{
    public float timeLimit = 20f;
    private float currentTime;
    public GameObject messagePanel; // Reference to the UI Panel
    public Text timerText; // Reference to the UI Text
    private bool timerExpired = false;

    void Start()
    {
        currentTime = timeLimit;
        messagePanel.SetActive(false); // Disable the panel initially
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f && !timerExpired)
        {
            // Display the message panel and timer text
            messagePanel.SetActive(true);
            timerText.text = "YOU DIDNT FIND THE KEY IN TIME! Try Again";
            timerExpired = true;

            // Start the coroutine to hide the message after 5 seconds
            StartCoroutine(HideMessageAfterDelay(5f));
        }
    }

    IEnumerator HideMessageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Hide the message panel and reset the timer text
        messagePanel.SetActive(false);
        timerText.text = "";
    }
}
