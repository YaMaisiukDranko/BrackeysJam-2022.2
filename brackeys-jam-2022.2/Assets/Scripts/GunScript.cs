using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce;
    public float fireDelay;
    public bool fireBool = false;

    public int GunDamage;
    

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fireBool = true;
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        else
        {
            fireBool = false;
        }
    }
}
