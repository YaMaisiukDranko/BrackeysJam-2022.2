using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class GunTypes : ScriptableObject
{
    public new string name;
    public float shootingSpeed;
    public Sprite GunGameObject;
    public int damage;
    
}
