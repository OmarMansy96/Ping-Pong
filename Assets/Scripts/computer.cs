using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computer : Paddle
{
   public  Rigidbody2D ball;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (ball.velocity.y > 0.0f)
        {
            if (ball.position.x > transform.position.x)
                rB.AddForce(Vector2.right * speed);
         
            else if (ball.position.x < transform.position.x)
                rB.AddForce(Vector2.left * speed);
        }
        else
        {
            if (transform.position.x > 0.0f)
                rB.AddForce(Vector2.left * speed);
            
            else if (transform.position.x < 0.0f)
                rB.AddForce(Vector2.right * speed);
        }
    }
}
