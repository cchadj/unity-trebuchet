using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnTriggerRaise : MonoBehaviour {

    public GameEvent gameEvent;

    public void OnTriggerEnter(Collider other)
    {
        gameEvent.Raise();
    }
}
