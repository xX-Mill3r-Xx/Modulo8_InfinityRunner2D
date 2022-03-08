using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjetil : MonoBehaviour
{
    private Rigidbody2D rig;
    public float speed;
    public GameObject expPrefab;
    public int damage;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 1f);
    }

    private void FixedUpdate()
    {
        rig.velocity = Vector2.right * speed;
    }

    public void OnHit()
    {
        GameObject e = Instantiate(expPrefab, transform.position, transform.rotation);
        Destroy(e,0.29f);
        Destroy(gameObject); //This Line <=
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            OnHit();
        }
    }
}
