using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    private float timer;
    public float spawnTimer;
    public List<GameObject> coinsPrefab = new List<GameObject>();

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTimer)
        {
            SpawnCoin();
            timer = 0f;
        }
    }

    void SpawnCoin()
    {
        Instantiate(coinsPrefab[Random.Range(0, coinsPrefab.Count)], transform.position + new Vector3(0, Random.Range(-4f, 4f), 0), transform.rotation);
    }
}
