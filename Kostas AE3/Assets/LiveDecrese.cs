using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LiveDecrese : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;

    void Update ()
    {          

        if (StaticHealth.health == 3)
        {
            Debug.Log("Calculation Correct");
            Heart1.gameObject.SetActive(false);
            Heart2.gameObject.SetActive(false);
            Heart3.gameObject.SetActive(true);
            Heart4.gameObject.SetActive(false);
        }
        if (StaticHealth.health == 2)
        {
            Debug.Log("Calculation Correct");
            Heart1.gameObject.SetActive(false);
            Heart2.gameObject.SetActive(true);
            Heart3.gameObject.SetActive(false);
            Heart4.gameObject.SetActive(false);
        }
        if (StaticHealth.health == 1)
        {
            Debug.Log("Calculation Correct");
            Heart4.gameObject.SetActive(false);
            Heart1.gameObject.SetActive(true);
            Heart2.gameObject.SetActive(false);
            Heart3.gameObject.SetActive(false);
        }
        if (StaticHealth.health == 0)
        {
            Debug.Log("Calculation Correct");
            Heart1.gameObject.SetActive(false);
            Heart2.gameObject.SetActive(false);
            Heart3.gameObject.SetActive(false);
            Heart4.gameObject.SetActive(false);
        }
    }
}
