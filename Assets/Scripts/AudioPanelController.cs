using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPanelController : MonoBehaviour
{
    [SerializeField] private GameObject audioPanel;

    public void ShowAudioPanel()
    {
        audioPanel.SetActive(true);
    }

    public void HideAudioPanel()
    {
        audioPanel.SetActive(false);
    }
}

