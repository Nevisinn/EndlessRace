using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;

public class BotsSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> botsPrefabs;

    private List<List<GameObject>> botsGroup = new List<List<GameObject>>();

    [SerializeField]
    private List<GameObject> positions;

    public Transform playerTransform;

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
        int carsCount = Random.Range(lastPos.Count / 8, lastPos.Count + 1);
        var randomNumbers = Enumerable.Range(0, 16).OrderBy(k => Random.Range(0, 16)).ToArray();
        print(carsCount);
        print(string.Join(" ", randomNumbers));
        for (int i = 0; i < carsCount; i++)
        {
            int random = Random.Range(350 + 20 * i, 365 + 20 * i);
            print(
                new Vector3(
                    lastPos[randomNumbers[i]].transform.position.x,
                    lastPos[randomNumbers[i]].transform.position.y,
                    playerTransform.position.z - random
                )
            );
            Instantiate(
                botsPrefabs[Random.Range(0, botsPrefabs.Count)],
                new Vector3(
                    lastPos[randomNumbers[i]].transform.position.x,
                    lastPos[randomNumbers[i]].transform.position.y,
                    playerTransform.position.z - random
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
