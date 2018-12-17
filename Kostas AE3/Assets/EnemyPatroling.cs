using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatroling : MonoBehaviour
{
    public float Speed;
    public float RayLength;

    private bool Right = true;

    public Transform Ground;

    private void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);

        RaycastHit2D GroundInfo = Physics2D.Raycast(Ground.position, Vector2.down, RayLength);
        //RaycastHit2D GroundInfo = Physics2D.Raycast(Ground.position, Vector2.left, RayLength);
        if (GroundInfo.collider == false)
        {
            if(Right == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                Right = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                Right = true;
            }
        }
    }

}
