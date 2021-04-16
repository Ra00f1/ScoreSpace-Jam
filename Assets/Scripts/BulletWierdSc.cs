using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWierdSc : MonoBehaviour
{
    public float Speed = 20f;

    public Rigidbody2D rb;

    public BoxCollider2D coll;

    public int Damage;

    private Vector3 StartingPos;

    void Start()
    {
        StartingPos = gameObject.transform.position;
    }

    void Update()
    {
        transform.position = StartingPos + new Vector3(Mathf.Sin(Time.time), 0.0f, 0.0f);
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
