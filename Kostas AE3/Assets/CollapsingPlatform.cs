using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapsingPlatform : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float FallDuration;

	void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            Destroy(gameObject);
        }

    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(FallDuration);
        rigid.isKinematic = false;
        yield return 0;
    }
}
