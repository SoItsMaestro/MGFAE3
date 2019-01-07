using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(StartLoadingScene());
    }
  

IEnumerator StartLoadingScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(StaticHealth.level);
    }
}
