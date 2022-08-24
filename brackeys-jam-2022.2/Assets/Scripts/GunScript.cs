using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GunTypes gunTypes;
    public GunScript gun;

    private float time;
    public float fireRate;
    
    private void Start()
    {
        gun = GetComponent<GunScript>();
    }

    private void Update()
    {
        if (gunTypes.rapidFire == true)
        {
            RapidFire();
        }
        else if (gunTypes.rapidFire == false)
        {
            PistolFire();
        }
    }

    void RapidFire() //Rapid Fire mod
    {
        if (Input.GetButton("Fire1"))
        {
            time += Time.deltaTime;
            float nextTimeToFire = 1 / fireRate;

            if (time >= nextTimeToFire)
            {
                Fire();
                time = 0;
            }
        }
    }

    void PistolFire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }



    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, gun.transform);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * gunTypes.fireForce, ForceMode2D.Impulse);
    }
    
    
}


