using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyes : MonoBehaviour
{
    public List<GameObject> enemiesPrefab = new List<GameObject>();
    private float timer;
    public float spawnTimer;

    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnTimer)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemiesPrefab[Random.Range(0,enemiesPrefab.Count)], transform.position + new Vector3(0,Random.Range(0f,3f), 0), transform.rotation);
    }
}
