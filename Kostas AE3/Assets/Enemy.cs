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
    public bool WolfCol = false;
    public float WolfAttpause;
    public float WolfAtt;
   
	void Start ()
    {
		
	}
	
	void Update ()
    {
        WolfAttacking();
	    if(WolfCol == true)
        {
            Debug.Log("here");
            StartCoroutine(Duration());
        }
        else
        {
            WolfCol = false;
        }
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
            WolfCol = true;
            CurrentHealth -= WolfDmg.WolfDamage;
            if (CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void WolfAttacking()
    {
        WolfAtt += Time.deltaTime;
        if (Time.time > WolfAttpause)
        {
            WolfAttpause = Time.time + WolfAtt;
        }
    }

    IEnumerator Duration()
    {
        yield return new WaitForSeconds(1);
        WolfAtt = 0;
    }
}
