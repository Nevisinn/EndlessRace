using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        SelectCar(0);
        carSelectAnimation = GetComponent<CarSelectAnimation>();
    }

    private void SelectCar(int index)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            print(cars[1].gameObject);
            cars[0].gameObject.SetActive(i == index);
            carPurchaseBtn.carInfo = cars[index];
            carPurchaseBtn.SetPurchaseBtn();
            nextBtn.SetNextBtn(cars[i]);
        }
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
