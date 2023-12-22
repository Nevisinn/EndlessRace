using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using YG;

public class RaceCar : CarInfo
{
    private void Awake()
    {
        indexCar = 0;
        if (YandexGame.savesData.indexPurchasedCars.Contains(this.indexCar))
        {
            isPurchased = true;
        }
        carCost = 0;
        maxSpeed = 150;
        accelerationMultiplier = 2;
    }
}
