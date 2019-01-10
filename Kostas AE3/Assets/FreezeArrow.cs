using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeArrow : MonoBehaviour
{

    public float ExpArrowWait;
    private float ExpArrowWait_;

    private Vector3 FirstTouchPos;
    private Vector3 LastTouchPos;

    private Vector3 FirstTouchScreenPos;
    private Vector3 LastTouchScreenPos;

    public int ScreenPercent;
    private float dragDist;
    public GameObject ArrowFreRight;
    public GameObject ArrowFreLeft;

    Vector2 ArrowPos;        

    public bool Right;
    public bool Left;
    public bool Up;
    public bool Down;

    public MoveJump Direction;

    //public Transform HitPoint;
    //public Transform FirePoint;
    //public GameObject ExplosionArrow;
    //public float TimeToImpact;

    Rigidbody2D Rigid;

    void Start()
    {
        Right = false;
        Left = false;
        Up = false;
        Down = false;

        dragDist = Screen.height * ScreenPercent / 100;

        //ExpArrowfire();
    }

    void Update()
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
                        if (Direction.facingRight == true)
                        {

                            if ((LastTouchPos.x > FirstTouchPos.x))
                            {
                                Right = true;
                                Left = false;
                                Up = false;
                                Down = false;
                            
                                Debug.Log("right");                            
                            }                            
                            else
                            {
                                Right = false;
                                Left = true;
                                Up = false;
                                Down = false;
                            
                                Debug.Log("left");
                            }                         
                            
                        }
                        else if (Direction.facingRight == false)
                        {
                            if ((LastTouchPos.x > FirstTouchPos.x))
                            {
                                Right = true;
                                Left = false;
                                Up = false;
                                Down = false;

                                Debug.Log("right");

                            }

                            else
                            {
                                Right = false;
                                Left = true;
                                Up = false;
                                Down = false;

                                Debug.Log("left");
                            }
                        }
                    }
                    //else
                    //{
                    //    //the vertical movement is greater than the horizontal movement
                    //    if (LastTouchPos.y > FirstTouchPos.y)  //If the movement was up
                    //    {
                    //        Right = false;
                    //        Left = false;
                    //        Up = true;
                    //        Down = false;
                    //
                    //        Debug.Log("up");
                    //    }
                    //    else
                    //    {
                    //        Right = false;
                    //        Left = false;
                    //        Up = false;
                    //        Down = true;
                    //
                    //        Debug.Log("down");
                    //    }
                    //}

                }
                else
                {
                    //It's a tap as the drag distance is less than N% of the screen height

                }
            }
        }
        if (Left && Time.time > ExpArrowWait_)
        {
            ExpArrowWait_ = Time.time + ExpArrowWait;
            fire();
        }
        //else if (Right && Time.time > ExpArrowWait_)
        //{
        //    ExpArrowWait_ = Time.time + ExpArrowWait;
        //    fire();
        //}
    }

    void fire()
    {
        ArrowPos = transform.position;
        if (Direction.facingRight) //Checks the way the player is facing
        {
            ArrowPos += new Vector2(+0.8f, 0f); //Sets the Right position of the arrow on the player
            Instantiate(ArrowFreRight, ArrowPos, Quaternion.identity); //Creates the arrow
        }
        else
        {
            ArrowPos += new Vector2(-0.8f, 0f); //Sets the Left position of the arrow on the player
            Instantiate(ArrowFreLeft, ArrowPos, Quaternion.identity); //Creates the arrow
            //RigidRight.velocity = new Vector2(+ArrowVelX * Time.deltaTime, -ArrowVelY * Time.deltaTime);
        }
        Left = false;
        //Right = false;
    }


}
