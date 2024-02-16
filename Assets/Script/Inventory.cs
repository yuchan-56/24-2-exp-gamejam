using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum Item
    {
        Key,
        Note,
        TornNote1,
        TornNote2
    }

    public GameObject parent;
    public GameObject[] prefab = new GameObject[4];
    public List<Item> inventory = new List<Item>();

    public void GetItem(int item)
    {
        Instantiate(prefab[item], parent.transform.GetChild(inventory.Count));
        inventory.Add((Item)item);
    }
}
