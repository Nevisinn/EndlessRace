using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class ResetProgress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        YandexGame.ResetSaveProgress();
        YandexGame.SaveProgress();
    }
}
