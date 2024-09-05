using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 40f;
    private float horizontalInput;
    private int score = 0;
    public Text scoreText;

    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);


        // Basket's position to stay between -9 and 9 on
        float clampedX = Mathf.Clamp(transform.position.x, -9f, 9f);
        transform.position = new Vector2(clampedX, transform.position.y);
    }
}