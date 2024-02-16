using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Darkness : MonoBehaviour
{
    public float fadeDuration = 45f;
    public float exponentialFactor = 3f;

    public GameObject darkness;
    public Image myImage;
    private Color startColor;

    void Start()
    {
        startColor = myImage.color;
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            float alpha = Mathf.Pow(elapsedTime / fadeDuration, exponentialFactor);
            
            Color newColor = startColor;
            newColor.a = 1 - alpha;
            myImage.color = newColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        darkness.SetActive(false);
    }
}
