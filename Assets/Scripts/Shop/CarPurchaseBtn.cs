using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class CarPurchaseBtn : MonoBehaviour
{
    public CarInfo carInfo { get; set; }

    [SerializeField]
    private TextMeshProUGUI carCostTxt;

    [SerializeField]
    NextBtn nextBtn;

    [SerializeField]
    private Button purchaseBtn;

    public void SetPurchaseBtn()
    {
        print(carInfo);
        carCostTxt.text = $"Купить за {carInfo.carCost}";
        if (carInfo.isPurchased)
            carCostTxt.text = $"Куплено";
        purchaseBtn.interactable = false;
        if (!carInfo.isPurchased && YandexGame.savesData.Money >= carInfo.carCost)
            purchaseBtn.interactable = true;
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
