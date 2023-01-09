using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{   
    public float speedPlayer = 8f;
    public Transform targetEnemy;
    public float minDistance;
    Vector2 movement;
    private bool isFaceingRight = true;

    public Rigidbody2D rb;



    void Update()
    {

        // if(Vector2.Distance(transform.position, targetEnemy.position) < minDistance)
        // {
            
        //     transform.position = Vector2.MoveTowards(transform.position, targetEnemy.position, -speedPlayer* Time.deltaTime);

        // }


        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        flip();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speedPlayer * Time.fixedDeltaTime);
        //rb. horizontal = new Vector2(vertical * speedPlayer, rb.velocity.y);
    }

    private void flip()
    {

        if(isFaceingRight && movement.x < 0f || !isFaceingRight && movement.x > 0f )
        {
            isFaceingRight =! isFaceingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
