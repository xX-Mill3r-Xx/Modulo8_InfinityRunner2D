using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : Enemy
{
    private Rigidbody2D rig;
    private Player player;
    public float speed;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject,5);
    }

    private void FixedUpdate()
    {
        rig.velocity = Vector2.left * speed;
    }

    //protected override void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        player.OnHit(damage);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.OnHit(damage);
        }

        if (other.CompareTag("Bullet"))
        {
            int dmg = other.GetComponent<PlayerProjetil>().damage;
            other.GetComponent<PlayerProjetil>().OnHit();
            ApplyDamage(dmg);
        }
    }
}
