using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundEffects : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip stepSound;
    [SerializeField] private AudioClip doorOpenSound;

    public void PlayFootstepSound()
    {
        audioSource.PlayOneShot(stepSound);
    }

    public void PlayDoorOpenSound()
    {
        audioSource.PlayOneShot(doorOpenSound);
    }
}

