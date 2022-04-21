using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private float timer = 10f;

    [SerializeField]
    private GameObject touchIndicator;

    public TrashSpawner spawner;

    // Update is called once per frame
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        touchIndicator.transform.position = mousePos;
    }
}
