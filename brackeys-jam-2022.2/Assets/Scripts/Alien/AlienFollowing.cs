using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienFollowing : MonoBehaviour
{
    public float Alien_speed = 6f;
    public Transform target;

    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        if (target != null)
        {
            float step = Alien_speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            target = null;
        }
        if (col.gameObject.CompareTag("Light"))
        {
            Alien_speed = 3f;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.transform;
        }
        if (other.gameObject.CompareTag("Light"))
        {
            Alien_speed = 6f;
        }
    }

}
