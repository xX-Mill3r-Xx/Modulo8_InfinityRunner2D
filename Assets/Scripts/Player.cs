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

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            anim.SetBool("Jumping", false);
            isJumping = false;
        }
    }
}
