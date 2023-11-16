using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelect : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> cars;
    private int currentCar;
    CarSelectAnimation carSelectAnimation;

    private void Awake()
    {
        SelectCar(0);
        carSelectAnimation = GetComponent<CarSelectAnimation>();
    }

    private void SelectCar(int index)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            cars[i].SetActive(i == index);
        }
    }

    public void ChangeCar(int change)
    {
        currentCar += change;
        if (currentCar == cars.Count)
            currentCar = 0;
        else
            currentCar = cars.Count - 1;
        carSelectAnimation.isRotate = false;
        carSelectAnimation.Reset();
        SelectCar(currentCar);
    }
}
