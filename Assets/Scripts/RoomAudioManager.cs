using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RoomAudioManager : MonoBehaviour
{
    public AudioSource audioSource;  
    public AudioClip[] roomMusic;   
    private AudioMixer audioMixer;

    private void Awake()
    {
      
        audioMixer = Resources.Load<AudioMixer>("YourAudioMixer");
    }

    public void ChangeRoomMusic(int roomIndex)
    {
        if (roomIndex >= 0 && roomIndex < roomMusic.Length)
        {
            audioSource.clip = roomMusic[roomIndex];
            audioSource.Play();
        }
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }
}
