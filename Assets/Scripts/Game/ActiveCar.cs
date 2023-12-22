using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using YG;

public class ActiveCar : MonoBehaviour
{
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
            print(YandexGame.savesData.lastCar);
            print(car.indexCar);
            car.gameObject.SetActive(car.indexCar == YandexGame.savesData.lastCar);
        }
    }
}
