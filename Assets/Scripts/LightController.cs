using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // DontDestroyOnLoad(gameObject);        
        EventBus.Current.lightOn += LightOn;
        EventBus.Current.lightOff += LightOff;
    }

    public void LightOn()
    {
        gameObject.GetComponent<Light>().intensity = 2;
    }

    public void LightOff()
    {
        gameObject.GetComponent<Light>().intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        EventBus.Current.lightOn -= LightOn;
        EventBus.Current.lightOff -= LightOff;
    }
}
