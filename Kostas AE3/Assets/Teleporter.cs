using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject Portal1;
    //public GameObject Portal2;
    public GameObject Player;
    //public bool TeleOnce = true;   

    public void OnTriggerEnter2D(Collider2D collision)
    {
          if (collision.gameObject.CompareTag("Player"))
          {
                
                StartCoroutine(Teleport());
          }
        
    }
    //public void OnTriggerExit2D(Collider2D collision)
    //{       
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        TeleOnce = false;
    //    }
    //}

    IEnumerator Teleport()
    {        
        yield return new WaitForSeconds(1);
        Player.transform.position = new Vector2(Portal1.transform.position.x, Portal1.transform.position.y);       
    }
}
