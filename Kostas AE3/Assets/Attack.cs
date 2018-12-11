using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public float VelocityX;
    public float VelocityY = 0f;
    public GameObject Arrow;
    Rigidbody2D Rigid;

    private void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigid.velocity = new Vector2(VelocityX, VelocityY);
            Destroy(gameObject, 3f);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dummy"))
        {
            Destroy (gameObject);
        }
    }
}
