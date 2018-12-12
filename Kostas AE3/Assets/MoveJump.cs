using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MoveJump : MonoBehaviour
{
    public float Speed;
    public float JumpStrength;
    public float RayLength;
    
    public GameObject ArrowToRight, ArrowToLeft;
    Vector2 ArrowPos;
    public float FireRate;
    float nextfire;
    public LayerMask Character;

    public bool jumps = true;
    public bool facingRight = true;

    private Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }





    void Update()
    {
        rigid.velocity = new Vector2(CrossPlatformInputManager.GetAxisRaw("Horizontal") * Speed, rigid.velocity.y);
        float Horizontal = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        flip(Horizontal);

        if (CrossPlatformInputManager.GetButtonDown("Jump"))        
        {
            Debug.Log("Jumping");
            if (Physics2D.Linecast(transform.position, transform.position + new Vector3(0, RayLength, 0), 1 << LayerMask.NameToLayer("Ground")))
            {
                Debug.Log("ForceAdded");
                rigid.velocity = new Vector2(rigid.velocity.x, JumpStrength);

            }
        }

        if (Input.GetButtonDown("Fire1") && Time.time > nextfire)
        {
            nextfire = Time.time + FireRate;
            fire();
        }
    }
    void fire()
    {
        ArrowPos = transform.position;
        if (facingRight)
        {
            ArrowPos += new Vector2(+0.8f, 0f);
            Instantiate(ArrowToRight, ArrowPos, Quaternion.identity);
        }
        else
        {
            ArrowPos += new Vector2(-0.8f, 0f);
            Instantiate(ArrowToLeft, ArrowPos, Quaternion.identity);
        }
    }

    void flip(float Horizontal)
    {
        if(Horizontal > 0 && !facingRight  || Horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
