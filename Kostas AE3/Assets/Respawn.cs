using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
	
	void Update ()
    {
        if (StaticHealth.health <= 0)
        {
           
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
