using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Noise : MonoBehaviour
{
    public AudioSource AS;

     void OnCollisionEnter(Collision collision)
     {
        AS.Play();
     }
}
