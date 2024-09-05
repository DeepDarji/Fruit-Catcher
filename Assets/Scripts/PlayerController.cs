using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 40f;  // The speed at which the basket moves
    private float horizontalInput;  // To store the player's horizontal input
    private int score = 0;  // Player's score, starts at 0
    public Text scoreText;  // Reference to the UI Text element displaying the score

    // Function to increase the score when a fruit is caught
    public void IncreaseScore(int amount)
    {
        score += amount;  // Add the passed amount (usually 1) to the current score
        Debug.Log("Score: " + score);  // Log the new score in the console for debugging
        scoreText.text = "Score: " + score.ToString();  // Update the score display in the UI
    }

    void Update()
    {
        // Get the player's horizontal input (left/right arrow keys or A/D keys)
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the basket horizontally based on player input, speed, and time
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);

        // Ensure the basket stays within the x-axis range of -9 to 9
        float clampedX = Mathf.Clamp(transform.position.x, -9f, 9f);

        // Apply the clamped x position, keeping the y position the same
        transform.position = new Vector2(clampedX, transform.position.y);
    }
}
