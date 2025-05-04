using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Audio/Room Music")]
public class RoomMusicSO : ScriptableObject
{
    [Tooltip("AudioClip que se reproducirá en este cuarto")]
    public AudioClip musicClip;

    [Tooltip("Volumen por defecto (0 a 1)")]
    [Range(0, 1)]
    public float defaultVolume = 0.8f;
}
