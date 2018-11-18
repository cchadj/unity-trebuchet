using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloacController : MonoBehaviour {

    Queue<GameObject> trebuchetQueues;
    private int amnt = 100;
    public GameObject trebuchetPrefab;
    private UpdateTextWith m_updateTextWithRbWeightScript;
    public maxCamera maxCamera;
	// Use this for initialization
	void Awake () {
        trebuchetQueues = new Queue<GameObject> ();
        for (int i = 0; i < amnt; i++)
        {
            GameObject go = GameObject.Instantiate(trebuchetPrefab);
            go.SetActive(false);
            trebuchetQueues.Enqueue(go);
        }
        maxCamera.target = curTrebuchet.transform;
        m_updateTextWithRbWeightScript = GetComponent<UpdateTextWith>();
        m_updateTextWithRbWeightScript.rb = m_updateTextWithRbWeightScript.rb = curTrebuchet.transform.Find("ThrowingArm").Find("CounterWeight").GetComponent<Rigidbody>();

    }

    public GameObject curTrebuchet;
    private int clickCounter = 0;
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Fire2"))
        {
            if (clickCounter % 2 == 0)
            {
                clickCounter++;
                return;
            }

            Vector3 oldTrebuchetTransform = curTrebuchet.transform.position;
            Quaternion oldTrebuchetQuaternion = curTrebuchet.transform.rotation;
            GameObject.Destroy(curTrebuchet);
            curTrebuchet = trebuchetQueues.Dequeue();
            curTrebuchet.transform.position = oldTrebuchetTransform;
            curTrebuchet.transform.rotation = oldTrebuchetQuaternion;

            m_updateTextWithRbWeightScript.rb = curTrebuchet.transform.Find("ThrowingArm").Find("CounterWeight").GetComponent<Rigidbody>();

            curTrebuchet.SetActive(true);
            maxCamera.target = curTrebuchet.transform;
            clickCounter++;
        }
		
	}
}
