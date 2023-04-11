using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //public float _sensitivityX;
    //public float _sensitivityY;
    public float _speedH = 12.0f;
    public float _speedV = 2.0f;
    public float _yaw = 0.0f;
    public float _pitch = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // These lines let the script rotate the player based on the mouse moving
        _yaw += _speedH * Input.GetAxis("Mouse X");
        _pitch -= _speedV * Input.GetAxis("Mouse Y");
        //float _mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * _sensitivityX;
        //float _mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * _sensitivityY;

        //_yRotation += _mouseX;

        //_xRotation -= _mouseY;
        //_xRotation = Mathf.Clamp(_xRotation, -90f. )
    }
}
