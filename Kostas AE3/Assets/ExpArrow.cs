using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpArrow : MonoBehaviour
{

    private Vector3 FirstTouchPos;
    private Vector3 LastTouchPos;

    private Vector3 FirstTouchScreenPos;
    private Vector3 LastTouchScreenPos;

    public int ScreenPercent;
    private float dragDist;
    public GameObject ArrowExpRight, ArrowExpLeft;
    
    Vector2 ArrowPos;

    public bool facingRight = true;
    public bool Down;

    void Start()
    {
        Down = false;

        dragDist = Screen.height * ScreenPercent / 100;
    }

    private void Update()
    {


        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("touch");
                FirstTouchPos = touch.position;
                //LastTouchPos = touch.position;

                FirstTouchScreenPos = Camera.main.ScreenToWorldPoint(touch.position);
                //LastTouchScreenPos = Camera.main.ScreenToWorldPoint(touch.position);
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                LastTouchPos = touch.position;
                LastTouchScreenPos = Camera.main.ScreenToWorldPoint(touch.position);

            }
            else if (touch.phase == TouchPhase.Ended)
            {
                LastTouchPos = touch.position;
                LastTouchScreenPos = Camera.main.ScreenToWorldPoint(touch.position);

                if (Mathf.Abs(LastTouchPos.x - FirstTouchPos.x) > dragDist || Mathf.Abs(LastTouchPos.y - FirstTouchPos.y) > dragDist)
                {
                    if (Mathf.Abs(LastTouchPos.x - FirstTouchPos.x) > Mathf.Abs(LastTouchPos.y - FirstTouchPos.y))
                    {
                        if ((LastTouchPos.y > FirstTouchPos.y))
                        {                            
                            Down = true;
                            Debug.Log("Down");
                        }                        
                    }
                }
            }
        }

        if (Down)
        {
            Debug.Log("Moving");
            Vector2 temp = new Vector2(LastTouchScreenPos.y, ArrowExpRight.transform.position.y);

            ArrowExpRight.transform.position = Vector2.MoveTowards(ArrowExpRight.transform.position, temp, 3f * Time.deltaTime);


        //ArrowPos = transform.position;
        //if (facingRight) //Checks the way the player is facing
        //{
        //    ArrowPos += new Vector2(+0.8f, 0f); //Sets the Right position of the arrow on the player
        //    Instantiate(ArrowExpRight, ArrowPos, Quaternion.identity); //Creates the arrow
        //}
        //else
        //{
        //    ArrowPos += new Vector2(-0.8f, 0f); //Sets the Left position of the arrow on the player
        //    Instantiate(ArrowExpLeft, ArrowPos, Quaternion.identity); //Creates the arrow
        //}



         }
    }
}
