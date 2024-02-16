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

        // 초기 색상 저장
        startColor = myImage.color;

        // 코루틴 시작
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            // 투명도를 시간에 따라 조절
            float alpha = Mathf.Pow(elapsedTime / fadeDuration, exponentialFactor);

            // 현재 색상을 가져와서 투명도를 조절한 후 적용
            Color newColor = startColor;
            newColor.a = 1 - alpha;
            myImage.color = newColor;

            // 시간 업데이트
            elapsedTime += Time.deltaTime;

            // 매 프레임마다 잠시 기다림
            yield return null;
        }

        // 투명도가 0이 되면 이미지 비활성화 또는 다른 작업 수행
        gameObject.SetActive(false);
    }
}
