using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo) //whenever we collide with sg, this next code will be called, other obj needs rigidbody and collider
    {
        if (collisionInfo.collider.tag == "Tree")
        {
            movement.enabled = false;
        }
    }
}
