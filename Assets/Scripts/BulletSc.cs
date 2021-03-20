using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSc : MonoBehaviour
{
    public float Speed = 20f;

    public Rigidbody2D rb;

    public BoxCollider2D coll;

    void Update()
    {
        rb.velocity = transform.right * Speed;
        Debug.Log("Uzi B Start");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
