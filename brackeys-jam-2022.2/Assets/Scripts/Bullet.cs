using System;
using UnityEngine;

    public class Bullet : MonoBehaviour
    {

        private void Start()
        {
            
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag != "Bullet")
            {
                Destroy(gameObject, 0.1f);
            }

            if (!col.gameObject.CompareTag("Trigger"))
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.tag != "Bullet" || !col.gameObject.CompareTag("Trigger"))
            {
                Destroy(gameObject, 0.1f);
            }
        }

        private void Update()
        {
            Destroy(gameObject, 5f);
        }
    }
