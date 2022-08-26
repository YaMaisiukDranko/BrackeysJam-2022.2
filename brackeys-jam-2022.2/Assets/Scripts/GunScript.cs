using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public GunTypes gunTypes;
    public GunScript gun;
    public SpriteRenderer sr;

    private float time;
    
    
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        gun = GetComponent<GunScript>();
        Debug.Log("Weapon: " + gunTypes.name);
        sr.sprite = gunTypes.GunSprite; // Set sprite
        gunTypes.Laser = GameObject.Find("Laser");
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
        else if(gunTypes.shotgun == false && gunTypes.raygun == true)
        {
            RayGun();
        }
        
        sr.sprite = gunTypes.GunSprite;
    }

    void Fire()
    {
        if (gunTypes.shotgun == true)
        {
            for (int i = 0; i < gunTypes.amountOfBullets; i++)
            {
                gunTypes.spread = Random.Range(-1, 1);
                GameObject b = Instantiate(bulletPrefab, firePoint.position + new Vector3(gunTypes.spread,0,0),
                    Quaternion.Euler(0, 0, gunTypes.spread));
                b.GetComponent<Rigidbody2D>().AddForce(firePoint.up * gunTypes.fireForce,ForceMode2D.Impulse);
            }
        }

        else if (gunTypes.shotgun == false && gunTypes.raygun == false)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, gun.transform);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * gunTypes.fireForce, ForceMode2D.Impulse);
        }

        if(gunTypes.raygun == true)
        {
             gunTypes.Laser.SetActive(true);
        }
        else
        {
            gunTypes.Laser.SetActive(false);
        }

        if (gunTypes.rapidFire == true)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, gun.transform);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * gunTypes.fireForce, ForceMode2D.Impulse);
        }
        
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
                Fire();
        }
    }

    void RayGun()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }
    }
    
}


