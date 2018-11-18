using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FixedJoint))]
public class FireBoulder : MonoBehaviour {
    public GameEvent OnShootEventToRaise;
    public FixedJoint restrainHingeJoint;
    public Rigidbody throwingArmWeight;
    private float m_initialWeight;
	// Use this for initialization
	void Start () {
        m_initialWeight = throwingArmWeight.mass;

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1"))
        {
            throwingArmWeight.mass = 1f;
        }
	}
}
