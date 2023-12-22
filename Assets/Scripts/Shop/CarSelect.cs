using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class CarSelect : MonoBehaviour
{
    [SerializeField]
    private List<CarInfo> cars;
    public int currentCar;
    CarSelectAnimation carSelectAnimation;

    [SerializeField]
    CarPurchaseBtn carPurchaseBtn;

    [SerializeField]
    NextBtn nextBtn;

    private void Awake()
    {
        foreach (var index in YandexGame.savesData.indexPurchasedCars)
            print(index);
        foreach (var car in cars)
            car.isActiveCar = false;
        SelectCar(0);
        carSelectAnimation = GetComponent<CarSelectAnimation>();
    }

    private void SelectCar(int index)
    {
        print(index);
        for (int i = 0; i < transform.childCount; i++)
        {
            cars[i].gameObject.SetActive(i == index);
        }
        carPurchaseBtn.carInfo = cars[index];
        carPurchaseBtn.SetPurchaseBtn();
        nextBtn.carInfo = cars[index];
        nextBtn.SetNextBtn();
    }

    public void ChangeCar(int change)
    {
        currentCar += change;
        if (currentCar == cars.Count)
            currentCar = 0;
        else if (currentCar == -1)
            currentCar = cars.Count - 1;
        carSelectAnimation.isRotate = false;
        carSelectAnimation.Reset();
        SelectCar(currentCar);
    }
}
