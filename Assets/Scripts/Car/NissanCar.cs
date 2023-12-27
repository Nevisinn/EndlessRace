using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using System.Linq;

public class NissanCar : CarInfo
{
    private void Start()
    {
        indexCar = 1;
        carCost = 500;
        maxSpeed = 200;
        accelerationMultiplier = 5;
        isPurchased = YandexGame.savesData.indexPurchasedCars.Contains(this.indexCar);
    }
}
