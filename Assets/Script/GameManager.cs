using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.UIElements;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Move(GameObject before, GameObject after)
    {
        before.SetActive(false);
        after.SetActive(true);
    }
}
