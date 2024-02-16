using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            && index[2] == true && index[3] == false)
        {
            Clear();
        }
    }

    private void Clear()
    {
        isCorrect = true;
        Debug.Log("Correct!");
        gameObject.SetActive(false);
        inventory.GetItem(0);
        AudioManager.Instance.SFXPlay("KeyDrop");
    }
}
