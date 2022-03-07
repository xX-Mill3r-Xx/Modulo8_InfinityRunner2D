using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy_Plataforms : MonoBehaviour
{

    public GameObject enemyPrefab;
    private GameObject currentEnemy;
    public List<Transform> points = new List<Transform>();

    void Start()
    {
        CreateEnemy();
    }

    void Update()
    {
        
    }

    public void SpawnEnemyCreate()
    {
        if (currentEnemy == null)
        {
            CreateEnemy();
        }
    }

    void CreateEnemy()
    {
        int pos = Random.Range(0, points.Count);
        GameObject e = Instantiate(enemyPrefab, points[pos].position, points[pos].rotation);
        currentEnemy = e;
    }
}
