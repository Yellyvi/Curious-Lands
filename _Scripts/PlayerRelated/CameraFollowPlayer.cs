using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f; //higher the value, faster cam locks on target
    public Vector3 offset;

    void FixedUpdate() //runs right after update, good for cameras
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed); //smoothly goig from point A to point B
        transform.position = smoothedPosition;

        //transform.LookAt(target);
    }
}
