using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Box : MonoBehaviour
{
    private int[] index = new int[3];
    public GameObject[] image = new GameObject[3];
    public GameObject boxCanvas;
    public GameObject[] boxImage = new GameObject[2];
    public GameObject nextroom, previousroom;
    private bool isCorrect = false;
    private bool locked, closed;

    public void Awake()
    {
        locked = true;
        closed = true;
    }

    public void BoxClick()
    {
        if(locked) boxCanvas.SetActive(true);
        else if (closed)
        {
            closed = false;
            boxImage[0].SetActive(false);
            boxImage[1].SetActive(true);
        }
    }

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
        locked = false;
        isCorrect = true;

        Debug.Log("Correct!");
        gameObject.SetActive(false);
        nextroom.SetActive(true);
        previousroom.SetActive(true);
    }
}
