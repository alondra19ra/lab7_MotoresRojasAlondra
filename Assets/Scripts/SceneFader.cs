using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenFader : MonoBehaviour
{
    public static ScreenFader Instance;
    private Image img;

    private void Awake()
    {
        if (Instance == null)
        { 
            Instance = this; DontDestroyOnLoad(gameObject); 
        }
        else Destroy(gameObject);

        img = GetComponent<Image>();
    }

    public IEnumerator FadeOut(float duration)
    {
        for (float t = 0; t < 1; t += Time.deltaTime / duration)
        {
            img.color = new Color(0, 0, 0, t);
            yield return null;
        }
    }

    public IEnumerator FadeIn(float duration)
    {
        for (float t = 1; t > 0; t -= Time.deltaTime / duration)
        {
            img.color = new Color(0, 0, 0, t);
            yield return null;
        }
    }
}
