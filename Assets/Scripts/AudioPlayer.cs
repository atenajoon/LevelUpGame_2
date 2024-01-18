using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip auchClip;
    public AudioClip bingClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Check if AudioClips are assigned
        if (auchClip == null || bingClip == null)
        {
            Debug.LogError("One or more audio clips are not assigned to CollisionTriggerAudioPlayer.");
            return;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            PlayAudioClip(bingClip);
        }
        else if (other.CompareTag("Bonfire"))
        {
            PlayAudioClip(auchClip);
        }
    }

    public void PlayAudioClip(AudioClip clip)
    {
        if (enabled && audioSource != null && !audioSource.isPlaying)
        {
            // Assign the chosen audio clip to the AudioSource
            audioSource.clip = clip;

            // Play the audio
            audioSource.Play();
        }
    }
}
