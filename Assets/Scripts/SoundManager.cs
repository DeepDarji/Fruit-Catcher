using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip gameOverSound;
    public AudioClip collectSound;
   
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    
    }

   

    public void PlayGameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }

    public void PlayCollectSound()
    {
        audioSource.PlayOneShot(collectSound);
    }
}
