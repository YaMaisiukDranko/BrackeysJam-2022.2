using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce;
    public GunTypes gunTypes;
    
    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
            //StartCoroutine(GunFire());
        }
    }

   /* IEnumerator GunFire()
    {
        //yield return new WaitForSeconds(1f);
        
        //yield return new WaitForSeconds(0.5f);
    }*/
}


