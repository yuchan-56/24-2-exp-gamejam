using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemZoom : MonoBehaviour
{
    public GameObject ZoomCanvas;
    public Image ItemImage;
    public Image ItemInfo;

    public void Zoom(Item item)
    {
        ZoomCanvas.SetActive(true);
        ItemImage.sprite = item.Image;
        ItemInfo.sprite = item.Info;
    }
}