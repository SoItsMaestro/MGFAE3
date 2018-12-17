using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MaxHealth;
    public float CurrentHealth;
    public float Speed;
    public float JumpStreangth;
    public float EnemyDamage;
   
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
            if(CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
        WolfMove WolfDmg = collision.gameObject.GetComponent<WolfMove>();
        if(WolfDmg)
        {
            CurrentHealth -= WolfDmg.WolfDamage;
            if (CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
