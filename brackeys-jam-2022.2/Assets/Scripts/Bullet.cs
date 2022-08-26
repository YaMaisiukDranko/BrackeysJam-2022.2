using System;
using UnityEngine;

    public class Bullet : MonoBehaviour
    {

        private void Start()
        {
            
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (!col.gameObject.CompareTag("Bullet"))
            {
                Destroy(gameObject);
            }

            if (!col.gameObject.CompareTag("Trigger"))
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.gameObject.CompareTag("Bullet") || !col.gameObject.CompareTag("Trigger"))
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            Destroy(gameObject, 5f);
        }
    }
