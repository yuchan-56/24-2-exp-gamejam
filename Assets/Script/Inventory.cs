using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject inventory;
    public List<string> items;

    public void GetItem(Item item)
    {
        items.Add(item.Name);
        UpdateInventory(item.Name);
        Debug.Log(item.Name);
    }

    public void UpdateInventory(string itemname)
    {
        if(items.Contains("Apple"))
        {
            Debug.Log("APPLE");
            Instantiate(prefabs[0], inventory.transform);
        }
    }
}
