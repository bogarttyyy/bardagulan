using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDraw : MonoBehaviour
{
    [SerializeField]
    private GameObject lineObject;
    Coroutine drawing;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartLine();
        }

        if (Input.GetMouseButtonUp(0))
        {
            FinishLine();
        }
    }

    private void StartLine()
    {
        if (drawing != null)
        {
            StopCoroutine(drawing);
        }

        drawing = StartCoroutine(DrawLine());
    }

    private void FinishLine()
    {
        StopCoroutine(drawing);
    }

    IEnumerator DrawLine()
    {
        if (lineObject != null)
        {
            GameObject newObj = Instantiate(lineObject, new Vector3(0,0,0), Quaternion.identity);
            LineRenderer line = newObj.GetComponent<LineRenderer>();

            line.positionCount = 0;
            
            while (true)
            {
                Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                position.z = 0;
                line.positionCount++;
                line.SetPosition(line.positionCount-1, position);
                
                yield return null;
            }
        }
    }
}
