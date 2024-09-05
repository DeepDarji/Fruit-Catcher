using UnityEngine;

public class Fruit : MonoBehaviour
{
    private SoundManager soundManager;  // Reference to the SoundManager script
    private bool isCaught = false;      // Flag to ensure the fruit is only caught once

    void Start()
    {
        // Find the SoundManager object in the scene and get its component
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the fruit collides with the basket and if it hasn't been caught yet
        if (collision.gameObject.tag == "Basket" && !isCaught)
        {
            // Play the collect sound
            soundManager.PlayCollectSound();

            // Increase the player's score by 1
            GameObject.Find("Basket").GetComponent<PlayerController>().IncreaseScore(1);

            // Mark the fruit as caught so the score isn't increased multiple times
            isCaught = true;

            // Destroy the fruit after it is caught
            Destroy(gameObject);
        }
        // Check if the fruit hits the ground
        else if (collision.gameObject.tag == "Ground")
        {
            // Call the GameOver function in the GameManager
            GameObject.Find("GManager").GetComponent<GManager>().GameOver();

            // Destroy the fruit when it hits the ground
            Destroy(gameObject);
        }
    }
}
