using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public Inventory inventory;

    public void ClickDoor()
    {
        if(inventory.CheckItem(1))
        {
            SceneManager.LoadScene("Clear");
        }
        else
        {

        }
    }

}
