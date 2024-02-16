using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int LeftTime;
    public void Start()
    {
        LeftTime = 60;
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while (LeftTime > 0)
        {
            LeftTime--;
            yield return new WaitForSeconds(1f);
        }
        //GameOver();
        yield break;
    }
}
