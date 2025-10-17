using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision: MonoBehaviour
{
    private void OCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}