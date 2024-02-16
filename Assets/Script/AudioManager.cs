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
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        soundClip.Add("Menu", clipList[0]);
        soundClip.Add("Ingame", clipList[1]);
        soundClip.Add("Clearend", clipList[2]);
        soundClip.Add("Gameover", clipList[3]);

        soundClip.Add("Button", clipList[4]);
        soundClip.Add("KeyOpen", clipList[5]);
        soundClip.Add("KeyFail", clipList[6]);
        soundClip.Add("Paper", clipList[7]);
        soundClip.Add("FireOn", clipList[8]);
        soundClip.Add("FireOff", clipList[9]);
        soundClip.Add("KeyDrop", clipList[10]);
        soundClip.Add("EndScream", clipList[11]);
    }

    public AudioSource audioSource;
    public AudioSource SFXSource;
    public List<AudioClip> clipList;
    public Dictionary<string, AudioClip> soundClip;

    public void AudioPlay(string audioName)
    {
        audioSource.PlayOneShot(soundClip[audioName]);
    }

    public void SFXPlay(string SFXName)
    {
        SFXSource.PlayOneShot(soundClip[SFXName]);
    }

    public void ChangeVolume(float value)
    {
        audioSource.volume = value;
    }
}
