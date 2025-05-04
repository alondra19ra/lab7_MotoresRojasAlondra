using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    [Tooltip("Asigna aquí el ScriptableObject con la música de esta habitación")]
    [SerializeField] private RoomMusicSO roomMusic;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        var mgr = FindObjectOfType<RoomAudioManager>();
        if (mgr == null)
        {
            
            return;
        }

        if (roomMusic == null)
        {
            
            return;
        }

        mgr.ChangeRoomMusic(roomMusic);
    }
}



