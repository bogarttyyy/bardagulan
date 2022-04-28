using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCollider : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        #region Touch Hit Detect
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.zero);

            if (hit.collider)
            {
                // HIT
                GameObject hitGameObject = hit.collider.gameObject;

                Debug.Log($"{hitGameObject.name}: {hitGameObject.transform.position}");
                
                EventManager.TrashHitEvent();
                Destroy(hit.collider.gameObject);
            }

            
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // float distance;

            // if()
        }   
        #endregion
    }
}
