using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollision : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider player)
    {
        //if(collision.gameObject.tag == "Player")
        //{
            //EventBus.Current.LosingLife();
            //print("Oh no death time. " + EventBus.Current.LosingLife() + " lives remaining");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Ouch!");
        //}
    }

    // public void EndGame()
    // {

    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}