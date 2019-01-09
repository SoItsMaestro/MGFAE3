using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability1 : MonoBehaviour {

    public WolfMove WolfScrips;
    public GameObject Wolf;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Wolf.gameObject.SetActive(false);
            WolfScrips.enabled = true;

        }
    }
}
