using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPanelController : MonoBehaviour
{
    public static AudioPanelController Instance;
    [SerializeField] private GameObject audioPanel;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    public void ShowAudioPanel()
    {
        audioPanel.SetActive(true);
    }

    public void HideAudioPanel()
    {
        audioPanel.SetActive(false);
    }
}

