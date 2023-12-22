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

    void Awake()
    {
        if (YandexGame.SDKEnabled)
            GetLoad();
    }

    private void GetLoad()
    {
        YandexGame.savesData.Money += 1000;
        print("+1000");
        YandexGame.SaveProgress();
    }

    private void Update()
    {
        totalMoney.text = YandexGame.savesData.Money.ToString();
    }
}
