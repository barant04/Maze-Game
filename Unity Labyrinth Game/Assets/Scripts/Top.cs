using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    Rigidbody rb;
    float y;
    float d;
    float power;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        power = 10.0f;
        y = 0.0f;
        d = 0.0f;
    }
    void Update()
    {
        y = Input.GetAxis("Horizontal");
        d = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.AddForce(y * power, 0, d * power);
    }
}