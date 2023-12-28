using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
using System;
using UnityEngine.Rendering;

public class Setting : MonoBehaviour
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

    [SerializeField]
    private Toggle toggle;

    [SerializeField]
    private Volume globalVolume;

    private void Awake()
    {
        if (YandexGame.SDKEnabled)
            GetLoad();
    }

    private void GetLoad()
    {
        print("загрузил настройки");
        sliderTotalVolume.value = YandexGame.savesData.sliderTotalVolume;
        sliderMusicVolume.value = YandexGame.savesData.sliderMusicVolume;
        sliderCarVolume.value = YandexGame.savesData.sliderCarVolume;
        toggle.isOn = YandexGame.savesData.inVHSOn;
        audioSourceBg.volume = sliderMusicVolume.value;

        AudioListener.volume = sliderTotalVolume.value;
        if (audioSourceCar != null)
            audioSourceCar.volume = sliderCarVolume.value;
    }

    // Подписываемся на событие GetDataEvent в OnEnable
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    // Отписываемся от события GetDataEvent в OnDisable
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;
}
