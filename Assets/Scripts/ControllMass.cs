using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllMass : MonoBehaviour {

    public Rigidbody rb;
    public float multiplier;

	// Update is called once per frame
	void Update ()
    {
        rb.mass += Input.GetAxis("VerticalUpDown") * multiplier * Time.deltaTime;
	}
}
