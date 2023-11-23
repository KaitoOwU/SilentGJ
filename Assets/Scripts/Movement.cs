using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private Transform _groundCheck;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            _rigidBody.velocity = new Vector2(_speed, _rigidBody.velocity.y);
        } else if (Input.GetKey(KeyCode.A))
        {
            _rigidBody.velocity = new Vector2(- _speed, _rigidBody.velocity.y);
        }

        //OUAIS

    }
}
