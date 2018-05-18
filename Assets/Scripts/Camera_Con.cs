using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Con : MonoBehaviour {

    public float Z = 0;
    public float Y = 0;
    public float X = 0;
    public GameObject Sphere; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(Sphere.transform.position.x - X, Sphere.transform.position.y - Y, Sphere.transform.position.z - Z);
	}
}
