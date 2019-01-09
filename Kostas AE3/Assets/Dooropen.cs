using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropen : MonoBehaviour
{
    public Enemy Health;
    public GameObject door;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Health.CurrentHealth <= 0)
        {
            door.gameObject.SetActive(false);
        }
	}
}
