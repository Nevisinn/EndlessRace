using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarSelectAnimation : MonoBehaviour
{
    [NonSerialized]
    public bool isRotate = false;
    private Quaternion originalPos;

    void Start()
    {
        originalPos = transform.rotation;
    }

    void Update()
    {
        if (isRotate)
            transform.RotateAround(gameObject.transform.position, Vector3.up, 20 * Time.deltaTime);
    }

    public void RotateLeft()
    {
        transform.RotateAround(gameObject.transform.position, -Vector3.up, 100 * Time.deltaTime);
    }

    public void RotateRight()
    {
        transform.RotateAround(gameObject.transform.position, Vector3.up, 100 * Time.deltaTime);
    }

    public void Rotate()
    {
        isRotate = !isRotate;
    }

    public void Reset()
    {
        transform.rotation = originalPos;
    }
}
