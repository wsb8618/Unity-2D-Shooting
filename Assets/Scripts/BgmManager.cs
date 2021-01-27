using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : MonoBehaviour
{
    public AudioClip bgmClip;
    AudioSource audioSource;
    public GameObject bgmOnButton;
    public GameObject bgmOffButton;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.Play();
    }

    public void BgmOn()
    {
        audioSource.clip = bgmClip;
        audioSource.Play();
        bgmOnButton.SetActive(false);
        bgmOffButton.SetActive(true);
    }

    public void BgmOff()
    {
        audioSource.clip = bgmClip;
        audioSource.Stop();
        bgmOffButton.SetActive(false);
        bgmOnButton.SetActive(true);
    }
}
