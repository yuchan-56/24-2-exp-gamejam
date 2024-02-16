using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public string ItemName;
    public string ImagePath;
    public bool hasItem;

    public GameObject canvas;
    private GameObject Obj;
    public void Awake()
    {
        Obj = this.GetComponent<GameObject>();
    }

    public void GetItem()
    {
        canvas.SetActive(true);
        hasItem = true;
        Obj.SetActive(false);
    }
}