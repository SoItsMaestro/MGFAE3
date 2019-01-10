using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeVelocity : MonoBehaviour
{

    Rigidbody2D Rigid;

    public float ArrowVelX;
    public float ArrowVelY;
    public GameObject FreezeBlock;
    Vector2 FrzBlock;

    void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Rigid.velocity = new Vector2(ArrowVelX * Time.deltaTime, -ArrowVelY * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Plz");
        if (collision.gameObject.CompareTag("Ground"))
        {
            FrzBlock = transform.position;
            FrzBlock += new Vector2();
            Instantiate(FreezeBlock, FrzBlock, Quaternion.identity);
            Destroy(gameObject);
        }

        //if (collision.gameObject.CompareTag("Ground"))
        //{
        //    Destroy(gameObject);
        //}
    }
}
