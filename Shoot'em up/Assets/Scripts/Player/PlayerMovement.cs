using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerConfig _config;
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private PlayerInput _input;

    private void FixedUpdate()
    {
        Move();
    }
    
    private void Move()
    {
        _rigidBody.velocity = new Vector2(_input.MoveDir.x * _config.MoveSpeed, _input.MoveDir.y * _config.MoveSpeed);
    }
}
