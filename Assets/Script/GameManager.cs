using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int LeftTime;
    public TextMeshProUGUI TimerText;
    public GameObject GameOverCanvas;


    public void Start()
    {
        GameOverCanvas.SetActive(false);
        LeftTime = 60;
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while (LeftTime >0)
        {
            LeftTime--;
            TimerText.text = "LeftTime: " + LeftTime;
            yield return new WaitForSeconds(1f);
        }
        GameOver();
        yield break;
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
    }
}
