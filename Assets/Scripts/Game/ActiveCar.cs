using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using YG;

public class ActiveCar : MonoBehaviour
{
    [SerializeField]
    private BotsSpawner botsSpawner;

    [SerializeField]
    private AudioController audioController;

    // Подписываемся на событие GetDataEvent в OnEnable
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    // Отписываемся от события GetDataEvent в OnDisable
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    public List<CarInfo> CarsInfo;

    private void Awake()
    {
        if (YandexGame.SDKEnabled)
            GetLoad();
    }

    private void GetLoad()
    {
        foreach (var car in CarsInfo)
        {
            if (car.indexCar == YandexGame.savesData.lastCar)
            {
                car.gameObject.SetActive(true);
                botsSpawner.playerTransform = car.gameObject.GetComponent<Transform>();
                var audioSource = car.gameObject
                    .GetComponent<CarController>()
                    .carEngineSound.gameObject;
                audioSource.SetActive(true);
                audioController.audioSourceCar = audioSource.GetComponent<AudioSource>();
                audioController.audioSourceCar.volume = YandexGame.savesData.sliderCarVolume;
            }
        }
    }
}
