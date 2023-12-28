using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    private Slider sliderTotalVolume;

    [SerializeField]
    private Slider sliderCarVolume;

    [SerializeField]
    private Slider sliderMusicVolume;

    [SerializeField]
    private AudioSource audioSourceBg;

    [NonSerialized]
    public AudioSource audioSourceCar;

    private void Awake()
    {
        if (YandexGame.SDKEnabled)
            GetLoad();
    }

    private void GetLoad()
    {
        sliderTotalVolume.value = YandexGame.savesData.sliderTotalVolume;
        sliderMusicVolume.value = YandexGame.savesData.sliderMusicVolume;
        sliderCarVolume.value = YandexGame.savesData.sliderCarVolume;
    }

    // Подписываемся на событие GetDataEvent в OnEnable
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    // Отписываемся от события GetDataEvent в OnDisable
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void Update()
    {
        AudioListener.volume = sliderTotalVolume.value;
        audioSourceBg.volume = sliderMusicVolume.value;
        if (audioSourceCar != null)
            audioSourceCar.volume = sliderCarVolume.value;
    }

    public void SaveSettings()
    {
        YandexGame.savesData.sliderTotalVolume = sliderTotalVolume.value;
        YandexGame.savesData.sliderMusicVolume = sliderMusicVolume.value;
        YandexGame.savesData.sliderCarVolume = sliderCarVolume.value;
        YandexGame.SaveProgress();
    }
}
