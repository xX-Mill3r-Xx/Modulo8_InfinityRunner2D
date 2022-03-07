using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rig;
    private bool isJumping;
    public Animator anim;
    public float speed;
    public float jump;
    public float jetPack;

    public GameObject bulletPrefab;
    public Transform Fire_Point;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
        Shoot();
        JetPack();
    }

    private void FixedUpdate()
    {
        Move();
        
    }

    void Move()
    {
        rig.velocity = new Vector2(speed, rig.velocity.y);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            anim.SetBool("Jumping", true);
            rig.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    void JetPack()
    {
        if (Input.GetButtonDown("Fire2") && !isJumping)
        {
            anim.SetBool("jetpack", true);
            rig.AddForce(Vector2.up * jetPack, ForceMode2D.Impulse);
        }
    }

    void Shoot()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(bulletPrefab, Fire_Point.transform.position, Fire_Point.transform.rotation);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            anim.SetBool("Jumping", false);
            anim.SetBool("jetpack", false);
            isJumping = false;
        }
    }
}
