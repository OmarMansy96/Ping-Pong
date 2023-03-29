using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rB;
    public float ballSpeed = 100f;
    private void Awake()
    {
        rB = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
        ResetBall();
    }


   public void ResetBall()
    {
        rB.position = Vector3.zero;
        rB.velocity = Vector3.zero;
       Invoke( "AddStartForce",0.5f);

    }
    void AddStartForce()
    {
        var x = Random.value < 0.5f ? -1f : 1f;
        var y = Random.value < 0.5f ? Random.Range(-1, -0.5f) : Random.Range(0.5f, 1f);
        Vector2 vector = new Vector2(x, y);
        rB.AddForce(vector * ballSpeed);
    }
    public void AddingForce(Vector2 force)
    {
        rB.AddForce(force);
    }
}
