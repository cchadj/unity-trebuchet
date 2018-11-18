using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

    public Rigidbody rb;
    public GameObject boulderPrefab;
    public Transform sling;
    public maxCamera maxCamera;
    public Rigidbody connectedBody;
    public GameObject trebuchetPrefab;
    private int clickCounter = 0;
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire2"))
        {
            if(clickCounter % 2 == 0)
                rb.mass = 15000;
            clickCounter++;
        }
	}
}
