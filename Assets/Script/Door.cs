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
        if(inventory.CheckItem(1))
        {
            SceneManager.LoadScene("Clear");
            AudioManager.Instance.SFXPlay("KeyOpen");
        }
        else
        {
            locked.SetActive(true);
            AudioManager.Instance.SFXPlay("KeyFail");
        }
    }

}
