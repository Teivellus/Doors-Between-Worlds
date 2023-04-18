using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightManager : MonoBehaviour
{
    public float timeTilOn;
    public float timeTilOff;
    public float minTime;
    public float maxTime;
    public bool lightSituation = true;

    // Start is called before the first frame update
    void Start()
    {
        timeTilOff = Random.Range(minTime, maxTime);

    }


    // Update is called once per frame
    void Update()
    {
        if (lightSituation)
        {
            timeTilOff -= Time.deltaTime;
            if (timeTilOff <= 0)
            {
                EventBus.Current.lightOffTrigger();
                lightSituation = !lightSituation;
                timeTilOff = Random.Range(minTime, maxTime);
            }
            else
            {   
            timeTilOff -= Time.deltaTime;
            if (timeTilOn <= 0)
            {
                EventBus.Current.lightOnTrigger();
                lightSituation = !lightSituation;
                timeTilOff = Random.Range(minTime, maxTime);
            }
            }
            
        }
    }
}
