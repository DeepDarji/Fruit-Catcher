using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip gameOverSound;   // Sound to play when the game is over
    public AudioClip collectSound;    // Sound to play when a fruit is collected

    private AudioSource audioSource;  // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to this object
        audioSource = GetComponent<AudioSource>();
    }

    // Play the game over sound effect
    public void PlayGameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }

    // Play the sound when a fruit is collected
    public void PlayCollectSound()
    {
        audioSource.PlayOneShot(collectSound);
    }
}