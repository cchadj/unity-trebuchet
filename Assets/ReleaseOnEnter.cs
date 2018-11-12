using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FixedJoint))]
public class ReleaseOnEnter : MonoBehaviour {

    public FixedJoint restrainHingeJoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            restrainHingeJoint.breakForce = 0;
        }
	}
}
