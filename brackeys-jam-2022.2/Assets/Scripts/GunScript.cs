using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GunTypes gunTypes;
    public GunScript gun;

    private float time;
    
    
    private void Start()
    {
        gun = GetComponent<GunScript>();
        Debug.Log("Weapon: " + gunTypes.name);
    }

    private void Update()
    {
        if (gunTypes.rapidFire == true && gunTypes.shotgun == false)
        {
            RapidFire();
        }
        else if (gunTypes.rapidFire == false && gunTypes.shotgun == false)
        {
            PistolFire();
        }
        else if (gunTypes.shotgun == true && gunTypes.rapidFire == false)
        {
            Shotgun();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, gun.transform);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * gunTypes.fireForce, ForceMode2D.Impulse);
    }
    
    
    //--------Gun types---------
    void PistolFire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }
    
    void RapidFire() //Rapid Fire mod
    {
        if (Input.GetButton("Fire1"))
        {
            time += Time.deltaTime;
            float nextTimeToFire = 1 / gunTypes.fireRate;

            if (time >= nextTimeToFire)
            {
                Fire();
                time = 0;
            }
        }
    }

    void Shotgun()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            for (int i = 0; i < gunTypes.amountOfBullets; i++)
            {
                GameObject b = Instantiate(bulletPrefab, transform.position, transform.rotation);
                Rigidbody2D rb = b.GetComponent<Rigidbody2D>();
                Vector2 dir = transform.rotation * Vector2.up;
                Vector2 pdir = Vector2.Perpendicular(dir) * Random.Range(-gunTypes.spread, gunTypes.spread);
                rb.velocity = (dir + pdir) * gunTypes.fireForce;
            }
        }
    }
    
}


