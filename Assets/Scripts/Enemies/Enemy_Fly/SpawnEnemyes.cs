using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyes : MonoBehaviour
{
    private float timer;

    public List<GameObject> enemiesPrefab = new List<GameObject>();
    public float spawnTimer;

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
        Instantiate(enemiesPrefab[Random.Range(0,enemiesPrefab.Count)], transform.position + new Vector3(0,Random.Range(-2f,3.5f), 0), transform.rotation);
    }
}
