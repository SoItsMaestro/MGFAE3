using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaBomb : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BossAttack"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            StaticHealth.health -= 4;
            Destroy(gameObject);
        }
    }
}
