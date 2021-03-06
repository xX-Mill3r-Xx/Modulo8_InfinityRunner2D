using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip Gunsfx;
    public AudioClip jumpSfx;
    public AudioClip coinSfx;
    public AudioClip bulletSfx;
    public AudioClip explosionBullet;
    public AudioClip hitSfx;
    public AudioClip jetPacSfx;
    public AudioClip BGM;
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

    #region ChangeBGM
    //public void ChangeBGM()
    //{
    //    audioSource.clip = sfx;
    //}
    #endregion
}
