using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Paddle
{
    Vector2 _direction;
    void Start()
    {
       
    }

    void Update()
    {
        var axis = Input.GetAxisRaw("Mouse X");
        if (Input.GetKey(KeyCode.RightArrow) || axis > 0 && Input.GetMouseButton(0)) 
        {
            //_direction = Vector2.right;
            _direction = new Vector2(axis, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || axis < 0 && Input.GetMouseButton(0))
        {
          //  _direction=Vector2.left;
            _direction = new Vector2(axis, 0);
        }
        else
        {
            _direction = Vector2.zero;
        }

    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            rB.AddForce(_direction * speed);
        }
    }
}
