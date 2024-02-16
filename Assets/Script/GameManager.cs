using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Move(GameObject before, GameObject after)
    {
        before.SetActive(false);
        after.SetActive(true);
    }
}
