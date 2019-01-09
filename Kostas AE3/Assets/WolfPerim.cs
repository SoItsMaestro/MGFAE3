using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPerim : MonoBehaviour
{    
    public float Stop;
    internal Enemy enemy;
    public WolfMove Agro;
    public float RayLengthEnemy;


    private bool Check = false;

    void Update()
    {
        if (Check)
        {
            if (enemy)
            {
                if (enemy.CurrentHealth <= 0)
                {
                    Debug.Log("Ran");
                    Agro.IsAgro = false;
                    enemy = null;
                }
            }
            else
            {
                Debug.Log("Ran");
                Agro.IsAgro = false;
                enemy = null;
                Check = false;
            }
        }

        //if (Agro.IsAgro == false)
        //{
        //
        //    if (Physics2D.Linecast(transform.position - new Vector3(RayLengthEnemy, 0, 0), transform.position + new Vector3(RayLengthEnemy, 0, 0), 1 << LayerMask.NameToLayer("Enemy && DestObj")))
        //        Debug.Log("Hit");
        //    enemy = RayLengthEnemy.GetComponent<Enemy>();
        //    if (enemy)
        //    {
        //        Agro.IsAgro = true;
        //
        //        Check = true;
        //
        //    }
        //}
        //Debug.DrawLine(transform.position - new Vector3(RayLengthEnemy, 0, 0), transform.position + new Vector3(RayLengthEnemy, 0, 0), Color.green);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Agro.IsAgro == false)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Hit");
                enemy = collision.GetComponent<Enemy>();
                if (enemy)
                {                    
                        Agro.IsAgro = true;
    
                        Check = true;
                   
                }
            }
        }
    }

}
