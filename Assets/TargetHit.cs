using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour {
    
    public GameEvent eventToTriggerOnHit;
    public GameEvent evetnToTriggerOnDirectBoulderHit;
    public Collider boulder;
    public bool userFired = false;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(userFired)
            eventToTriggerOnHit.Raise();
        if (collision.collider.name == boulder.name)
            evetnToTriggerOnDirectBoulderHit.Raise();

    }
}
