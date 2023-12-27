using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInfo : MonoBehaviour
{
    public int indexCar;
    public bool isActiveCar = false;
    public bool isPurchased = false;
    public int carCost;

    [NonSerialized]
    public int maxSpeed;

    [NonSerialized]
    public int accelerationMultiplier;
}
