﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeBehavior : MonoBehaviour
{
    //private Transform plztransform;
    private float shakeDuration = 0f;
    private float shakeMagnitude = 0.7f;
    private float dampingSpeed = 1.0f;
    Vector3 initialPosition;

    private Bolder Shaking;

   // private void Awake()
   // {
   //     if(transform == null)
   //     {
   //         plztransform = GetComponent(typeof(Transform)) as Transform;
   //     }
   // }

    private void OnEnable()
    {
        initialPosition = transform.localPosition;
    }    	
	
	void Update ()
    {
		if(shakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
        }
        else
        {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
	}

    public void TriggerShake()
    {
        shakeDuration = 2.0f;
    }
}
