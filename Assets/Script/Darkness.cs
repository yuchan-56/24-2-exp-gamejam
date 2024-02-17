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

    public void buttonActive()
    {
        startskull.interactable = true;
    }

    private void Update()
    {
        background.color = new Color(0, 0, 0,
                Mathf.Lerp(1, 0, Timer.Instance.time / 60f));

        if (Timer.Instance.time > 45f)
        {
            startskull.interactable = true;
        }
    }

}
