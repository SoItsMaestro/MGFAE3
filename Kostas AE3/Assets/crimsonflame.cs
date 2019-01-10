using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crimsonflame : MonoBehaviour {

    public GameObject CFProjectile;
    public GameObject CFProjectileL;

    public EnemyPatroling Direction;
    public bool once = false;

    Vector2 BonePos;
    public float FireRate;
    float nextfire;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.gameObject.CompareTag("Player") && Time.time > nextfire)
        {
            Debug.Log("work");
            nextfire = Time.time + FireRate;
             fire();
        }       
    }   

    void fire() //Fire funcction
    {
        BonePos = transform.position;
        if (Direction.Right == true) //Checks the way the player is facing
        {
            BonePos += new Vector2(+1f, 0f); //Sets the Right position of the arrow on the player
            Instantiate(CFProjectile, BonePos, Quaternion.identity); //Creates the arrow       
        }
        else if (Direction.Right == false)
        {
            BonePos += new Vector2(-5f, -5f); //Sets the Right position of the arrow on the player
            Instantiate(CFProjectileL, BonePos, Quaternion.identity); //Creates the arrow  
        }
    }

}
