using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    private static int scores;

    [SerializeField]
    private TextMeshProUGUI currScores;

    void Update()
    {
        currScores.text = scores.ToString();
    }

    public void AddScores(int score)
    {
        scores += score;
    }
}
