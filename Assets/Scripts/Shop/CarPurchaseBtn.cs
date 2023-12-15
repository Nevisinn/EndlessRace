using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarPurchaseBtn : MonoBehaviour
{
    public CarInfo carInfo { get; set; }

    [SerializeField]
    private TextMeshProUGUI carCostTxt;

    public void SetPurchaseBtn()
    {
        this.gameObject.SetActive(false);
        carCostTxt.text = $"Купить за {carInfo.carCost}";
        if (!carInfo.isPurchased && Progress.Instance.playerInfo.Money >= carInfo.carCost)
            this.gameObject.SetActive(true);
    }

    public void BuyCar()
    {
        carInfo.isPurchased = true;
        Progress.Instance.playerInfo.purchasedCars.Add(this.gameObject);
        Progress.Instance.playerInfo.Money -= carInfo.carCost;
        SetPurchaseBtn();
    }
}
