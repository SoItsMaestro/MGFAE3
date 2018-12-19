using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firetiles : MonoBehaviour
{
    public float Fireoff;
    public float FireOn;
    public bool FireOnbool;
	
	void Start ()
    {
        FireOnbool = false;
	}
	
	
	void Update ()
    {
        FireActive();
        if(FireOn >= 1)
        {
            FireOnbool = true;        
                
                FireOn = 0;
            
        }
        else
        {
            FireOnbool = false;
        }
        
    }

    void FireActive()
    {
        FireOn += Time.deltaTime;

        if (Time.time > Fireoff)
        {
            Fireoff = Time.time + FireOn;
        }
    }

    
private void OnCollisionEnter2D(Collision2D collision)
    {
        if (FireOnbool == true)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(collision.gameObject);
                Debug.Log("Collide");
            }            
        }
    }
}
