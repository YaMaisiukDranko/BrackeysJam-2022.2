using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAttack : MonoBehaviour
{
    public int alienDamage;
    public float attackSpeed;
    public float canAttack;
    

    void Attack()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (attackSpeed <= canAttack)
            {
                other.gameObject.GetComponent<PlayerHealth>().TakeDamage(alienDamage);
                canAttack = 0f;
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }
    }
}
