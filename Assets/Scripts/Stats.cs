using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    private float hpValue = 100f;
    public GameObject uiControllerLink;

    // Start is called before the first frame update
    void Start()
    {
        uiControllerLink.GetComponent<UIController>().UpdateHPBar(hpValue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addHp(float healingAmount)
    {
        hpValue += healingAmount;
        updateUI();
    }

    public void removeHp(float damageAmount)
    {
        hpValue -= damageAmount;
        updateUI();
    }

    private void updateUI()
    {
        uiControllerLink.GetComponent<UIController>().UpdateHPBar(hpValue);
    }
}