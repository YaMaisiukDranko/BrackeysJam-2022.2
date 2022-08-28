using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AlienFollowing : MonoBehaviour
{
    public float speed = 3f;
    public Transform target;

    public Animator anim;
    public bool attacking; 

    public float prevX;

    private void Start()
    {
        attacking = false;
        target = GameObject.FindWithTag("Player").transform;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {   
        CheckDirection();
        prevX = transform.position.x;
        if (attacking) {
            anim.Play("Attack");
        }
        if (target != null)
        {
            anim.Play("Run");
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }

        randTimeSound = Random.Range(2, 5);
        StartCoroutine(audio());
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {   
            attacking = true;
            target = null;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            attacking = false;
            target = other.transform;
        }
    }

    private void CheckDirection() {
        if (transform.position.x > prevX) {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        } else if (transform.position.x < prevX) {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
