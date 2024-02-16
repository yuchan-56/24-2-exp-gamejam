using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Darkness : MonoBehaviour
{
    public float fadeDuration = 45f;
    public float exponentialFactor = 3f;

    private Image myImage;
    private Color startColor;

    void Start()
    {
        myImage = GetComponent<Image>();

        // �ʱ� ���� ����
        startColor = myImage.color;

        // �ڷ�ƾ ����
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            // ������ �ð��� ���� ����
            float alpha = Mathf.Pow(elapsedTime / fadeDuration, exponentialFactor);

            // ���� ������ �����ͼ� ������ ������ �� ����
            Color newColor = startColor;
            newColor.a = 1 - alpha;
            myImage.color = newColor;

            // �ð� ������Ʈ
            elapsedTime += Time.deltaTime;

            // �� �����Ӹ��� ��� ��ٸ�
            yield return null;
        }

        // ������ 0�� �Ǹ� �̹��� ��Ȱ��ȭ �Ǵ� �ٸ� �۾� ����
        gameObject.SetActive(false);
    }
}
