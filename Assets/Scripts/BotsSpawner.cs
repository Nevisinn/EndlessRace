using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BotsSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> botsPrefabs;

    private List<List<GameObject>> botsGroup = new List<List<GameObject>>();

    [SerializeField]
    private List<GameObject> positions;

    [SerializeField]
    private Transform playerTransform;

    [SerializeField]
    private List<GameObject> tempList;

    [SerializeField]
    private GameObject temp;

    private void Awake()
    {
        botsGroup.Add(positions);
    }

    public void SpawnBots()
    {
        var lastPos = botsGroup[botsGroup.Count - 1];
        int carsCount = Random.Range(lastPos.Count / 4, lastPos.Count + 1);
        var randomNumbers = Enumerable.Range(0, 16).OrderBy(k => Random.Range(0, 16)).ToArray();
        for (int i = 0; i < carsCount; i++)
        {
            Instantiate(
                botsPrefabs[Random.Range(0, botsPrefabs.Count)],
                new Vector3(
                    lastPos[randomNumbers[i]].transform.position.x,
                    lastPos[randomNumbers[i]].transform.position.y,
                    playerTransform.position.z - Random.Range(400, 400 + 50 * i)
                ),
                Quaternion.identity,
                temp.transform
            );
        }
        foreach (Transform t in temp.transform.GetComponentInChildren<Transform>())
        {
            if (playerTransform.position.z < t.position.z)
                Destroy(t.gameObject);
        }

        Debug.Log("SpawnBots");
    }
}
