using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class MusicController : MonoBehaviour
{
    [SerializeField]
    private List<AudioClip> bgMusics;
    private int currentMusic;
    private AudioSource audioSource;

    bool IsPaused = false;

    void Awake()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void OnApplicationPause(bool pauseStatus)
    {
        IsPaused = pauseStatus;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            ChangeMusic(1);
        if (Input.GetKeyDown(KeyCode.Q))
            ChangeMusic(-1);
        if (!audioSource.isPlaying && !IsPaused)
            ChangeMusic(1);
    }

    void Start()
    {
        PlayMusic(currentMusic);
    }

    void PlayMusic(int musicIndex)
    {
        audioSource.clip = bgMusics[musicIndex];
        audioSource.Play();
    }

    private void ChangeMusic(int change)
    {
        currentMusic += change;
        if (currentMusic == bgMusics.Count)
            currentMusic = 0;
        else if (currentMusic == -1)
            currentMusic = bgMusics.Count - 1;
        PlayMusic(currentMusic);
    }
}
