using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 0;
    public Image background;
    
    public void Start()
    {
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while (time < 60)
        {
            time += Time.deltaTime;
            yield return null;
        }
        StartCoroutine(Fail());
    }

    IEnumerator Fail()
    {
        background.gameObject.SetActive(true);
        float time = 0;
        while (time < 1)
        {
            background.color = new Color(1, 1, 1, Mathf.Lerp(0, 1, time));
            time += Time.deltaTime;
            yield return null;
        }
        SceneManager.LoadScene("GameOver");
    }
}
