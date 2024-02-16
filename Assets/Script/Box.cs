using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Box : MonoBehaviour
{
    private int[] index = new int[3];

    public GameObject[] image = new GameObject[3];
    public GameObject close, open;

    private bool isCorrect = false;

    public void Next(int i)
    {
        image[i].transform.GetChild(index[i]).gameObject.SetActive(false);
        index[i] = (index[i] == 3 ? 0 : index[i] + 1);
        image[i].transform.GetChild(index[i]).gameObject.SetActive(true);
    }

    public void Prev(int i)
    {
        image[i].transform.GetChild(index[i]).gameObject.SetActive(false);
        index[i] = (index[i] == 0 ? 3 : index[i] - 1);
        image[i].transform.GetChild(index[i]).gameObject.SetActive(true);
    }

    private void Update()
    {
        if (!isCorrect && index[0] == 0 && index[1] == 3 && index[2] == 2)
        {
            Clear();
        }
    }

    private void Clear()
    {
        AudioManager.Instance.SFXPlay("KeyOpen");
        isCorrect = true;
        close.SetActive(false);
        open.SetActive(true);

        Debug.Log("Correct!");
    }
}
