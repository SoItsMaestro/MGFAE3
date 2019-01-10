using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartsfollow : MonoBehaviour
{
    public GameObject player;
    private Vector2 velocity;

    public float smoothTimeX;
    public float smoothTimeY;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posX + -0.45f, posY + 2.7f, transform.position.z);
    }
}
