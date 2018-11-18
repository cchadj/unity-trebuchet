using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextWith : MonoBehaviour {
    public Text textField;
    public Rigidbody rb;
    public string prefix;
	// Update is called once per frame
	void Update () {
        textField.text =  prefix + " " + rb.mass;

    }
}
