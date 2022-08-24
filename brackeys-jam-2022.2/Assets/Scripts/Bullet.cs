using System;
using UnityEngine;

    public class Bullet : MonoBehaviour
    {
        public GunTypes gunType;
        public GunScript gs;

        private void Start()
        {
            gs = GetComponentInParent<GunScript>();
            gunType = gs.GetComponent<GunTypes>();
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
