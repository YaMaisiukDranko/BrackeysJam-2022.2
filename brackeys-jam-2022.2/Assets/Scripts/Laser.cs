using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float defDistanceRay = 100;
    public Transform laserFirePoint;
    public LineRenderer m_lineRenderer;
    private Transform _transform;
    private RaycastHit2D hit;
    public LayerMask lm;
    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        ShootLaser();
        CheckForEnemy();
    }

    void ShootLaser()
    {
        if (Physics2D.Raycast(_transform.position, transform.right))
        {
            hit = Physics2D.Raycast(laserFirePoint.position, transform.right, defDistanceRay, lm);
            Draw2DRay(laserFirePoint.position, hit.point);
        }
        else
        {
            Draw2DRay(laserFirePoint.position, laserFirePoint.transform.right * defDistanceRay);
        }
    }

    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        m_lineRenderer.SetPosition(0, startPos);
        m_lineRenderer.SetPosition(1, endPos);
    }

    void CheckForEnemy()
    {
        if (hit)
        {
            Debug.Log("Touch - ALIEN");
        }
        else
        {
            
        }
    }
}