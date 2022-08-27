using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotate : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 mousePos;
    public Camera cam;
    
    private void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
        Cursor.visible = false;
    }

    private void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); 
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
}
