using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public void AddMoney(int money)
    {
        Progress.Instance.playerInfo.Money += money;
    }
}
