using UnityEngine;

public class Fruit : MonoBehaviour
{
    private SoundManager soundManager;
    private bool isCaught = false;  // Flag to prevent double scoring

    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Basket" && !isCaught)
        {
            // Play collect sound
            soundManager.PlayCollectSound();

            // Handle score increment and destroy fruit
            GameObject.Find("Basket").GetComponent<PlayerController>().IncreaseScore(1);

            isCaught = true;  // Mark the fruit as caught
            Destroy(gameObject);  // Destroy the fruit after it's caught
        }
        else if (collision.gameObject.tag == "Ground")
        {
            // Call GameOver sequence
            GameObject.Find("GManager").GetComponent<GManager>().GameOver();
            Destroy(gameObject);
        }
    }
}
