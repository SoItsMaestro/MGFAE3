using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour {

    public float ExpDmg;
    public float ExplosivePower;
    public float ExplosiveRadius;
    //public GameObject Explosion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy Enim = collision.gameObject.GetComponent<Enemy>();
                Enim.CurrentHealth -= ExpDmg;
            //Debug.Log(CurrentHealth);
            if (Enim.CurrentHealth <= 0)
            {
                Destroy(Enim.gameObject);
            }
            Destroy(gameObject);
        }

        var Objects = GameObject.FindObjectsOfType<Rigidbody2D>();
        foreach (Rigidbody2D item in Objects)
        {
            if (Vector2.Distance(item.gameObject.transform.position, transform.gameObject.transform.position) < ExplosivePower)
            {
                Debug.Log(item.gameObject.name);
                item.gameObject.GetComponent<Rigidbody2D>().AddForce((item.gameObject.transform.position - transform.position) * ExplosivePower, ForceMode2D.Impulse);
            }
        }

       // Explosion.SetActive(true);
       // Explosion.GetComponent<AudioSource>().Play();
       // gameObject.SetActive(false);
    }
}
