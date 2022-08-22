using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienHealth : MonoBehaviour
{
    public float alienHeath = 100f;
    public GunScript _gunScript;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            alienHeath -= _gunScript.GunDamage;
        }
    }

    private void Update()
    {
        if (alienHeath <= 0)
        {
            Destroy(gameObject);
        }
    }
}
