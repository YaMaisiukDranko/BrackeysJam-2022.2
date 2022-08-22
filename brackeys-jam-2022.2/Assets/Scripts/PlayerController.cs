using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PlayerController : MonoBehaviour
{
    public GunScript gunScript;
    public Rigidbody2D rb;
    Vector2 mousePosition;
    private Vector2 moveDiretion;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       
    }

    private void FixedUpdate()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            gunScript.Fire();
        }
        
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}
