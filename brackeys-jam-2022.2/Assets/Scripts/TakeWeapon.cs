using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TakeWeapon : MonoBehaviour
{
    public GunTypes TakeWeaponGunTypes;
    public GunTypes CurrentGunTypes;
    public bool aroundWeapon;
    public GunScript gs;
    public SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = TakeWeaponGunTypes.GunSprite;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Equip weapon");
            
            CurrentGunTypes = GameObject.FindWithTag("Gun").GetComponent<GunScript>().gunTypes;
            CurrentGunTypes = TakeWeaponGunTypes;
            gs.gunTypes = CurrentGunTypes;
        }
        
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You around weapon");
            
            aroundWeapon = true;
        }
        else
        {
            aroundWeapon = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
