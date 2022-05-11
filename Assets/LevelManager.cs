using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private float gameTimer = 10f;

    [SerializeField]
    private float score = 0f;

    [SerializeField]
    float roseTimer = 2f;

    public GameObject OutOfBounds;
    public TrashSpawner spawner;
    public RoseSpawner roseSpawner;
    public Text scoreText;

    private float roseTimerReset;

    void Start()
    {
        roseTimerReset = roseTimer;
        scoreText.text = $"Score: {score}";
        EventManager.OnAddPoints += AddScore;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnRose();
        gameTimer -= 1 * Time.deltaTime;
    }

    public void AddScore(float points){
        score += points;
        scoreText.text = $"Score: {score}";
    }

    void SpawnRose(){
        roseTimer -= 1 * Time.deltaTime;

        if (roseTimer <= 0)
        {
            roseTimer = roseTimerReset;
        }
    }

    void OnDispose(){
        EventManager.OnAddPoints -= AddScore;
    }
}
