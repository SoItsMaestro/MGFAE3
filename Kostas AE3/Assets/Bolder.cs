using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolder : MonoBehaviour
{
    public GameObject Player;
    Vector2 BolderFall;

    Rigidbody2D rigid;

    private ShakeBehavior Shaking;
    
	
	void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	
	void Update ()
    {
	
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))        
            rigid.isKinematic = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(Player);
        }
        if(collision.gameObject.CompareTag("Ground"))
        {

            Destroy(gameObject);
        }
    }

}
