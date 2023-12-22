using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public int TotalDistance;
    private Transform playerTransform;
    Scores scores;

    [SerializeField]
    GameObject models;

    [SerializeField]
    private TextMeshProUGUI currDistance;
    private Vector3 oldPos;
    private float time;
    private float timeDelay = 0.5f;

    void Awake()
    {
        scores = gameObject.GetComponent<Scores>();
        var cars = models.GetComponent<ActiveCar>().CarsInfo;
        foreach (var car in cars)
        {
            if (car.gameObject.activeSelf)
                playerTransform = car.gameObject.GetComponent<Transform>();
        }
        oldPos = playerTransform.position;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= timeDelay)
        {
            time = 0f;
            TotalDistance += (int)Math.Round((playerTransform.position - oldPos).magnitude);
            oldPos = playerTransform.position;
            currDistance.text = TotalDistance.ToString();
            scores.AddScores(1);
        }
    }
}
