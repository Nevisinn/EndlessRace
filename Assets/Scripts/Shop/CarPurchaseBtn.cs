using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class CarPurchaseBtn : MonoBehaviour
{
    public CarInfo carInfo { get; set; }

    [SerializeField]
    private TextMeshProUGUI carCostTxt;

    [SerializeField]
    NextBtn nextBtn;

    public void SetPurchaseBtn()
    {
        print(carInfo);
        this.gameObject.SetActive(false);
        carCostTxt.text = $"Купить за {carInfo.carCost}";
        if (!carInfo.isPurchased && YandexGame.savesData.Money >= carInfo.carCost)
            this.gameObject.SetActive(true);
    }

    public void BuyCar()
    {
        print(carInfo);
        carInfo.isPurchased = true;
        YandexGame.savesData.indexPurchasedCars[carInfo.indexCar] = carInfo.indexCar;
        YandexGame.savesData.Money -= carInfo.carCost;
        YandexGame.SaveProgress();
        SetPurchaseBtn();
        nextBtn.SetNextBtn();
    }
}
