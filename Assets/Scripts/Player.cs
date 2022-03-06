using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;
    public Animator anim;
    public float speed;
    public float jump;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
        //anim.SetInteger("transicao", 3);
        rig.velocity = new Vector2(speed, rig.velocity.y);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //anim.SetInteger("transicao", 2);
            rig.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }
}
