using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Clear : MonoBehaviour
{
    public void Awake()
    {
        AudioManager.Instance.AudioPlay("ClearEnd");
        StartCoroutine(MoveMoon());
    }

    IEnumerator MoveMoon()
    {
        float time = 0;
        float newY;
        while (time < 18f)
        {
            newY = Mathf.Lerp(3000f, 1600f, time / 18f);
            gameObject.transform.localPosition = new Vector3(0, newY, 0);
            time += Time.deltaTime;
            yield return null;
        }

        time = 0;
        float rotZ;
        while (time < 2f)
        {
            rotZ = Mathf.Lerp(0f, 180f, time / 2f);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, rotZ);
            time += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(6f);
        Application.Quit();
    }
}
