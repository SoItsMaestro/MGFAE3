using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingForwards : MonoBehaviour
{
    public GameObject Arrows;
    public GameObject Despencer1;
    public GameObject Despencer2;
    public GameObject Despencer3;
    public GameObject Despencer4;
    public GameObject Despencer5;
    public GameObject Despencer6;

    public GameObject player;

    Vector2 ArrowPos;
    public float FireRate;
    float nextfire;

    void Start()
    {

    }


    void Update()
    {

    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag("Button1"))
        {
            if (collision.gameObject.CompareTag("Player") && Time.time > nextfire)
            {
                nextfire = Time.time + FireRate;
                fire();                
            }
        }
    }

    void fire() //Fire funcction
    {
        ArrowPos = Despencer1.transform.position;
        ArrowPos += new Vector2(-1f, 0f); //Sets the Right position of the arrow on the player
        Instantiate(Arrows, ArrowPos, Quaternion.identity); //Creates the arrow        
    }    
}
