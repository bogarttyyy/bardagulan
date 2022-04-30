using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchIndicator : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("HIT");

        if (col.gameObject.TryGetComponent<Trash>(out Trash result))
        {
            EventManager.TrashHitEvent(result);
            Destroy(col.gameObject);
        }
    }
}
