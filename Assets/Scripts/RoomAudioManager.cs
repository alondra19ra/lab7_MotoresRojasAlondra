using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RoomAudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;  
    [SerializeField] private AudioMixer audioMixer;

    private void Awake()
    {
      
        audioMixer = Resources.Load<AudioMixer>("YourAudioMixer");
    }

    public void ChangeRoomMusic(RoomMusicSO room)
    {
        if (room == null || room.musicClip == null) return;

        audioSource.clip = room.musicClip;
        audioSource.volume = room.defaultVolume;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void SetVolume(float volume)
    {
        float dB = Mathf.Log10(Mathf.Clamp(volume, 0.0001f, 1f)) * 20f;
        audioMixer.SetFloat("MusicVolume", dB);
    }
}
