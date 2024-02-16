using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Box : MonoBehaviour
{
    private int[] index = new int[3];
    public GameObject[] image = new GameObject[3];
    private bool isCorrect = false;

    public void Next(int i)
    {
        image[i].transform.GetChild(index[i]).gameObject.SetActive(false);
        index[i] = (index[i] == 4 ? 0 : index[i] + 1);
        image[i].transform.GetChild(index[i]).gameObject.SetActive(true);
    }

    public void Prev(int i)
    {
        image[i].transform.GetChild(index[i]).gameObject.SetActive(false);
        index[i] = (index[i] == 0 ? 4 : index[i] - 1);
        image[i].transform.GetChild(index[i]).gameObject.SetActive(true);
    }

    private void Update()
    {
        if (!isCorrect && index[0] == 4 && index[1] == 1 && index[2] == 3)
        {
            Clear();
        }
    }

    private void Clear()
    {
        isCorrect = true;
        Debug.Log("Correct!");
        gameObject.SetActive(false);
    }
}
