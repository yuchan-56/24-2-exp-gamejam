using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skull : MonoBehaviour
{
    public bool[] index = new bool[4];
    private bool isCorrect = false;
    public Inventory inventory;

    public void Change(int i)
    {
        if (index[i]) AudioManager.Instance.SFXPlay("FireOff");
        else AudioManager.Instance.SFXPlay("FireOn");
        index[i] = !index[i];
    }

    private void Update()
    {
        if (!isCorrect && index[0] == false && index[1] == true
            && index[2] == false && index[3] == true)
        {
            Clear();
        }
    }

    private void Clear()
    {
        isCorrect = true;
        gameObject.SetActive(false);
        inventory.GetItem(0);
        inventory.ZoomFirstItem(0);
        AudioManager.Instance.SFXPlay("KeyDrop");
    }
}
