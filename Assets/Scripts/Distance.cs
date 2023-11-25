using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField]
    private Transform playerTransform;

    [SerializeField]
    private TextMeshProUGUI currDistance;
    private Vector3 oldPos;
    private int totalDistance;
    private float time;
    private float timeDelay = 0.5f;
    private Scores scores = new Scores();

    void Start()
    {
        oldPos = playerTransform.position;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeDelay)
        {
            time = 0f;
            totalDistance += (int)Math.Round((playerTransform.position - oldPos).magnitude);
            oldPos = playerTransform.position;
            currDistance.text = totalDistance.ToString();
            scores.AddScores(1);
        }
    }
}
