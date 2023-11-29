using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LightFlicker : MonoBehaviour
{
    public GameObject lightObject;
    private Light lightComp;
    private int lightTimeOff;
    private int maxTimeOff;
    public GameObject lightFixtureOff;
    public GameObject LightFixtureOn;
    // Start is called before the first frame update
    void Start()
    {
        lightComp = lightObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
        StartCoroutine(flickerLights());
    }
    private IEnumerator flickerLights()
    {
        lightTimeOff = Random.Range(0,maxTimeOff);
        lightObject.SetActive(false);
        lightFixtureOff.SetActive(true);
        LightFixtureOn.SetActive(false);
        yield return new WaitForSeconds(lightTimeOff);
        lightFixtureOff.SetActive(false);
        LightFixtureOn.SetActive(true);
        lightObject.SetActive(true);
    }
}
