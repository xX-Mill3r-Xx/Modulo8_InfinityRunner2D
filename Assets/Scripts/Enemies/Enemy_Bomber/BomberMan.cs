using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberMan : Enemy
{
    public GameObject bombPrefab;
    public Transform fire_Point;
    private Player player;
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

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        player.OnHit(damage);
    //    }

    //    if (other.CompareTag("Bullet"))
    //    {
    //        int dmg = other.GetComponent<PlayerProjetil>().damage;
    //        other.GetComponent<PlayerProjetil>().OnHit();
    //        ApplyDamage(dmg);
    //    }
    //}
}
