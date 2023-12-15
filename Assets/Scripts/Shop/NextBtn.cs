using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBtn : MonoBehaviour
{
    public void SetNextBtn(CarInfo carInfo)
    {
        this.gameObject.SetActive(false);
        if (carInfo.isPurchased)
            this.gameObject.SetActive(true);
    }
}
