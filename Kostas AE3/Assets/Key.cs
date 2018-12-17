using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject Keyitem;
    public GameObject Door;
   
	void Update ()
    {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Keyitem.gameObject.SetActive(false);
            Door.gameObject.SetActive(false);

        }

    }
}
