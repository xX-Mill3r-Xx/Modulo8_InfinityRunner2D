using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_LifePac : MonoBehaviour
{
    public GameObject lifePac;
    private GameObject currentLife;
    public List<Transform> points = new List<Transform>();

    void Start()
    {
        CreateLife();
    }

    void Update()
    {
        if (currentLife == null)
        {
            CreateLife();
        }
    }

    void CreateLife()
    {
        int pos = Random.Range(0, points.Count);
        GameObject e = Instantiate(lifePac, points[pos].position, points[pos].rotation);
        currentLife = e;
    }
}
