using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    [SerializeField] private AudioSource doorAudioSource; 
    [SerializeField] private AudioClip doorOpenSound; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            doorAudioSource.PlayOneShot(doorOpenSound);
        }
    }
}
