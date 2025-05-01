using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public int roomIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            RoomAudioManager audioManager = FindObjectOfType<RoomAudioManager>();
            if (audioManager != null)
            {
                audioManager.ChangeRoomMusic(roomIndex);
            }
        }
    }
}
