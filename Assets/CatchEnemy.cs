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
    public float degree;

    public float angle;
    private bool isRotationg ;

    public LineRenderer lineOfSight;

    private void Awake() {
        isRotationg = true;
    }

    void Update()
    {

        lineOfSight.SetPosition(0,transform.position);

        // while(angle < 90)
        // {
        //     angle += 10 * Time.deltaTime;
        //      transform.Rotate(Vector3.forward * angle);

        // }
        if(isRotationg)
        {
            transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotationSpeed, degree) -45);
        }

       

        // if(angle>90)
        // {
             
        //     angle = -90;
        // }
       

        //transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        // StartCoroutine(RotateAroundPivot());

        //transform.rotation = Quaternion.Euler(Vector3.forward * 60);
        //transform.Rotate(Vector3(0, 0, 50));
        

        
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, visionDistance);

        if(hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            lineOfSight.SetPosition(1,hitInfo.point );
            lineOfSight.startColor = Color.red;
            lineOfSight.endColor = Color.red;

            if(hitInfo.collider.name == "player")
            {
                isRotationg = false;
               // while(Vector2.Distance(transform.position, target.position) > minDistance)
                //{
                    transform.position = Vector2.MoveTowards(transform.position, target.position, speed* Time.deltaTime);
                    
                   // transform.Rotate(Vector3.forward * stopRotate* Time.deltaTime);
        
                 Debug.Log(hitInfo.collider.name);

                //}

                
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


//  private IEnumerator RotateAroundPivot()
//  {
//      rotating = true;
//      float rotatedDegrees = 0;
 
//      w$$anonymous$$le (rotatedDegrees <= 90f)
//      {
//          Vector3 rotation = new Vector3(0, -90f, 0);
//          float anglePerFrame = 90 * Time.deltaTime;
//          transform.RotateAround(pivotPoint, rotation, anglePerFrame);
         
//          rotatedDegrees += anglePerFrame;
//          yield return new WaitForEndOfFrame();
//      }
     
//      transform.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, targetRotation, transform.rotation.eulerAngles.z);
//      rotating = false;
//  }
