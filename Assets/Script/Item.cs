using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int ID;
    public string Name;
    public Sprite Image;
    public Sprite Info;

    public void Zoom()
    {
        GameObject GO= GameObject.Find("ZoomCanvas");
        ItemZoom itemzoom = GO.GetComponent<ItemZoom>();
        itemzoom.Zoom(this);
    }
}