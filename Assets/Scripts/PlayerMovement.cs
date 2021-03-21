using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 5f;

    public int Health = 3;

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

    public void GetDamaged()
    {
        Health--;
    }
}
