using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHeadDamage : MonoBehaviour {

    int rockheadrange;
	// Use this for initialization
	void Start () {
        rockheadrange = Random.Range(2, 3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StaticHealth.health =- rockheadrange;
            Debug.Log("hitrockhead");
        }
    }
}
