using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    [SerializeField]
    public int TotalScores;

    [SerializeField]
    private TextMeshProUGUI currScores;

    void Update()
    {
        print(currScores);
        currScores.text = TotalScores.ToString();
    }

    public void AddScores(int score)
    {
        TotalScores += score;
    }
}
