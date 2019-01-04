using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableItems : MonoBehaviour
{
    public float Helath;
    public float CurrentHealth;

    public int ArrowDmgMin = 1;
    public int ArrowDmgMax = 3;

    void Start ()
    {

		
	}
	
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ArrowAttack Damage = collision.gameObject.GetComponent<ArrowAttack>();
        if (Damage)
        {
            CurrentHealth -= Random.Range(ArrowDmgMin, ArrowDmgMax);
            if (CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
