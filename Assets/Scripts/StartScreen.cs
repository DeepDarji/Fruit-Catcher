using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public AudioSource backgroundMusic;  // Reference to the background music AudioSource

    void Start()
    {
        // Make sure the background music keeps playing when switching scenes
        DontDestroyOnLoad(gameObject);

        // Check if the background music is not playing, then start it
        if (!backgroundMusic.isPlaying)
        {
            backgroundMusic.Play();
        }
    }

    // Function called when the "Play" button is clicked
    public void OnPlayButtonClicked()
    {
        // Load the main game scene when the play button is clicked
        SceneManager.LoadScene("Main");
    }
}
