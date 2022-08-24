using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienHealth : MonoBehaviour
{
    public int alienHealth = 100;
    public GunScript _gunScript;
    public HealthBar healthBar;
    public int maxHealth;
    public GunTypes gunType;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            TakeDamage(gunType.damage);
            healthBar.HealthBarShower();
            Debug.Log("Show HealthBar");
        }
    }

    private void Update()
    {
        if (alienHealth <= 0)
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        alienHealth = maxHealth;
        healthBar.SetHealth(maxHealth);

        healthBar = GetComponentInChildren<HealthBar>();
    }

    void TakeDamage(int damage)
    {
        alienHealth -= damage;
        
        healthBar.SetHealth(alienHealth);
    }
}
