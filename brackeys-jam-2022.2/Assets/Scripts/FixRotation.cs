using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotation : MonoBehaviour
{
    private Quaternion rotation;

    private void Awake()
    {
        rotation = transform.rotation;
    }

    private void LateUpdate()
    {
        transform.rotation = rotation;
    }
}
