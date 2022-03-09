using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberMan : Enemy
{
    private Player player;

    private float throwCount;
    public GameObject bombPrefab;
    public Transform fire_Point;
    public float throwTime;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Destroy(gameObject, 30);
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

    #region player.OnHit()
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
    #endregion
}
