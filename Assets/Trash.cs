using System;
using UnityEngine;

public abstract class Trash : MonoBehaviour
{
    public abstract float pointValue { get; }
    
    private void Start()
    {
        EventManager.OnTrashHitEvent += HitDetected;
    }

    private void HitDetected()
    {
        
    }

    private void OnDestroy()
    {
        EventManager.OnTrashHitEvent -= HitDetected;
    }
}
