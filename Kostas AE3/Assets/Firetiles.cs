using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firetiles : MonoBehaviour
{
    public GameObject fire, fire2, fire3;

    public float Fireoff;
    public float FireOn;
    public bool FireOnbool;

    public GameObject SecondSafe;
	
	void Start ()
    {
        FireOnbool = false;        
	}
	
	
	void Update ()
    {
        FireActive();
        if(FireOn >= 1)
        {
            fire.gameObject.SetActive(true);
            fire2.gameObject.SetActive(true);
            fire3.gameObject.SetActive(true);
            FireOnbool = true;
            
            if (FireOnbool == true)
            {
                Debug.Log("here");
                StartCoroutine(Duration());                
            }
        }
        else
        {
            FireOnbool = false;
            fire.gameObject.SetActive(false);
            fire2.gameObject.SetActive(false);
            fire3.gameObject.SetActive(false);
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
                StaticHealth.health = 0;
                Debug.Log("Collide");
            }            
        }        

    }

    IEnumerator Duration()
    {
        yield return new WaitForSeconds(1);
       
        FireOn = 0;
    }
}
