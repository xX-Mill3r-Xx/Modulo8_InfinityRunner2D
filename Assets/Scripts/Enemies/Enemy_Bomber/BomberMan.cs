using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberMan : Enemy
{
    public GameObject bombPrefab;
    public Transform fire_Point;
    public float throwTime;
    private float throwCount;

    void Start()
    {
       
    }

    void Update()
    {
        throwCount += Time.deltaTime;

        if(throwCount >= throwTime)
        {
            Instantiate(bombPrefab,fire_Point.position, fire_Point.rotation);
            throwCount = 0f;
        }
    }
}
