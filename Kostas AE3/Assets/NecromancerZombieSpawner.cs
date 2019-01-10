using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecromancerZombieSpawner : MonoBehaviour {

    public GameObject Zombie;

    private float zombieTimer;

    private Vector2 ZombPos;

	// Use this for initialization
	void Start () {
        zombieTimer = 8f;
	}
	
	// Update is called once per frame
	void Update () {
        zombieTimer -= Time.deltaTime;


        if (zombieTimer <= 0)
        {
            Debug.Log("ZombTimerDone");
            zombieposition();

            Instantiate(
                Zombie,
                ZombPos,
                Quaternion.identity
                );

            zombieTimer = 8f;
        }
	}


    void zombieposition()
    {
        ZombPos = new Vector2(12.8f, 12.2f);
            
    }
    

}
