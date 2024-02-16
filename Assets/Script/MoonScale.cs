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
        // ���� ����
        while (true)
        {
            // ���� �������� �����ͼ� ũ�� ����
            Vector3 currentScale = transform.localScale;
            currentScale += new Vector3(growthRate, growthRate, 0f);

            // ������ ũ�⸦ ����
            transform.localScale = currentScale;

            // 0.1�� ��ٸ�
            yield return new WaitForSeconds(0.1f);
        }
    }
}
