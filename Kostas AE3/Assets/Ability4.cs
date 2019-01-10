using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability4 : MonoBehaviour
{

    public GameObject FreArrow;
    public FreezeArrow FreArrowScrips;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FreArrow.gameObject.SetActive(false);
            FreArrowScrips.enabled = true;

        }
    }
}
