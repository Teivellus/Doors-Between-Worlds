using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersAndButtons : MonoBehaviour
{
    Animator _playerAnimator;
    public GameObject _playerMovementLink;

    // Start is called before the first frame update
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        _playerAnimator = _playerMovementLink.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Press the following keys to make the player character change animations.
        if (Input.GetKeyDown(KeyCode.W))
        {
            //Set the Move Forward Integer
            _playerAnimator.SetInteger("Movement", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            //Breaks the Move Forward Integer
            _playerAnimator.SetInteger("Movement", 11);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Set the Move Backwards Integer
            _playerAnimator.SetInteger("Movement", 2);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            //Break the Move Backwards Integer
            _playerAnimator.SetInteger("Movement", 12);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Set the Move Left Strafe Integer
            _playerAnimator.SetInteger("Movement", 3);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            //Break the Move Left Strafe Integer
            _playerAnimator.SetInteger("Movement", 13);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //Set the Move Right Strafe Integer
            _playerAnimator.SetInteger("Movement", 4);
        }
        if (Input.GetKeyUp(KeyCode.D) || (Input.GetKeyUp(KeyCode.A)))
        {
            //Break the Move Right Strafe Integer
            _playerAnimator.SetInteger("Movement", 14);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Set the Jump Integer
            _playerAnimator.SetInteger("Movement", 5);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Break the Jump Integer
            _playerAnimator.SetInteger("Movement", 15);
        }
    }
}
