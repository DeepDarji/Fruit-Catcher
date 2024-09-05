using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public AudioSource backgroundMusic;


    void Start()
    {
        DontDestroyOnLoad(gameObject);  // Keeps the music playing across scenes
        if (!backgroundMusic.isPlaying)
        {
            backgroundMusic.Play();
        }
    }


    public void OnPlayButtonClicked()
    {
        // Load the game screen
        SceneManager.LoadScene("Main");
    }
}
