using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject inventoryParent, zoomParent;
    public GameObject[] prefab = new GameObject[4];
    public List<int> inventory = new List<int>();

    public void GetItem(int item)
    {
        Instantiate(prefab[item], inventoryParent.transform.GetChild(inventory.Count));
        inventory.Add(item);
    }

    public void ZoomItem(int item)
    {
        if (item >= inventory.Count) return;
        zoomParent.transform.GetChild(inventory[item]).gameObject.SetActive(true);
    }
    
}
