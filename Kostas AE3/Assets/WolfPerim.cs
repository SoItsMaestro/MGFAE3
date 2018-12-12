using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPerim : MonoBehaviour
{
    public float Speed;
    private Transform target;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }
    }

}
