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

        if(CrossPlatformInputManager.GetButton("Jump"))        
        {
            Debug.Log("Jumping");
            if (Physics2D.Linecast(transform.position, transform.position + new Vector3(0, RayLength, 0), 1 << LayerMask.NameToLayer("Ground")))
            {
                Debug.Log("ForceAdded");
                rigid.AddForce(new Vector2(0, JumpStrength));
            }
        }
        if (Input.GetButtonDown ("Fire1") && Time.time > nextfire)
        {
            nextfire = Time.time + FireRate;
            fire ();
        }
    }

    void fire ()
    {
        ArrowPos = transform.position;
        if(facingRight)
        {
            ArrowPos += new Vector2(+1f, -0.43f);
            Instantiate(ArrowToRight, ArrowPos, Quaternion.identity);
        }
        else
        {
            ArrowPos += new Vector2(-1f, -0.43f);
            Instantiate(ArrowToLeft, ArrowPos, Quaternion.identity);
        }
    }
}
