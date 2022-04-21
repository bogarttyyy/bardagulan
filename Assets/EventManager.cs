using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action DebugSpawnEvent;
    public static event Action OnSliceDragEvent;
    public static event Action OnSliceUpEvent;
    public static event Action OnTrashHitEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DebugSpawnEvent?.Invoke();        
        }

        if (Input.GetMouseButtonDown(0))
        {
            OnSliceDragEvent?.Invoke();
        }

        if (Input.GetMouseButtonUp(0))
        {
            OnSliceUpEvent?.Invoke();
        }
    }

    public static void TrashHitEvent(){
        OnTrashHitEvent?.Invoke();
    }
}
