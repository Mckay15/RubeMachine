using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_force : MonoBehaviour
{
    private Rigidbody rb;
    public int The_Force = 0;

    void OnTriggerEnter(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        rb.AddForce(Vector3.left * The_Force);
    }



}

