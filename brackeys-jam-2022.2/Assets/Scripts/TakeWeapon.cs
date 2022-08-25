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
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You around weapon");
            aroundWeapon = true;
        }
        else if(!other.gameObject.CompareTag("Player"))
        {
            aroundWeapon = false;
        }

        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Equip weapon");
            CurrentGunTypes = gameObject.GetComponent<GunTypes>();
            CurrentGunTypes = TakeWeaponGunTypes;
        }
    }
    
}
