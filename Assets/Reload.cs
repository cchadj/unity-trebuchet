using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

    public Rigidbody rb;
    public GameObject boulderPrefab;
    public Transform sling;

    public HingeJoint hj;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire2"))
        {
            rb.mass = 15000;
            GameObject.Instantiate(boulderPrefab, sling, false);
        }
	}
}
