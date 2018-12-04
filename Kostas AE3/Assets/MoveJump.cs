using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MoveJump : MonoBehaviour
{
    public float Speed;
    public float JumpStrength;
    public float RayLength;

    public bool jumps = true;

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
    }
}
