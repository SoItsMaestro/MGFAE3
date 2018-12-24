using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float BounceHeight;
    private Rigidbody2D rigid;

    private void Start()
    {
       rigid = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Debug.Log("col");
            rigid.AddForce(transform.up * BounceHeight);
        }
        else
        {
        }  // we're not falling, so do nothing
    }

}
