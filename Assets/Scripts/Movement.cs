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

        Debug.DrawLine(_groundCheck.position, _groundCheck.position + new Vector3(0, -0.1f, 0));
        if (Physics2D.OverlapCircle(_groundCheck.position, 0.1f, _groundLayer) && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody.AddForce(new Vector2(0, _jumpForce));
        }

    }
}
