using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    Distance distance;

    [SerializeField]
    Scores scores;

    [SerializeField]
    EndGame endGame;

    [SerializeField]
    private SpawnManager spawnManager;

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.tag);

        if (other.gameObject.CompareTag("Spawn Trigger"))
            spawnManager.SpawnRoad();
        if (other.gameObject.CompareTag("Spawn Trigger Bots"))
        {
            spawnManager.SpawnBots();
        }
        // if (other.gameObject.CompareTag("Death Trigger"))
        // {
        //     Time.timeScale = 0f;
        //     endGame.End(distance.TotalDistance, scores.TotalScores);
        // }
        if (other.gameObject.CompareTag("Scores Trigger"))
        {
            scores.AddScores(200);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Death Trigger"))
        {
            Time.timeScale = 0f;
            endGame.End(distance.TotalDistance, scores.TotalScores);
        }
    }
}
