using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    /*
    public LayerMask layersToHit;
    public GunScript gs;
    public GunTypes gt;
    public AlienHealth ahlth;

    private void Update()
    {
        gs = GameObject.FindWithTag("Gun").GetComponent<GunScript>();
        float angle = transform.eulerAngles.z * Mathf.Deg2Rad;
        Vector2 dir = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 50f, layersToHit);
        if (hit.collider == null)
        {
            transform.localScale = new Vector3(50f, transform.localScale.y, 1);
            return;
        }

        transform.localScale = new Vector3(hit.distance, transform.localScale.y, 1);
        Debug.Log(hit.collider.gameObject.name);
        if (hit.collider.tag == "Alien")
        {
            ahlth = hit.collider.gameObject.GetComponent<AlienHealth>();
            ahlth.TakeDamage(gt.damage);
            gs.LaserGun();
        }
    }*/
}
