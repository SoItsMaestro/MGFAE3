using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttacks : MonoBehaviour {

    float attackrange;
    float timerrange;
    float attacktimer;
    public GameObject RagingSwipe = null;
    public GameObject MagmaBomb = null;
    public GameObject WindsofChangeCloud = null;

	// Use this for initialization
	void Start () {
       timerrange = Random.Range(4, 8);
        attackrange = 0;
       
	}
	
	// Update is called once per frame
	void Update () {
        timerrange -= Time.deltaTime;
        attacktimer = (timerrange - Time.deltaTime);
        
        Attacking();
    }

    private void Attacking()
    {
        if (attacktimer <= 0)
        {
            int attackrange = Random.Range(0, 100);
            Debug.Log("TimerDone");



            if ((attackrange >= 0) && (attackrange < 40f))  // Raging Swipe
            {
                Debug.Log("RagingSwipe 0-40");

                Instantiate(
                    RagingSwipe,
                    transform.position,
                    Quaternion.identity);
                timerrange = Random.Range(4, 8);
            }
            else if (attackrange >= 40f && attackrange < 55f) //Magma Bomb Drop
            {
                Debug.Log("MagmaBombDrop 40-55");

                Instantiate(
                    MagmaBomb,
                    transform.position,
                    Quaternion.identity);

                timerrange = Random.Range(4, 8);


            }
            else if (attackrange >= 55f && attackrange < 75f) //Furious Charge
            {
                Debug.Log("FuriousCharge 55-75");



                timerrange = Random.Range(4, 8);
            }
            else if (attackrange >= 75f && attackrange < 90f) //Winds of Change
            {
                Debug.Log("WindsofChange 75-90");

                Instantiate(
                    WindsofChangeCloud,
                    transform.position,
                    Quaternion.identity);

                timerrange = Random.Range(4, 8);
            }
            else //Does nothing
            {
                timerrange = Random.Range(4, 8);
            }
        }
    }

}
