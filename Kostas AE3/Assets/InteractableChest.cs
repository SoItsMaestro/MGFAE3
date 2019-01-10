using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableChest : MonoBehaviour {

   public  GameObject InteractableObj = null;


    private void Update()
    {
        //if (Input. ("Jump") && InteractableObj)
        {
            //Do somthing with the object
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Interactable"))
        {
            Debug.Log(other.name);
            InteractableObj = other.gameObject;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Interactable"))
        {
            if(other.gameObject == InteractableObj)
            {
                InteractableObj = null;
            }
            
        }
    }
}
