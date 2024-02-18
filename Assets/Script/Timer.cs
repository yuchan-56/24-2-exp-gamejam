using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    public static Timer Instance { get; private set; }
    private void Awake() => Instance = this;

    public float time = 0;
    public Image background;

    public void Start()
    {
        StartCoroutine(StartTimer());
    }

    public void Resume()
    {
        AudioManager.Instance.AudioPlay("InGame");
        StartCoroutine(StartTimer());
    }

    public void Pause()
    {
        AudioManager.Instance.AudioPlay("Menu");
        StopAllCoroutines();
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
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameOver");
    }
}
