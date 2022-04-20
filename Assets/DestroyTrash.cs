using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.TryGetComponent<Trash>(out Trash result))
        {
            Destroy(col.gameObject);
        }
    }
}
