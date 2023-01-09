using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingEnemy : MonoBehaviour
{


    public float speed ;
    public Transform target;
    public float minDistance;

    public GameObject projectile;
    public float timeBetweenShots;
    private float nextTimeShot;


   
   void Update()
   {

        // if(Time.time > nextTimeShot)
        // {
        //     Instantiate(projectile, transform.position, Quaternion.identity);
        //     nextTimeShot = Time.time + timeBetweenShots;
        // }

        // if(Vector2.Distance(transform.position, target.position) < minDistance)
        // {
            
        //     transform.position = Vector2.MoveTowards(transform.position, target.position, -speed* Time.deltaTime);

        // }
      


   }
}
