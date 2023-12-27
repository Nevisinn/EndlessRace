using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class TotalMoney : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI totalMoney;

    private void Update()
    {
        totalMoney.text = $"На вашем балансе: {YandexGame.savesData.Money}$";
    }
}
