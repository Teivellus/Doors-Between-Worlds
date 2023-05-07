using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightController : MonoBehaviour
{
    public Light directionalLight;

    // Start is called before the first frame update
    void Start()
    {
        //directionalLight = GetComponent<Light>();
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

    public void SpiderForestLightChange()
    {
        //directionalLight.color = (Color.red / 2.0f) * Time.deltaTime;
        directionalLight.color = new Color(0.3018868f, 0, 0.00936285f);
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
