using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public GameObject _playerCamLink;
    public GameObject _playerMovementLink;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseTime()
    {
        Time.timeScale = 0;
        _playerCamLink.GetComponent<FirstPersonPlayerCam>().turnSpeed = 0;
        _playerMovementLink.GetComponent<PlayerMovement>().speedH = 0;
    }

    public void ResumeTime()
    {
        Time.timeScale = 1;
        _playerCamLink.GetComponent<FirstPersonPlayerCam>().turnSpeed = 4;
        _playerMovementLink.GetComponent<PlayerMovement>().speedH = 6;

    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
