using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.TryGetComponent<Trash>(out Trash result))
        {
            EventManager.TrashOutOfBoundsEvent();
            Destroy(col.gameObject);
        }

        if (col.gameObject.TryGetComponent<Rose>(out Rose roseObject))
        {
            Destroy(roseObject.gameObject);
        }
    }
}
