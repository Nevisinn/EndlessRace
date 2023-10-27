using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    BotsSpawner botsSpawner;

    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        botsSpawner = GetComponent<BotsSpawner>();
    }

    // Update is called once per frame
    void Update() { }

    public void SpawnRoad()
    {
        roadSpawner.MoveRoad();
    }

    public void SpawnBots()
    {
        botsSpawner.SpawnBots();
    }
}
