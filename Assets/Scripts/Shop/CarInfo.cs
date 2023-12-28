using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using YG;

public class CarInfo : MonoBehaviour
{
    public int indexCar;
    public bool isActiveCar = false;
    public bool isPurchased = false;
    public int carCost;
    public int maxSpeed;
    public int accelerationMultiplier;

    private void Awake()
    {
        if (YandexGame.SDKEnabled)
            GetLoad();
    }

    private void GetLoad()
    {
        isPurchased = YandexGame.savesData.indexPurchasedCars.Contains(this.indexCar);
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    // Отписываемся от события GetDataEvent в OnDisable
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;
}
