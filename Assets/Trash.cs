using System;
using UnityEngine;

public abstract class Trash : MonoBehaviour
{
    public abstract float pointValue { get; }
    
    private void Start()
    {
        EventManager.OnRoseHitEvent += RoseHitDetected;
    }

    private void RoseHitDetected()
    {
        EventManager.TrashHitEvent(this);
    }

    private void OnDestroy()
    {
        EventManager.OnRoseHitEvent -= RoseHitDetected;
    }
}
