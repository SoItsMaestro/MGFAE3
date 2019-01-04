using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneFleature : MonoBehaviour
{
    public GameObject BFProjectile;

    public bool facingRight = true;

    Vector2 BonePos;
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

    void fire() //Fire funcction
    {
        BonePos = transform.position;
       // if (facingRight) //Checks the way the player is facing
       // {
       //     BonePos += new Vector2(+1f, 0f); //Sets the Right position of the arrow on the player
       //     Instantiate(BFProjectile, BonePos, Quaternion.identity); //Creates the arrow       
       // }
       // else
       // {
            BonePos += new Vector2(-1f, 0f); //Sets the Right position of the arrow on the player
            Instantiate(BFProjectile, BonePos, Quaternion.identity); //Creates the arrow  
        //}
    }
}
