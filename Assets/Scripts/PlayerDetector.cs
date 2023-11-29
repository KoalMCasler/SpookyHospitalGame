using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerDetector : MonoBehaviour
{
    public GameObject timeline;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            timeline.GetComponent<PlayableDirector>().Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        
    }
}
