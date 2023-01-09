using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolEnemy : MonoBehaviour
{
    public float speed;
    public Transform[] patrolPoints;
    public float waitTime;
    int currentPointIndex;
    bool once;

    private void Update()
    {
        if(transform.position != patrolPoints[currentPointIndex].position)
        {

            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed* Time.deltaTime);


        }
        else
        {
            if(once == false)
            {
                Debug.Log("hit");
                once = true;
                StartCoroutine(Wait());
            }
            
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);

        if(currentPointIndex + 1 < patrolPoints.Length)
        {
            currentPointIndex++;
            Debug.Log("hit");
        }
        else
        {
            currentPointIndex = 0;
        }

        once = false;
    }
  
}
