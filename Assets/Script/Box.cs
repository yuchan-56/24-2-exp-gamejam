using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private int[] index = new int[3];
    public GameObject[] image = new GameObject[3];

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

}
