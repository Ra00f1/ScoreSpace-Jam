using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 5f;

    public int Health = 3;

    public Image Heart1;
    public Image Heart2;
    public Image Heart3;

    public Sprite HeartSF;
    public Sprite HeartSE;

    public Rigidbody2D rb;
    public Collider2D coll;

    Vector2 movement;
    
    void Start()
    {
        coll = gameObject.GetComponent<Collider2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Health <= 0)
        {
            Destroy(gameObject);

            Heart1.sprite = HeartSE;
            Heart2.sprite = HeartSE;
            Heart3.sprite = HeartSE;
        }
        if (Health == 3)
        {
            Heart1.sprite = HeartSF;
            Heart2.sprite = HeartSF;
            Heart3.sprite = HeartSF;
        }
        if (Health == 2)
        {
            Heart1.sprite = HeartSF;
            Heart2.sprite = HeartSF;
            Heart3.sprite = HeartSE;
        }
        if (Health == 1)
        {
            Heart1.sprite = HeartSF;
            Heart2.sprite = HeartSE;
            Heart3.sprite = HeartSE;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Attackers")
        {
            EnemyStats EnemyStats = collision.gameObject.GetComponent<EnemyStats>();
            EnemyStats.Death();
            GetDamaged();
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MovementSpeed * Time.deltaTime);
    }

    public void GetDamaged()s
    {
        Health--;
    }

    public void GetHealty()
    {
        Health++;
    }
}
