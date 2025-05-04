using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class PlayerInteract : MonoBehaviour
{
    public CanvasGroup interactionPanel;
    public float messageDuration = 2f;

    public void HandleInteract()
    {
        Debug.Log("Se presionó Interactuar");

        if (interactionPanel != null)
        {
            StartCoroutine(ShowInteractionMessage());
        }
        else
        {
            Debug.LogWarning("El interactionPanel no está asignado.");
        }
    }

    private IEnumerator ShowInteractionMessage()
    {
        interactionPanel.alpha = 1;
        interactionPanel.blocksRaycasts = true;
        interactionPanel.interactable = true;

        yield return new WaitForSeconds(messageDuration);

        interactionPanel.alpha = 0;
        interactionPanel.blocksRaycasts = false;
        interactionPanel.interactable = false;
    }
}


