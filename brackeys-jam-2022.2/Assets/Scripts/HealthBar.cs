using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public Image[] image;

    private void Start()
    {
        
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
        yield return new WaitForSeconds(1);
        image[2].enabled = true;
        yield return new WaitForSeconds(1);
        image[2].enabled = false;
    }
}
