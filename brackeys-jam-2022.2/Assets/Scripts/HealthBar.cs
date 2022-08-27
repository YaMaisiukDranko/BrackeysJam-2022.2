using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public Image[] image;
    public int imagesLenght;

    private void Start()
    {
        //Disabling healthbars (dirty code)
        image[0].enabled = false;
        image[1].enabled = false;
        image[2].enabled = false;
        
        healthSlider = GetComponent<Slider>();
    }

    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }

    public void HealthBarShower()
    {
        StartCoroutine(HealthBarShow());
    }

    public IEnumerator HealthBarShow()
    {
        //Enabling/Disabling healthbars (dirty code)
        image[0].enabled = true;
        image[1].enabled = true;
        image[2].enabled = true;
        yield return new WaitForSeconds(1);
        image[0].enabled = false;
        image[1].enabled = false;
        image[2].enabled = false;
    }
    
    
}
