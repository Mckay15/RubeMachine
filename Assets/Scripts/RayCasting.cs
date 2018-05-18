using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour {
    public GameObject Ray_Base;
    RaycastHit hit;
    public int Mask;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Mask = LayerMask.NameToLayer("Player");

        if (Mask == -1)
        {
            print("fail no mask");
        }
        else
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, Mask))
            {

                print("Did Hit");
            }
            else
            {
                print("Did not Hit");
            }
        }
    }
}
