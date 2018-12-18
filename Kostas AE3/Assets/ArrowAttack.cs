using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAttack : MonoBehaviour
{
    public float Speed;
    public float ArrowDmg;
    public float ExpDmg;
    public float AimDmg;
    public float FrostDmg;
    public float ArcDmg;
    public float BarrageDmg;

    Rigidbody2D Rigid;


    private void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Rigid.velocity = new Vector2(Speed * Time.deltaTime, 0);
        Destroy(gameObject, 3f);
    }   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {            
            Destroy(gameObject);
        }

        //if (collision.gameObject.CompareTag("Ground"))
        //{
        //    Destroy(gameObject);
        //}
    }      
}
