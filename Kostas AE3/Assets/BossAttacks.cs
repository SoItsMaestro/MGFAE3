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
    Vector2 ragingswipepos;
    Vector2 magmabomb1pos;
    Vector2 magmabomb2pos;
    Vector2 magmabomb3pos;
    Vector2 cloudpos;

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
                attack1();

                Instantiate(
                RagingSwipe,
                ragingswipepos,
                Quaternion.identity);

                timerrange = Random.Range(4, 8);

                //////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////
            }
            else if (attackrange >= 40f && attackrange < 55f) //Magma Bomb Drop
            {
                Debug.Log("MagmaBombDrop 40-55");
                magmabomb();

                Instantiate(
                    MagmaBomb,
                    magmabomb1pos,
                    Quaternion.identity);

                Instantiate(
                    MagmaBomb,
                    magmabomb2pos,
                    Quaternion.identity);

                Instantiate(
                    MagmaBomb,
                    magmabomb3pos,
                    Quaternion.identity);


                timerrange = Random.Range(4, 8);

                //////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////
            }
            else if (attackrange >= 55f && attackrange < 75f) //Furious Charge
            {
                Debug.Log("FuriousCharge 55-75");



                timerrange = Random.Range(4, 8);

                //////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////
            }
            else if (attackrange >= 75f && attackrange < 90f) //Winds of Change
            {
                Debug.Log("WindsofChange 75-90");

                cloud();

                Instantiate(
                    WindsofChangeCloud,
                    cloudpos,
                    Quaternion.identity);

                timerrange = Random.Range(4, 8);
                //WindsofChangeCloud.GetComponent<WindsofChange>().pushtimer = 20;

                //////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////
            }
            else //Does nothing
            {
                Debug.Log("Does Nothing");
                timerrange = Random.Range(4, 8);

                //////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////////
            }


        }
        
    }
        void attack1()
    {
        ragingswipepos = transform.position;
        ragingswipepos += new Vector2(-3f, -1.7f);

     
    }

    void magmabomb()
    {
        magmabomb1pos = transform.position;
        magmabomb1pos += new Vector2(-7, 2); //add position

        magmabomb2pos = transform.position;
        magmabomb2pos += new Vector2(-10f, 2); //add position

        magmabomb3pos = transform.position;
        magmabomb3pos += new Vector2(-14, 2); //add position
    }

    void cloud()
    {
        cloudpos = transform.position;
        cloudpos += new Vector2(2, 4);

    }
}


