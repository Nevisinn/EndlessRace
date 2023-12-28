using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class NextBtn : MonoBehaviour
{
    [NonSerialized]
    public CarInfo carInfo;

    public void SetNextBtn()
    {
        print(carInfo);
        this.gameObject.SetActive(false);
        if (carInfo.isPurchased)
            this.gameObject.SetActive(true);
    }

    public void SetActiveCar()
    {
        YandexGame.savesData.lastCar = carInfo.indexCar;
        YandexGame.SaveProgress();
    }
}
