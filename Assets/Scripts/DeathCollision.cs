using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        EventBus.Current.LosingLife();
        print("Oh no death time. " + EventBus.Current.LosingLife() + " lives remaining");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        print("DIE!");
    }

    // public void EndGame()
    // {

    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}