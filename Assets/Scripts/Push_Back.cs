using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push_Back : MonoBehaviour {

    private Rigidbody rb;
    public int The_Force = 0;

    void OnTriggerEnter(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        rb.AddForce(Vector3.back * The_Force);
    }
}