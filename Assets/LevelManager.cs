using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private float timer = 10f;

    [SerializeField]
    private float score = 0f;

    public TrashSpawner spawner;
    public Text scoreText;

    void Start()
    {
        EventManager.OnAddPoints += AddScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(float points){
        score += points;
        scoreText.text = $"Babi: {score}";
    }
}
