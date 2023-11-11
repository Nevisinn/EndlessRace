using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TestCarController : MonoBehaviour
{
    public GameObject frontLeftMesh;
    public WheelCollider frontLeftCollider;
    public GameObject frontRightMesh;
    public WheelCollider frontRightCollider;
    public GameObject rearLeftMesh;
    public WheelCollider rearLeftCollider;
    public GameObject rearRightMesh;
    public WheelCollider rearRightCollider;

    [SerializeField]
    private float currentSpeed = 12;

    [SerializeField]
    private float maxSpeed = 200;

    [SerializeField, Range(10, 100)]
    private float turningSpeed;
    private Rigidbody carRigidbody;
    float hMovement;
    public float maxSteerAngle = 15f;

    // Start is called before the first frame update
    void Start()
    {
        carRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && currentSpeed < maxSpeed)
        {
            currentSpeed += 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentSpeed -= 0.1f;
        }

        float steerInput = Input.GetAxis("Horizontal"); // Получаем ввод от клавиатуры или геймпада

        // Ограничиваем угол поворота
        float clampedSteerAngle = Mathf.Clamp(
            steerInput * maxSteerAngle,
            -maxSteerAngle,
            maxSteerAngle
        );

        // Устанавливаем угол поворота передних колес
        frontLeftCollider.steerAngle = clampedSteerAngle;
        frontRightCollider.steerAngle = clampedSteerAngle;

        frontLeftMesh.transform.Rotate(Vector3.right, currentSpeed * Time.deltaTime);
        frontRightMesh.transform.Rotate(Vector3.right, currentSpeed * Time.deltaTime);
        rearLeftMesh.transform.Rotate(Vector3.right, currentSpeed * Time.deltaTime);
        rearRightMesh.transform.Rotate(Vector3.right, currentSpeed * Time.deltaTime);
        transform.Translate(
            new Vector3(hMovement * maxSteerAngle, 0, currentSpeed) * Time.deltaTime
        );
    }
}
