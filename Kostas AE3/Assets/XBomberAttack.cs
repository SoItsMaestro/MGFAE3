using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBomberAttack : MonoBehaviour {

    public float XBombTimer = 3; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        void Xbombatk(); //not sure why it wont call

    }

    private void Xbombatk()
    {
        XBombTimer = -Time.deltaTime;

        if (XBombTimer <= 0)
        {
            //Code that shoots bombs from the diagnols.
            Debug.Log("X Has shot");

            XBombTimer = 3;
        }

    }
   
}
