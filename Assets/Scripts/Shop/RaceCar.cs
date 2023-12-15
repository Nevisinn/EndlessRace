using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RaceCar : CarInfo
{
    private void Awake()
    {
        // if (Progress.Instance.playerInfo.purchasedCars.Contains(this.gameObject))
        // {
        //     isPurchased = true;
        // }
        carCost = 0;
        maxSpeed = 150;
        accelerationMultiplier = 2;
    }
}
