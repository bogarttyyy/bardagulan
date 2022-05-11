using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{

    public static event Action DebugSpawnEvent;
    public static event Action OnSpawnRoseEvent;
    public static event Action OnSliceDragEvent;
    public static event Action OnSliceUpEvent;
    public static event Action OnRoseHitEvent;
    public static event Action OnTrashOutOfBounds;
    public static event Action<float> OnAddPoints;
    // public static event Action OnTrashHitEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DebugSpawnEvent?.Invoke();        
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            OnSpawnRoseEvent?.Invoke();
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

    public static void SpawnRoseEvent(){
        OnSpawnRoseEvent?.Invoke();
    }

    public static void RoseHitEvent(Rose rose){
        OnRoseHitEvent?.Invoke();
        Destroy(rose.gameObject);
    }

    public static void RoseDestroyEvent(Rose rose){
        OnAddPoints?.Invoke(rose.pointValue);
        Destroy(rose.gameObject);
    }

    public static void TrashHitEvent(Trash trash){
        OnAddPoints?.Invoke(trash.pointValue);
        Destroy(trash.gameObject);
    }

    public static void TrashOutOfBoundsEvent(){
        OnTrashOutOfBounds?.Invoke();
    }
}
