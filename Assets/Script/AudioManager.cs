using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    public void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public AudioSource audioSource;
    public Dictionary<string, AudioClip> soundClip;

    public void AudioPlay(string audioName)
    {
        audioSource.PlayOneShot(soundClip[audioName]);
    }

    public void ChangeVolume(float value)
    {
        audioSource.volume = value;
    }
}
