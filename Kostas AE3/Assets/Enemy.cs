using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MaxHealth;
    public float CurrentHealth;
    public float Speed;
    public float JumpStreangth;  
   
	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ArrowAttack Damage = collision.gameObject.GetComponent<ArrowAttack>();
        if(Damage)
        {            
            CurrentHealth -= Damage.ArrowDmg;
        }
    }
}
