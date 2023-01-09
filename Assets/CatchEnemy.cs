using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchEnemy : MonoBehaviour
{
    public float rotationSpeed;
    public float visionDistance; 
    public float stopRotate = 0f;
       public float minDistance;

    public float speed ;
    public Transform target;
    public GameObject player;

    public LineRenderer lineOfSight;

    void Update()
    {

        lineOfSight.SetPosition(0,transform.position);

        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, visionDistance);

        if(hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineOfSight.SetPosition(1,hitInfo.point );
            lineOfSight.startColor = Color.red;
            lineOfSight.endColor = Color.red;

            if(hitInfo.collider.name == "player")
            {
                while(Vector2.Distance(transform.position, target.position) > minDistance)
                {
                    transform.position = Vector2.MoveTowards(transform.position, target.position, speed* Time.deltaTime);
                    transform.Rotate(Vector3.forward * stopRotate* Time.deltaTime);
        
                 Debug.Log(hitInfo.collider.name);

                }

                
            }
    
        }
        else
        {
             Debug.DrawLine(transform.position, transform.position + transform.right * visionDistance, Color.green);
             lineOfSight.SetPosition(1, transform.position + transform.right * visionDistance);
             lineOfSight.startColor = Color.green;
             lineOfSight.endColor = Color.green;

        }

         
        
    }
}
