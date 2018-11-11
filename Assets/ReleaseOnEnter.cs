using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class ReleaseOnEnter : MonoBehaviour {

    public HingeJoint restrainHingeJoint;

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
