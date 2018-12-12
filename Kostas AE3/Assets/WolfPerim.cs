using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPerim : MonoBehaviour
{
    
    public float Stop;
    private Enemy enemy;
    public WolfMove Agro;

    void Update()
    {
        if(enemy)
        {
           if(enemy.CurrentHealth <= 0)
            {
                Agro.IsAgro = false;
                enemy = null;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Agro.IsAgro == false)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                enemy = collision.GetComponent<Enemy>();
                if (enemy)
                {
                    Agro.IsAgro = true;

                    if (Vector2.Distance(transform.position, enemy.transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, enemy.transform.position, 0);
                    }
                }
            }
        }
    }

}
