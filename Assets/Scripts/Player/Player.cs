using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public int health;

    private Rigidbody2D rig;
    private bool isJumping;
    public Animator anim;
    public float speed;
    public float jump;
    public float jetPack;

    public PlayerLife life;
    public GameObject bulletPrefab;
    public GameObject jetPackFX;
    public Transform Fire_Point;
    public Transform Smoke_jetPackFX;

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

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            anim.SetBool("Jumping", true);
            rig.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    public void JetPack()
    {
        if (Input.GetButtonDown("Fire2") && isJumping)
        {
            rig.AddForce(Vector2.up * jetPack, ForceMode2D.Impulse);
            anim.SetBool("jetpack", true);
            GameObject e = Instantiate(jetPackFX, Smoke_jetPackFX.transform.position, Smoke_jetPackFX.transform.rotation);
            Destroy(e, 0.29f);

        }
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, Fire_Point.transform.position, Fire_Point.transform.rotation);
        }

        //AudioController.current.PlayMusic(AudioController.current.sfx);
    }

    public void OnHit(int dmg)
    {
        life.health -= dmg;
        anim.SetBool("hit", true);
        life.heartsCount = life.health;
        if(life.health <= 0)
        {
            GameController.instance.ShowGameOver();
        }
    }

    IEnumerator HitFalse()
    {
        yield return new WaitForSeconds(0.33f);
        anim.SetBool("hit", false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        StartCoroutine(HitFalse());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            anim.SetBool("Jumping", false);
            anim.SetBool("jetpack", false);
            isJumping = false;
        }

        if(collision.gameObject.layer == 6)
        {
            anim.SetBool("hit", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            collision.GetComponent<Animator>().SetTrigger("hit");
            GameControllerUI.instance.GetCoin();
            Destroy(collision.gameObject, 0.29f);
        }
    }
}
