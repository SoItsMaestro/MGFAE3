using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expvelocity : MonoBehaviour
{
    Rigidbody2D Rigid;   

    public float ArrowVelX;
    public float ArrowVelY;
    public GameObject ExplosiveBlock;
    Vector2 ExpBlock;


    void Start ()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }
	
	
	void Update ()
    {
        Rigid.velocity = new Vector2(ArrowVelX * Time.deltaTime, -ArrowVelY * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Plz");
        if (collision.gameObject.CompareTag("Ground"))
        {
            ExpBlock = transform.position;
            ExpBlock += new Vector2();
            Instantiate(ExplosiveBlock, ExpBlock, Quaternion.identity);
            Destroy(gameObject);
        }

        //if (collision.gameObject.CompareTag("Ground"))
        //{
        //    Destroy(gameObject);
        //}
    }
}
