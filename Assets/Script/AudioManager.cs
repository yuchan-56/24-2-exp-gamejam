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

        soundClip.Add("Menu", clipList[0]);
        soundClip.Add("Ingame", clipList[1]);
        soundClip.Add("Clearend", clipList[2]);
        soundClip.Add("Gameover", clipList[3]);
    }


    public AudioSource audioSource;
    public List<AudioClip> clipList;
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
