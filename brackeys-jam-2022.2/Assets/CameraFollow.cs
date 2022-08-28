using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerTrans;
    public Transform CameraTrans;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        CameraTrans.position = new Vector3(PlayerTrans.position.x,PlayerTrans.position.y,CameraTrans.position.z);
    }
}
