using System.Collections;
using System.Collections.Generic;
using GLTF.Schema;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

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

    [SerializeField]
    private GameObject audioSources;

    [SerializeField]
    private AudioSource accidentSound;
    private int money;

    bool isRewardBtnClick;

    public void End(int distance, int scores)
    {
        money = (distance + scores) / 100;
        endGameWindow.SetActive(true);
        totalDistanceTxt.text = distance.ToString();
        totalScoresTxt.text = scores.ToString();
        moneyTxt.text = money.ToString();
        audioSources.SetActive(false);
        accidentSound.Play();
        YandexGame.NewLeaderboardScores("LeaderBordDistance", distance);
    }

    public void EndClick()
    {
        if (!isRewardBtnClick)
        {
            MoneyManager moneyManager = new();
            moneyManager.AddMoney(money);
        }
    }

    // Подписываемся на событие открытия рекламы в OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // Отписываемся от события открытия рекламы в OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

    // Подписанный метод получения награды
    void Rewarded(int id)
    {
        MoneyManager moneyManager = new();
        if (id == 1)
            moneyManager.AddMoney(money * 2);
        isRewardBtnClick = true;
        Time.timeScale = 0f;
    }

    // Метод для вызова видео рекламы
    public void ExampleOpenRewardAd(int id)
    {
        // Вызываем метод открытия видео рекламы
        YandexGame.RewVideoShow(id);
    }
}
