using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   protected Rigidbody2D rB;
    public float speed = 50f;


    private void Awake()
    {
        rB = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
