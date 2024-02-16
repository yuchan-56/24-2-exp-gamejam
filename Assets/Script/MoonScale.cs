using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScale : MonoBehaviour
{
    public Timer timer;
    private int time;

    public void OnEnable()
    {
        time = timer.time;
        StartCoroutine(GrowCircle());
    }
    IEnumerator GrowCircle()
    {
        while (true)
        {
            transform.localScale = new Vector3(Mathf.Lerp(1, 10, (60 - time) / 60), Mathf.Lerp(1, 10, (60 - time) / 60), 0f);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
