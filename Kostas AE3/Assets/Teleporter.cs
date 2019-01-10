using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Teleporter Portal1;
    //public GameObject Portal2;
    public GameObject Player;
    public bool TeleActive = true;   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (TeleActive)
            {
                StartCoroutine(Teleport());
            }
        }        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TeleActive = true;
        }
    }   

    IEnumerator Teleport()
    {        
        Portal1.TeleActive = false;
        yield return new WaitForSeconds(2);
        Player.transform.position = new Vector2(Portal1.transform.position.x, Portal1.transform.position.y);
    }
}
