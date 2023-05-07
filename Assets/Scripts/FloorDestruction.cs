using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorDestruction : MonoBehaviour
{
    public GameObject uIControllerLink;
    public GameObject _destructibleFloor;
    public GameObject _hazardsPanel;
    public GameObject _timeControllerLink;
    public bool _hazardPopupSeen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        if (_hazardPopupSeen == false)
        {
            _hazardsPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Destroy(_destructibleFloor.gameObject);
            Debug.Log("Broken!");
            _timeControllerLink.GetComponent<TimeController>().PauseTime();
            _hazardPopupSeen = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
