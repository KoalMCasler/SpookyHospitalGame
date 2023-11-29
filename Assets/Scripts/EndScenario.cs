using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScenario : MonoBehaviour
{
    public int waitTime;
    void OnTriggerEnter()
    {
        StartCoroutine(EndGame());
    }
    private IEnumerator EndGame()
    {
        yield return new WaitForSecondsRealtime(waitTime);
        Application.Quit();
    }
}
