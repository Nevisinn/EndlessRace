using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> roadPrefabs;
    private float offset = 608f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(roadPrefabs[0].transform.position.z);
        Debug.Log(roadPrefabs[1].transform.position.z);
    }

    // Update is called once per frame
    void Update() { }

    public void MoveRoad()
    {
        GameObject moveRoad = roadPrefabs[0];
        roadPrefabs.Remove(moveRoad);
        float newZ = roadPrefabs[roadPrefabs.Count - 1].transform.position.z - offset;
        Debug.Log(newZ);
        moveRoad.transform.position = new Vector3(0, 0, newZ);
        roadPrefabs.Add(moveRoad);
        Debug.Log("Move Road");
    }
}
