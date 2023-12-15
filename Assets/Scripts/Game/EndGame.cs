using System.Collections;
using System.Collections.Generic;
using GLTF.Schema;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    private GameObject endGameWindow;

    [SerializeField]
    private TextMeshProUGUI totalScoresTxt;

    [SerializeField]
    private TextMeshProUGUI totalDistanceTxt;

    [SerializeField]
    private TextMeshProUGUI moneyTxt;

    private int money;

    public void End(int distance, int scores)
    {
        money = (distance + scores) / 100;
        endGameWindow.SetActive(true);
        totalDistanceTxt.text = distance.ToString();
        totalScoresTxt.text = scores.ToString();
        moneyTxt.text = money.ToString();
        MoneyManager moneyManager = new();
        moneyManager.AddMoney(money);
    }
}
