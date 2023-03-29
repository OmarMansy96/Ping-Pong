using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncy_surfce : MonoBehaviour
{


   public float increce;

    private void OnCollisionEnter2D(Collision2D others)
    {
        Ball ball = others.gameObject.GetComponent<Ball>();
        if(ball != null)
        {
            Vector2 vector = others.GetContact(0).normal;
            ball.AddingForce(-vector * increce);
        }


    }
}
