using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public float speed;
    Vector3 targetPosition;

    void Start()
    {
        //targetPosition = FindObjectOfType<playerMovement>().transform.position;
        
    }
    
    void Update()
    {
        // transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // if(transform.position == targetPosition)
        // {
        //     Destroy(gameObject);
        // }
    }
 
}
