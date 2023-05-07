using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTransform : MonoBehaviour
{
    public List<bool> doorsOpen = new List<bool>();
    public List<GameObject> doors = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        //frontdoor
        doorsOpen.Add(false);
        //spiderforestdoor
        doorsOpen.Add(false);
        //etc.
        doorsOpen.Add(false);
        doorsOpen.Add(false);
        doorsOpen.Add(false);
        doorsOpen.Add(false);
        doorsOpen.Add(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
