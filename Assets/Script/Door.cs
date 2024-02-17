using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Inventory inventory;
    public GameObject locked;

    public void ClickDoor()
    {
        if(inventory.CheckItem(0))
        {
            AudioManager.Instance.SFXPlay("KeyOpen");
            AudioManager.Instance.AudioPlay("ClearEnd");
            SceneManager.LoadScene("Clear");
        }
        else
        {
            locked.SetActive(true);
            AudioManager.Instance.SFXPlay("KeyFail");
        }
    }

}
