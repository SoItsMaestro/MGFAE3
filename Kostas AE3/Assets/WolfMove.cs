using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMove : MonoBehaviour
{
    public float Speed;
    public float Stop;
    public float RayLength;
    public float JumpStrength;

   public bool IsAgro;

    private Transform target;

    private Rigidbody2D rigid;

    void Start()
    {
        IsAgro = false;

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!IsAgro)
        {
            if (Vector2.Distance(transform.position, target.position) > Stop)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
            }

            if (Physics2D.Linecast(transform.position, transform.position + new Vector3(RayLength, 0, 0), 1 << LayerMask.NameToLayer("Ground")))
            {
                Debug.Log("ForceAdded");
                rigid.velocity = new Vector2(rigid.velocity.x, JumpStrength);
            }
        }
    }

}
