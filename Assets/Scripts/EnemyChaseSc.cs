using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseSc : MonoBehaviour
{
    public GameObject PLayerGO;

    private Transform Player;

    public float moveSpeed = 5f;

    public float MinDistance = 0f;
    public float MaxDistance = 10f;

    private Rigidbody2D rb;

    private Vector2 Movement;

    // Start is called before the first frame update
    void Start()
    {
        PLayerGO = GameObject.FindGameObjectWithTag("Player");
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Player = PLayerGO.transform;
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        Movement = direction;
    }
    private void FixedUpdate()
    {
        //moveCharacter(Movement);
        rb.MovePosition((Vector2)transform.position + (Movement * moveSpeed * Time.deltaTime));
    }
    void moveCharacter(Vector2 direction)
    {
        //if (Vector3.Distance(transform.position, Player.position) >= MinDistance)
        //{
            rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        //}
    }
}