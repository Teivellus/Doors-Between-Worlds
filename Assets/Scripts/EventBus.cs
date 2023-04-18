using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour
{
    private static EventBus _current;
    public static EventBus Current {get{ return _current;}}
    private int livesRemaining = 3;
    private string _name = "Teivel";

    public int LosingLife()
    {
        livesRemaining -= 1;
        return livesRemaining;
    }
        // else
        // {
        //     ////Need to show gameover screen and stops player/mouse movement
        //     Debug.Log("There are no lives left.");
        // }
    

    public string getName()
    {
        return name;
    }

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }        
    }

    public event Action lightOn;
    public void lightOnTrigger()
    {
        lightOn();
    }

    public event Action lightOff;
    public void lightOffTrigger()
    {
        lightOff();
    }
}