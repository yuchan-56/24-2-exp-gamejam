using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionary<Item, bool> hasItem;

    public void Awake()
    {
        hasItem = new Dictionary<Item, bool>();
    }

    public void Move(GameObject before, GameObject after)
    {
        before.SetActive(false);
        after.SetActive(true);
    }

    public void GetItem(Item item)
    {
        hasItem.Add(item, true);
    }
}
