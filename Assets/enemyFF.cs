using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemyFF : MonoBehaviour
{
    public AIPath aipath;
    Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        direction = aipath.desiredVelocity;

        transform.right = direction;
        
    }
}
