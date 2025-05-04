using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneController : MonoBehaviour
{
    public static SceneController Instance;
    private void Awake()
    {
        if (Instance == null) 
        { 
            Instance = this; DontDestroyOnLoad(gameObject); 
        }
        else Destroy(gameObject);
    }

    public void LoadSceneWithFade(int buildIndex)
    {
        StartCoroutine(CoLoadScene(buildIndex));
    }

    private IEnumerator CoLoadScene(int idx)
    {
        yield return ScreenFader.Instance.FadeOut(1f);
        SceneManager.LoadScene(idx);
        yield return null;
        yield return ScreenFader.Instance.FadeIn(1f);
    }

}

