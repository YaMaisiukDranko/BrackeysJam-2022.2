using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienHealth : MonoBehaviour
{
    public int alienHealth = 100;
    public GameObject player;
    public HealthBar healthBar;
    public int maxHealth;
    public GunScript gunScript;
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
        gunScript = GameObject.FindWithTag("Gun").GetComponent<GunScript>();
        gunType = gunScript.gunTypes;
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
        player = GameObject.FindWithTag("Player");
    }

    void TakeDamage(int damage)
    {
        alienHealth -= damage;
        
        healthBar.SetHealth(alienHealth);
    }
}
