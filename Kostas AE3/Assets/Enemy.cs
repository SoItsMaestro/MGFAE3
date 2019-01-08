using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MaxHealth;
    public string EnemyName;
    public float CurrentHealth;
    public float Speed;
    public float JumpStreangth;
    public float EnemyDamage;
    public float WolfAttpause;
    private bool WolfAtt = true;   

    public int ArrowDmgMin = 1;
    public int ArrowDmgMax = 3;    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ArrowAttack Damage = collision.gameObject.GetComponent<ArrowAttack>();
        if(Damage)
        {            
            CurrentHealth -= Random.Range(ArrowDmgMin, ArrowDmgMax);
            Debug.Log(CurrentHealth);
            if(CurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
       
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wolf"))
        {
            if (WolfAtt)
            {
                WolfMove WolfDmg = collision.gameObject.GetComponent<WolfMove>();
                Debug.Log("fgdsfsf");
                CurrentHealth -= WolfDmg.WolfDamage;
                if (CurrentHealth <= 0)
                {
                    Destroy(gameObject);
                }
                StartCoroutine(Duration());
            }
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    DestroyItem ExpDmg = collision.gameObject.GetComponent<DestroyItem>();
    //    if (ExpDmg)
    //    {
    //        CurrentHealth -= 3;
    //        Debug.Log(CurrentHealth);
    //        if (CurrentHealth <= 0)
    //        {
    //            Destroy(gameObject);
    //        }
    //    }
    //}

    IEnumerator Duration()
    {
        WolfAtt = false;
        yield return new WaitForSeconds(2);
        WolfAtt = true;
    }
}
