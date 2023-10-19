using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class BotsMoving : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    private float speed = 10f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        m_Rigidbody.velocity = transform.forward * speed;
    }
}
