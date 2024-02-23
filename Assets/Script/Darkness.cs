using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Darkness : MonoBehaviour
{
    public Image background;
    public Button startskull;

    public GameObject brightText;
    private bool isBright = false;

    public void buttonActive()
    {
        startskull.interactable = true;
    }

    private void Update()
    {
        if((Timer.Instance.time >= 44f && Timer.Instance.time <= 45f))
        {
            background.color = new Color(0, 0, 0,
                Mathf.Lerp(1, 0, Timer.Instance.time - 44));

            if (!isBright) StartCoroutine(BrightText());
        }

        if (Timer.Instance.time > 45f)
        {
            background.color = new Color(0, 0, 0, 0);
            startskull.interactable = true;
        }
    }

    IEnumerator BrightText()
    {
        isBright = true;
        brightText.SetActive(true);

        while (Timer.Instance.time < 46f) yield return null;
        brightText.SetActive(false);
    }

}
