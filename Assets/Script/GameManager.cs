using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.UIElements;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentdirection;
    public GameObject[] direction = new GameObject[4];

    public void Awake()
    {
        currentdirection = 0;
    }
    public void TurnLeft()
    {
        currentdirection--;
        if (currentdirection <= -1)
        {
            currentdirection = 3;
        }
        Move(currentdirection);
    }

    public void TurnRight()
    {
        currentdirection++;
        if (currentdirection >= 4)
        {
            currentdirection = 0;
        }
        Move(currentdirection);
    }
    public void Move(int targetdirection)
    {
        for(int i = 0; i < direction.Length; i++)
        {
            direction[i].SetActive(false);
        }
        direction[targetdirection].SetActive(true);
    }
}
