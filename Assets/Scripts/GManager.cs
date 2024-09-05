using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class GManager : MonoBehaviour
{
    private SoundManager soundManager; // Reference to the SoundManager script

    void Start()
    {
        // Find the SoundManager object in the scene and get its component
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    public void GameOver()
    {
        // Play the game over sound when the game ends
        soundManager.PlayGameOverSound();

        // Wait for 1 second before restarting the game
        StartCoroutine(RestartAfterDelay(1f));
    }

    IEnumerator RestartAfterDelay(float delay)
    {
        // Wait for a certain amount of time (specified by 'delay') before continuing
        yield return new WaitForSeconds(delay);

        // Load the start screen to restart the game
        SceneManager.LoadScene("StartScreen");
    }
}
