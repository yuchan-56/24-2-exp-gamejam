using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemZoom : MonoBehaviour
{
    public GameObject ZoomCanvas;
    public Image ItemImage;
    public TextMeshProUGUI ItemInfo;

    public void Awake()
    {
        ZoomCanvas.SetActive(false);
    }
    public void SetUp(Item item)
    {
        ZoomCanvas.SetActive(true);
        ItemImage.sprite = item.ItemImage;
        ItemInfo.text = item.ItemDescription;
    }

    public  void CloseCanvas()
    {
        ZoomCanvas.SetActive(false);
    }
}