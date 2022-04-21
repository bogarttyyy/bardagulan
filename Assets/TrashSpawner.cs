using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TrashSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> TrashCollection;

    public float forceX = 10f;
    public float forceY = 10f;

    private float spawnTime = 1f;

    void Start()
    {
        EventManager.DebugSpawnEvent += SpawnTrash;

        // StartCoroutine(TrashWave());
    }

    private void SpawnTrash()
    {
        var gameObject = Instantiate(TrashCollection[Random.Range(0,2)]);
        gameObject.transform.position = transform.position;

        float spawnX = RandomizedSpawnerPosition();

        gameObject.transform.position = RandomizedSpawnPos(spawnX, transform.position.y);

        // Debug.Log(gameObject.transform.position);

        if (gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb))
        {
            if(spawnX > 0){
                rb.AddForce(ThrowLeft());
            }
            else{
                rb.AddForce(ThrowRight());
            }
        }
    }

    private float RandomizedSpawnerPosition(){
        float result = Random.Range(0,2) * 11f;

        Debug.Log(result);

        if (result != 11f){
            result = -11f;
        }

        return result;
    }



    private Vector3 RandomizedSpawnPos(float x, float y){
        return new Vector3(x, Random.Range(-5f, y));
    }

    private Vector2 ThrowLeft(){
        return new Vector2(Random.Range(-300, -450), Random.Range(400, 500));
    }

    private Vector2 ThrowRight(){
        return new Vector2(Random.Range(300, 450), Random.Range(400, 500));
    }

    void OnDisable(){
        EventManager.DebugSpawnEvent -= SpawnTrash;
    }

    IEnumerator TrashWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            SpawnTrash();
        }
    }
}
