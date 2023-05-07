using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public GameObject teleportLink;
    public GameObject lightControllerLink;
    public GameObject player;
    public int teleportIndex;
    public bool inTrigger = false;
    //public Collider spiderForestCollider;


    // Start is called before the first frame update
    void Start()
    {
        //teleportVectors.Add(new Vector3(-341.850433f, -47.9049988f, -137.041f));

    }

    private void FixedUpdate()
    {
        if (inTrigger == true)
        {
            int i = teleportIndex;
            //Sends player to forest with spiders.
            player.transform.rotation = player.transform.rotation = teleportLink.GetComponent<Teleport>().teleportRotations[i];
            player.transform.position = player.transform.position = teleportLink.GetComponent<Teleport>().teleportVectors[i];
            Debug.Log("Wowsers!");
            if (i == 0)
            {
                lightControllerLink.GetComponent<LightController>().SpiderForestLightChange();
            }
            else
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inTrigger = true;
        }

        else
        {
            Debug.Log("You are not the player, get out");
            other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.up * 100);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
        }
    }

}
