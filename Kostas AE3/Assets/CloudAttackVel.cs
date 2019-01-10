using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudAttackVel : MonoBehaviour
{
    public float Speed;
    
    Rigidbody2D Rigid;

    private void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Rigid.velocity = new Vector2(Speed * Time.deltaTime, 0);
        Destroy(gameObject, 3f);
    }
}
