using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        AudioManager.Instance.AudioPlay("Menu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainStage");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
