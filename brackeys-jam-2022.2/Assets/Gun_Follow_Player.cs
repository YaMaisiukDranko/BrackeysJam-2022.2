using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Follow_Player : MonoBehaviour
{
    public Transform Gun_Follow_Player_Rotate;
    private Transform Gun_Rotator_transform;

    void Start()
    {

        Gun_Rotator_transform = GetComponent<Transform>();

    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Gun_Follow_Player_Rotate.position.x, Gun_Follow_Player_Rotate.position.y, transform.position.z);
    }
}
