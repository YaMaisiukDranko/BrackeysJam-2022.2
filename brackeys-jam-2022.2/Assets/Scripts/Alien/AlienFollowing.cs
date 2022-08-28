using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AlienFollowing : MonoBehaviour
{
    public float speed = 3f;
    public Transform target;

    public AudioSource audioSource;
    private int randTimeSound;

    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (target != null)
        {
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
            target = null;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.transform;
        }
    }

    IEnumerator audio()
    {
        yield return new WaitForSeconds(randTimeSound);
        audioSource.Play();
        yield return new WaitForSeconds(randTimeSound);
    }
}
