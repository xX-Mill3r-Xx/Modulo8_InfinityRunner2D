using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjetil : MonoBehaviour
{
    private Rigidbody2D rig;

    private bool explosionSfx;

    public GameObject expPrefab;
    public float speed;
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
        if (gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            OnHit();
        }

        if(collision.gameObject.layer == 6)
        {
            OnHit();
            GameControllerUI.instance.GetPoints();
        }

        if (collision.gameObject.layer == 6 && !explosionSfx)
        {
            explosionSfx = true;
            AudioController.current.PlayMusic(AudioController.current.explosionBullet);
        }
        explosionSfx = false;
    }
}
