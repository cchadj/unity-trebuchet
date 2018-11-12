using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllMass : MonoBehaviour {

    public Rigidbody rb;

	// Update is called once per frame
	void Update ()
    {
        rb.mass += Input.GetAxis("Vertical") * Time.deltaTime;
	}
}
