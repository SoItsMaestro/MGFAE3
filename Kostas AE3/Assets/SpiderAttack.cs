using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAttack : MonoBehaviour
{
    public GameObject TriShot;

    Vector2 VenomPos, VenomPos2, VenomPos3;
    public float FireRate;
    float nextfire;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("work");
        if (collision.gameObject.CompareTag("Player") && Time.time > nextfire)
        {
            nextfire = Time.time + FireRate;
            fire();
        }
    }

    void fire()
    {
        VenomPos = transform.position;
        VenomPos += new Vector2(-1f, 0f);
        
        Instantiate(TriShot, VenomPos, Quaternion.identity);       
    }
}
