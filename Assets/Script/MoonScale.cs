using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScale : MonoBehaviour
{
    private float newScale;

    private void Update()
    {
        newScale = Mathf.Lerp(0.2f, 1, Timer.Instance.time / 60f);
        transform.localScale = new Vector3(newScale, newScale, 0f);
    }
}
