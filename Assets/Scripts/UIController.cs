using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    public GameObject _interactText;
    public Slider hpSlider;
    public Image img;
    [SerializeField] private Color color;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateHPBar(float hpValue)
    {
        hpSlider.value = hpValue;
        if (hpValue <= 0)
        {
            StartCoroutine(FadeIn());
        }
    }

    public void InteractPopupActive()
    {
        _interactText.SetActive(true);
    }

    public void InteractPopupInactive()
    {
        _interactText.SetActive(false);
    }

    IEnumerator FadeIn()
    {
        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            color.a = i;
            if (i >= 99.9f)
            {
                color.a = 1f;
            }
            img.color = color;
            yield return null;
        }
    }
}