using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class MoneyManager : MonoBehaviour
{
    public void AddMoney(int money)
    {
        YandexGame.savesData.Money += money;
        YandexGame.SaveProgress();
    }
}
