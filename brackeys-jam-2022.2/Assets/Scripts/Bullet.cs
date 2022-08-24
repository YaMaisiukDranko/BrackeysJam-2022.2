using System;
using UnityEngine;

    public class Bullet : MonoBehaviour
    {

        private void Start()
        {
            
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            Destroy(gameObject);
        }

        private void Update()
        {
            Destroy(gameObject, 5f);
        }
    }
