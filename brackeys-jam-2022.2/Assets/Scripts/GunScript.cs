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

    private void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Invoke("Shoot", 1);
            //StartCoroutine(GunFireDelay());
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        Debug.Log("Fire");
    }
}
