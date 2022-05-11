using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rose : MonoBehaviour
{
    public float pointValue = 10f;

    [SerializeField]
    private int roseHealth = 1;
    
    private void Start() {
        EventManager.OnRoseHitEvent += RoseHit;
    }

    private void RoseHit()
    {
        roseHealth -= 1;

        if (roseHealth == 0)
        {
            // EventManager.RoseDestroyEvent(this);
        }
    }

    private void OnDestroy() {
        EventManager.OnRoseHitEvent -= RoseHit;
    }
}
