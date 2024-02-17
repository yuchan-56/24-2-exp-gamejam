using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Start()
    {
        AudioManager.Instance.AudioPlay("GameOver");
    }
    public void Retry()
    {
        AudioManager.Instance.SFXPlay("Button");
        SceneManager.LoadScene("MainMenu");
    }
}
