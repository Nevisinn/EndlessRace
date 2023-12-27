using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [NonSerialized]
    public CarInfo carInfo;

    [SerializeField]
    private TextMeshProUGUI maxSpeed;

    [SerializeField]
    private TextMeshProUGUI acceleration;

    [SerializeField]
    private Image maxSpeedBar;

    [SerializeField]
    private Image accelerationBar;

    private int maxSpeedInGame = 500;
    private int maxacceleration = 10;

    public void SetStats()
    {
        maxSpeed.text = carInfo.maxSpeed.ToString();
        acceleration.text = carInfo.accelerationMultiplier.ToString();
        maxSpeedBar.fillAmount = (float)carInfo.maxSpeed / maxSpeedInGame;
        accelerationBar.fillAmount = (float)carInfo.accelerationMultiplier / maxacceleration;
    }
}
