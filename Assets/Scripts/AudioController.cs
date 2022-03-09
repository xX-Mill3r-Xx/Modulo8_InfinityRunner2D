using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip Gunsfx;
    public AudioClip jumpSfx;
    public AudioClip coinSfx;
    public AudioClip bulletSfx;
    public AudioClip explosionBullet;
    public AudioClip hitSfx;
    public AudioClip jetPacSfx;

    public AudioClip BGM;

    private AudioSource audioSource;

    public static AudioController current;

    void Start()
    {
        current = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    //public void ChangeBGM()
    //{
    //    audioSource.clip = sfx;
    //}
}
