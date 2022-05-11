using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    public GameObject endScreen;
    public TextMeshProUGUI endScore;

    private float roseTimerReset;

    void Start()
    {
        roseTimerReset = roseTimer;
        scoreText.text = $"Score: {score}";
        EventManager.OnAddPoints += AddScore;
        EventManager.OnGameOver += GameOver;
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

    public void GameOver(){
        endScore.text = $"{score}";
        endScreen.SetActive(true);
    }

    void SpawnRose(){
        roseTimer -= 1 * Time.deltaTime;

        if (roseTimer <= 0)
        {
            roseTimer = roseTimerReset;
        }
    }

    void OnDestroy(){
        EventManager.OnAddPoints -= AddScore;
        EventManager.OnGameOver -= GameOver;
    }
}
