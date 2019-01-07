using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class MoveJump : MonoBehaviour
{
    public float Speed;
    public float JumpStrength;
    public float RayLength;
    public GameObject respawnPoint;
    
    public GameObject ArrowToRight, ArrowToLeft;
    Vector2 ArrowPos;
    public float FireRate;
    float nextfire;
    public LayerMask Character;

    public bool jumps = true;
    public bool facingRight = true;
    private bool Once;

    public Interactable Speachmark;
    public InteractableNotTrigger Speachmark2;

    public ArrowAttack Aim;
    float Timer;
    float HoldDuration = 3f;

    public GameObject Chest1;
    public GameObject Chest2;

    private Rigidbody2D rigid;





    public int BFletMim = 2;
    public int BFletMax = 3;

    void Start()
    {                
        Once = false;
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigid.velocity = new Vector2(CrossPlatformInputManager.GetAxisRaw("Horizontal") * Speed, rigid.velocity.y);  //Moves that player acrosst the horizontal plane using the thumbstick
        float Horizontal = CrossPlatformInputManager.GetAxisRaw("Horizontal"); //Flips player
        flip(Horizontal); //Calls flip function

        if (CrossPlatformInputManager.GetButtonDown("Jump")) //When jump button pressed player jumps     
        {
            Debug.Log("Jumping");
            if (Physics2D.Linecast(transform.position, transform.position + new Vector3(0, RayLength, 0), 1 << LayerMask.NameToLayer("Ground"))) //Linecast downwards and if connects with ground jumps when pressed
            {
                Debug.Log("ForceAdded");
                rigid.velocity = new Vector2(rigid.velocity.x, JumpStrength); //Adds the force to make jump happen
            }
           // else if (Speachmark.Speachm == true || Speachmark2.Speachm == true)
           // {
           //     Debug.Log("work");
           //         if(CrossPlatformInputManager.GetButtonDown("Jump"))
           //         {
           //             Chest1.SetActive(false);
           //             Chest1.SetActive(true);
           //         }
           //     
           // }
           

        }

        if (CrossPlatformInputManager.GetButtonDown("Fire1") && Time.time > nextfire) //When MB1 pressed, fires
        {
            nextfire = Time.time + FireRate; //Duration between arrow fire
            fire(); //Calls fire function
        }
        //else
        //{
        //    if(CrossPlatformInputManager.GetButtonDown("Fire1"))
        //    {
        //        if(Time.time - Timer > HoldDuration)
        //        {
        //            Timer = float.PositiveInfinity;
        //        }
        //    }
        //    else
        //    {
        //        Timer = float.PositiveInfinity;
        //    }
        //}
    }

    void fire() //Fire funcction
    {
        ArrowPos = transform.position;
        if (facingRight) //Checks the way the player is facing
        {
            ArrowPos += new Vector2(+0.8f, 0f); //Sets the Right position of the arrow on the player
            Instantiate(ArrowToRight, ArrowPos, Quaternion.identity); //Creates the arrow
        }
        else
        {
            ArrowPos += new Vector2(-0.8f, 0f); //Sets the Left position of the arrow on the player
            Instantiate(ArrowToLeft, ArrowPos, Quaternion.identity); //Creates the arrow
        }
    }

    void flip(float Horizontal) //Flip function
    {
        if(Horizontal > 0 && !facingRight  || Horizontal < 0 && facingRight) //Checks which way the player is facing
        {
            facingRight = !facingRight; //Facking right = false
            Vector3 theScale = transform.localScale;
            theScale.x *= -1; 
            transform.localScale = theScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy Damage = collision.gameObject.GetComponent<Enemy>();
        if (!Once)
        {
            if (Damage)
            {
                Once = true;
                Invoke("ResetInvunrability", 2);
                if (Once == true)
                {
                    Debug.Log("HealthDecrease");

                    StaticHealth.health -= 1;
                    Debug.Log(StaticHealth.health);
                }
                Debug.Log(StaticHealth.health);

            }
        }
        //if (collision.gameObject.CompareTag("Door"))
        //{
        //    //Debug.Log("Collide");
        //    //NextScene();
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy Damage = collision.gameObject.GetComponent<Enemy>();
        if (!Once)
        {            
            if (Damage)
            {
                Once = true;
                Invoke("ResetInvunrability", 2);
                if (Once == true)
                {
                    Debug.Log("HealthDecrease");
                
                    StaticHealth.health -= 1;
                    Debug.Log(StaticHealth.health);                                  
                }                
                Debug.Log(StaticHealth.health);
                
            }
            
            if (collision.gameObject.CompareTag("Arrow"))
            {
                Once = true;
                Invoke("ResetInvunrability", 2);
                if (Once == true)
                {
                    StaticHealth.health -= 1;
                    Debug.Log(StaticHealth.health);
                }
            }

            if (collision.gameObject.CompareTag("EnemyProjectile"))
            {
                Once = true;
                Invoke("ResetInvunrability", 2);
                if (Once == true)
                {
                    StaticHealth.health -= Random.Range(BFletMim, BFletMax);
                    Debug.Log(StaticHealth.health);
                }
            }
        }
        if (StaticHealth.health <= 0)
        //{
        //    Destroy(gameObject);
        //    gameObject.transform.position = respawnPoint.transform.position;


        //}

        if(collision.transform.CompareTag("MovingPlatform"))
        {
            transform.parent = collision.transform;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("MovingPlatform"))
        {
            transform.parent = null;
        }
    }
    void ResetInvunrability()
    {
        Once = false;
    }

   // private void OnTriggerEnter2D(Collider2D collision)
   // {
   //     if (collision.gameObject.CompareTag("Door"))
   //     {
   //         Debug.Log("Collide");
   //         NextScene();
   //     }
   // }

    void NextScene()
    {
        SceneManager.LoadScene("Transition");
    }

    


    
    
    
}
