using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class RagingSwipeMovement : MonoBehaviour
{

    public int speed;
    public Rigidbody2D rb;

    // Use this for initialization


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("BossAttack"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag ("Player"))
        {
            StaticHealth.health -= 3;
            Destroy(gameObject);
        }

    }
}
