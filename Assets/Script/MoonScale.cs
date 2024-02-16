using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScale : MonoBehaviour
{
    public float growthRate;

    public void Awake()
    {
        growthRate = 0.02f;
        StartCoroutine(GrowCircle());
    }
    IEnumerator GrowCircle()
    {
        // 무한 루프
        while (true)
        {
            // 현재 스케일을 가져와서 크기 증가
            Vector3 currentScale = transform.localScale;
            currentScale += new Vector3(growthRate, growthRate, 0f);

            // 증가된 크기를 적용
            transform.localScale = currentScale;

            // 0.1초 기다림
            yield return new WaitForSeconds(0.1f);
        }
    }
}
