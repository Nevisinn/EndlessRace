using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCarController : MonoBehaviour
{
    [SerializeField]
    private float currentSpeed;

    [SerializeField]
    private float maxSpeed = 200;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * currentSpeed;
        if (Input.GetKey(KeyCode.W) && currentSpeed < maxSpeed)
        {
            currentSpeed += 1f;
        }
        if (currentSpeed > 15)
        {
            currentSpeed -= 0.05f;
        }
        transform.Translate(new Vector3(hMovement, 0, currentSpeed) * Time.deltaTime);
    }
}
