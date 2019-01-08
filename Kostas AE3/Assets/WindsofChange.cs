using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindsofChange : MonoBehaviour
{

    public int speed;
    public int playerpush;
    public float pushtimer = 20;
    //public Rigidbody rb;
    public Rigidbody2D playerRb;


    // Use this for initialization


    private void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
        playerRb = GetComponent<Rigidbody2D>();

     
    }

    private void Update()
    {
        //rb.velocity = new Vector2(speed * Time.deltaTime, 0);

        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        if (pushtimer >= 0) 
        {
            //Debug.Log("pushtimer");
            playerRb.velocity = new Vector2(playerpush * Time.deltaTime, 0);
        }
      

        pushtimer -= Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BossAttack"))
        {
            Destroy(gameObject);
        }
    }


}
