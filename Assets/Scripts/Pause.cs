using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class Pause : MonoBehaviour
{
    private bool isPause;

    [SerializeField]
    private GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
                Resume();
            else
                PauseOn();
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
        YandexGame.SaveProgress();
    }

    public void PauseOn()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
}
