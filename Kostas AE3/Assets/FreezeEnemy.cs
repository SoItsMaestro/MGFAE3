using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeEnemy : MonoBehaviour
{
    public GameObject Freezeblock;
    public EnemyPatroling MoveScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ability4"))
        {
            MoveScript.enabled = false;          
            StartCoroutine(EnemyFreezing());
        }
    }

    IEnumerator EnemyFreezing()
    {
        yield return new WaitForSeconds(5);
        MoveScript.enabled = true;
    }
}
