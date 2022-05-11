using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class RoseSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> roseCollection;
    private float spawnTime = 2f;

    private float spawnReset;

    void Start(){
        // SpawnTimerReset();
        EventManager.OnSpawnRoseEvent += SpawnRose;
    }

    // Update is called once per frame
    void Update()
    {
        // spawnTime -= 1 * Time.deltaTime;

        // if (spawnTime < 0)
        // {
        //     SpawnTimerReset();
        //     SpawnRose();
        // }
    }

    // void SpawnTimerReset(){
    //     spawnReset = spawnTime;
    // }

    void SpawnRose(){
        var rose = Instantiate(roseCollection.First());
        
        float pos = RandomizeSpawnPositionX();

        rose.transform.position = new Vector2(pos, transform.position.y);
    }

    private float RandomizeSpawnPositionX()
    {
        // x = between 7 and -7
        var x = Random.Range(-7f, 7f);

        return x;
    }

    void OnDestroy() {
        EventManager.OnSpawnRoseEvent -= SpawnRose;
    }
}
