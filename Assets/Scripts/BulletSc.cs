using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSc : MonoBehaviour
{
    public float Speed = 20f;

    public Rigidbody2D rb;

    public BoxCollider2D coll;

    public int Damage;

    void Update()
    {
        rb.velocity = transform.right * Speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        collision.GetComponent<EnemyStats>().GetDamage(Damage);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
