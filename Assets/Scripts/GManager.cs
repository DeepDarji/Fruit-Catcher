using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class GManager : MonoBehaviour
{
    private SoundManager soundManager;

    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    public void GameOver()
    {
        // Play the game over sound
        soundManager.PlayGameOverSound();

        // Wait for 2 seconds before restarting
        StartCoroutine(RestartAfterDelay(1f));
    }


    IEnumerator RestartAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("StartScreen");
    }
}
