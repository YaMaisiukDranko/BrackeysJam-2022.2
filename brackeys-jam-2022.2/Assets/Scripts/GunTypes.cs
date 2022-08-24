using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class GunTypes : ScriptableObject
{
    public new string name;
    public float fireRate; //Bullets per second
    public Sprite GunSprite;
    public int damage;
    public int fireForce;
    
    public bool rapidFire;
    public bool shotgun;
}
