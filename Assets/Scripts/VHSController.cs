using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using YG;

public class VHSController : MonoBehaviour
{
    [SerializeField]
    private Toggle toggle;

    [SerializeField]
    private Volume globalVolume;

    private void Awake()
    {
        if (YandexGame.SDKEnabled)
            GetLoad();
    }

    private void GetLoad()
    {
        toggle.isOn = YandexGame.savesData.inVHSOn;
    }

    public void SetVHS()
    {
        globalVolume.enabled = false;
        if (toggle.isOn)
            globalVolume.enabled = true;
        YandexGame.savesData.inVHSOn = toggle.isOn;
    }

    public void SaveVHSSetting()
    {
        YandexGame.SaveProgress();
    }
}
