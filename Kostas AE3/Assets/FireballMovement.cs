using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour {
    public float StartHeight;
    public float height;
    public float speed;
    private float wait_time;
   // private int wait_time;
    
    void Start ()
    {
		wait_time = Random.Range(4, 6);
	}

    private void Update()
    {
		FireballTimer();
    }

    private void FireballTimer()
    {
        wait_time = -Time.deltaTime;

        if (wait_time <= 0)
        {
            //get the objects current position and put it in a variable so we can access it later with less code
            Vector3 pos = transform.position;
            //calculate what the new Y position will be
            float newY = Mathf.Cos(Time.time * speed) - StartHeight;
            //set the object's Y to the new calculated Y
            transform.position = new Vector2(pos.x, newY * -height);
			wait_time = Random.Range(4, 6);
		}
    }
    

}
