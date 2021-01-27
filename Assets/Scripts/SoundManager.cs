using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip buttonClip;
    public AudioClip hitClip;
    public AudioClip fireClip;
    public AudioClip boomClip;
    public AudioClip itemClip;
    public AudioClip stageClip;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonClip()
    {
        audioSource.clip = buttonClip;
        audioSource.Play();
    }

    public void HitClip()
    {
        audioSource.clip = hitClip;
        audioSource.volume = 0.9f;
        audioSource.Play();
    }

    public void FireClip()
    {
        audioSource.clip = fireClip;
        audioSource.volume = 0.5f;
        audioSource.Play();
    }

    public void BoomClip()
    {
        audioSource.clip = boomClip;
        audioSource.Play();
    }

    public void ItemClip()
    {
        audioSource.clip = itemClip;
        audioSource.volume = 1f;
        audioSource.Play();
    }

    public void StageClip()
    {
        audioSource.clip = stageClip;
        audioSource.Play();
    }
}
