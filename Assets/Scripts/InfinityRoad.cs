using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityRoad : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabRoad;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private List<GameObject> blocks;

    // Start is called before the first frame update
    void Start()
    {
        var last = blocks[blocks.Count - 1];
        var lastCollider = last.GetComponent<BoxCollider>();
        var block = Instantiate(
            prefabRoad,
            new Vector3(
                last.transform.position.x,
                last.transform.position.y,
                lastCollider.bounds.min.z
            ),
            Quaternion.identity
        );
        block.transform.SetParent(gameObject.transform);
        blocks.Add(block);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     float z = player.transform.position.z;
    //     var last = blocks[blocks.Count - 1];
    //     var lastCollider = last.GetComponent<BoxCollider>();
    //     Debug.Log($"z = {z}");
    //     Debug.Log($"last = {lastCollider.bounds.min.z}");

    //     if (z > lastCollider.bounds.min.z)
    //     {
    //         print("Генерация дорогия");
    //         var block = Instantiate(
    //             prefabRoad,
    //             new Vector3(
    //                 last.transform.position.x,
    //                 last.transform.position.y,
    //                 lastCollider.bounds.min.z
    //             ),
    //             Quaternion.identity
    //         );
    //         block.transform.SetParent(gameObject.transform);
    //         blocks.Add(block);
    //     }

    //     if (z < last.GetComponent<BoxCollider>().bounds.min.z)
    //     {
    //         print("Дорога удалена");
    //         blocks.RemoveAt(blocks.Count - 1);
    //     }
    // }
}
