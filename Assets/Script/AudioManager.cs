using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static private AudioManager instance;

    static public AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AudioManager();
            }

            return instance;
        }
    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    public AudioSource audioSource;
    public Dictionary<string, AudioClip> soundClip;

    public void AudioPlay(string audioName)
    {
        audioSource.PlayOneShot(soundClip[audioName]);
    }

}
