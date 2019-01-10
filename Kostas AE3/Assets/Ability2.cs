using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability2 : MonoBehaviour
{
    public GameObject ExpArrow;
    public ExpArrow ExpArrowScrips;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            ExpArrow.gameObject.SetActive(false);
            ExpArrowScrips.enabled = true;

        }
    }
}
