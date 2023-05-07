using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggerIndex : MonoBehaviour
{
    public GameObject _nextTeleportLink;
    public GameObject _doorControllerLink;
    public GameObject _uIControllerLink;
    public int buttonIndex;
    public bool open = false;
    public bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks if player is inside a trigger to stop them from opening doors while away from one.
        if (inTrigger == true)
        {
            if (Input.GetKeyDown("e") && open == true)
            {
                Close();
            }
            else if (Input.GetKeyDown("e") && open == false)
            {
                Open();
            }
        }
    }

    //Shows an interactive message
    void OnTriggerEnter(Collider player)
    {
        inTrigger = true; 
        _uIControllerLink.GetComponent<UIController>().InteractPopupActive();
    }

    //Removes an interactive message
    void OnTriggerExit(Collider player)
    {
        inTrigger = false;
        _uIControllerLink.GetComponent<UIController>().InteractPopupInactive();
    }

    //Opens door (need to figure out how to make it open all doors properly, because rotation weird)
    public void Open()
    {
        int i;
        i = buttonIndex;
        _doorControllerLink.GetComponent<DoorTransform>().doorsOpen[i] = true;
        _doorControllerLink.GetComponent<DoorTransform>().doors[i].transform.rotation = new Quaternion(0, 0.707106829f, 0, -0.707106829f);
        open = true;
        if (i != 0)
        {
            _nextTeleportLink.SetActive(true);
        }
    }

    //Closes door (need to figure out how to make it close all doors properly, because rotation weird)
    public void Close()
    {
        int i;
        i = buttonIndex;
        _doorControllerLink.GetComponent<DoorTransform>().doorsOpen[i] = false;
        _doorControllerLink.GetComponent<DoorTransform>().doors[i].transform.rotation = new Quaternion(0, 0, 0, 1);
        open = false;
    }
}
