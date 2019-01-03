using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableItems : MonoBehaviour
{
    public float Helath;
    public float CurrentHealth;


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
            CurrentHealth -= Damage.ArrowDmg;
            if (CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
