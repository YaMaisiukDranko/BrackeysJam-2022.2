using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class GunTypes : ScriptableObject
{
    [Header("Gun Settings")]
    public new string name;
    public Sprite GunSprite;
    public int damage;
    public int fireForce;
    public AudioClip shootAudio;
    
    public GameObject bulletPrefab;
    //public SpriteRenderer muzzleFlash;
    public Sprite muzzleFlashSprite;


    [Header("Rifle")]
    public bool rapidFire;
    public float fireRate; //Bullets per second
    
    [Header("Shotgun")]
    public bool shotgun;
    public int amountOfBullets;
    public float spread;

    [Header("RayGun")] 
    public bool raygun;
    public GameObject laser;
}
