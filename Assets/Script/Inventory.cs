    using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
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
    
    public bool CheckItem(int item)
    {
        if(inventory.Contains(item))
        {
            return true;
        }
        return false;
    }
}
