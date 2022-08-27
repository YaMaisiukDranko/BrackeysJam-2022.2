using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);

        healthBar = GetComponentInChildren<HealthBar>();
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);//Destroy player
        }
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Get Damage");
        healthBar.HealthBarShower();
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
