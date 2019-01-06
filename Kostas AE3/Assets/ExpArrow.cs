using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpArrow : MonoBehaviour
{
    public float ExpArrowWait;
    private float ExpArrowWait_;

    private Vector3 FirstTouchPos;
    private Vector3 LastTouchPos;

    private Vector3 FirstTouchScreenPos;
    private Vector3 LastTouchScreenPos;

    public int ScreenPercent;
    private float dragDist;
    public GameObject ArrowExpRight, ArrowExpLeft;

    public GameObject ExplosiveBlock;
    
    Vector2 ArrowPos;

    public bool facingRight = true;
    public bool Right;
    public bool Left;
    public bool Up;
    public bool Down;

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
                    else
                    {
                        //the vertical movement is greater than the horizontal movement
                        if (LastTouchPos.y > FirstTouchPos.y)  //If the movement was up
                        {
                            Right = false;
                            Left = false;
                            Up = true;
                            Down = false;

                            Debug.Log("up");
                        }
                        else
                        {
                            Right = false;
                            Left = false;
                            Up = false;
                            Down = true;

                            Debug.Log("down");
                        }
                    }

                }
                else
                {
                    //It's a tap as the drag distance is less than N% of the screen height

                }
            }
        }        
        if (Down && Time.time > ExpArrowWait_)
        {
            ExpArrowWait_ = Time.time + ExpArrowWait;
            fire();
        }                    
    }

    //void ExpArrowfire()
    //{
    //    float xdistance;
    //    xdistance = HitPoint.position.x - FirePoint.position.x;
    //
    //    float ydistance;
    //    ydistance = HitPoint.position.y - FirePoint.position.y;
    //
    //    float Angle;
    //    Angle = Mathf.Atan((ydistance + 4.905f) / xdistance);
    //
    //    float TotalVelocity = xdistance / Mathf.Cos(Angle);
    //
    //    float xVelocity, yVelocity;
    //    xVelocity = TotalVelocity * Mathf.Cos(Angle);
    //    yVelocity = TotalVelocity * Mathf.Sin(Angle);
    //
    //    GameObject bulletInstance = Instantiate(ExplosionArrow, FirePoint.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
    //    Rigid = bulletInstance.GetComponent<Rigidbody2D>();
    //    Rigid.velocity = new Vector2(xVelocity, yVelocity);
    //}

    void fire()
    {
        ArrowPos = transform.position;
        if (facingRight) //Checks the way the player is facing
        {
            ArrowPos += new Vector2(+0.8f, 0f); //Sets the Right position of the arrow on the player
            Instantiate(ArrowExpRight, ArrowPos, Quaternion.identity); //Creates the arrow
        }
        else
        {
            ArrowPos += new Vector2(-0.8f, 0f); //Sets the Left position of the arrow on the player
            Instantiate(ArrowExpLeft, ArrowPos, Quaternion.identity); //Creates the arrow
        }
        Down = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            //ExplosiveBlock = transform.position;
            
        }

        //if (collision.gameObject.CompareTag("Ground"))
        //{
        //    Destroy(gameObject);
        //}
    }
}
