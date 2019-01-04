using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPerim : MonoBehaviour
{    
    public float Stop;
    internal Enemy enemy;
    public WolfMove Agro;
   
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
