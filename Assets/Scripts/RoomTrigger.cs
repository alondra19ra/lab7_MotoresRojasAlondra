using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public int roomIndex;
    [SerializeField] private int nextSceneBuildIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneController.Instance.LoadSceneWithFade(nextSceneBuildIndex);
            RoomAudioManager audioManager = FindObjectOfType<RoomAudioManager>();
            if (audioManager != null)
            {
                audioManager.ChangeRoomMusic(roomIndex);
            }
        }
    }
}
