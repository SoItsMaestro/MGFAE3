using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMask : MonoBehaviour
{
    [Range(0.05f, 0.2f)]
    public float Filcktime;

    [Range(0.02f, 0.09f)]
    public float Addsize;

    float timer = 0;

    private bool Bigger = true;
   
    void Update ()
    {
        timer += Time.deltaTime;
        if (timer > Filcktime)
        {
            if (Bigger)
            {
                transform.localScale = new Vector3(transform.localScale.x + Addsize, transform.localScale.y + Addsize, transform.localScale.z);
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x - Addsize, transform.localScale.y - Addsize, transform.localScale.z);
            }

            timer = 0;
            Bigger = !Bigger;
        }
    }
}
