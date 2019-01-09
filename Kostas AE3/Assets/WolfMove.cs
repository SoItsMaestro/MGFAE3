using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMove : MonoBehaviour
{
    public float Speed;
    public float Stop;
    public float RayLength;
    public float JumpStrength;
    public float WolfDamage;
    public float AgroRange;
    
    public bool IsAgro;
    public bool JumpStop;

    private WolfPerim Player;
    private Transform target;

    private Rigidbody2D rigid;

    void Start()
    {
        IsAgro = false;
        JumpStop = false;

        Player = GameObject.FindGameObjectWithTag("Player").transform.GetComponentInChildren<WolfPerim>();
        target = Player.transform;
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        target = (IsAgro) ? Player.enemy.transform : Player.transform;
        if (Vector2.Distance(transform.position, Player.transform.position) > AgroRange)
        {
            target = Player.transform;
            IsAgro = false;
        }


        if (Vector2.Distance(transform.position, target.position) > Stop)
        {
           transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }

        
        if ((Physics2D.Linecast(transform.position - new Vector3(RayLength, 0, 0), transform.position + new Vector3(RayLength, 0, 0), 1 << LayerMask.NameToLayer("Ground"))) && (Physics2D.Linecast(transform.position - new Vector3(0, RayLength, 0), transform.position + new Vector3(0, RayLength, 0), 1 << LayerMask.NameToLayer("Ground"))))
        {
            //if (Physics2D.Linecast(transform.position - new Vector3(0, RayLength, 0), transform.position + new Vector3(0, RayLength, 0), 1 << LayerMask.NameToLayer("Ground")))
            //{

                Debug.Log("ForceAdded");
                rigid.velocity = new Vector2(rigid.velocity.x, JumpStrength);
                JumpStop = false;
            //}
        }
        Debug.DrawLine(transform.position - new Vector3(RayLength, 0, 0), transform.position + new Vector3(RayLength, 0, 0), Color.blue);
        Debug.DrawLine(transform.position - new Vector3(0, RayLength, 0), transform.position + new Vector3(0, RayLength, 0), Color.red);

    }
    
}
