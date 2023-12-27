using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class VHSController : MonoBehaviour
{
    [SerializeField]
    private Toggle toggle;

    [SerializeField]
    private Volume globalVolume;

    public void SetVHS()
    {
        globalVolume.enabled = false;
        if (toggle.isOn)
            globalVolume.enabled = true;
    }
}
