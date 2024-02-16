using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Darkness : MonoBehaviour
{
    public Image background;
    public Button skull;

    void Start()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        while (Timer.Instance.time < 60f)
        {
            background.color = new Color(0, 0, 0, 
                Mathf.Lerp(1, 0, Timer.Instance.time / 60f));

            if (Timer.Instance.time > 15f)
            {
                skull.interactable = true;
            }

            yield return null;
        }
        
    }
}
