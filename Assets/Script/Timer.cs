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

    public GameObject brightText;
    private bool isBright = false;

    public void Start()
    {
        AudioManager.Instance.AudioPlay("InGame");
        StartCoroutine(StartTimer());
    }

    public void Resume()
    {
        AudioManager.Instance.AudioPlay("InGame");
        Time.timeScale = 1;
    }

    public void Pause()
    {
        AudioManager.Instance.AudioPlay("Menu");
        Time.timeScale = 0;
    }

    IEnumerator StartTimer()
    {
        while (time < 60)
        {
            time += Time.deltaTime;

            if (time > 44f && !isBright) StartCoroutine(BrightText());
            yield return null;
        }
        StartCoroutine(Fail());
    }

    IEnumerator BrightText()
    {
        isBright = true;
        brightText.SetActive(true);

        while (time < 46f) yield return null;
        brightText.SetActive(false);
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
