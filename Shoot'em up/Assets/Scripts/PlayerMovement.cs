using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Rigidbody2D _rb;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    [HideInInspector]
    public Vector2 _moveDir;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        InputManagement();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void InputManagement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        _moveDir = new Vector2(moveX, moveY).normalized;

        if (_moveDir.x != 0)
        {
            lastHorizontalVector = _moveDir.x;
        }
        if (_moveDir.y != 0)
        {
            lastVerticalVector = _moveDir.y;
        }
    }
    private void Move()
    {
        _rb.velocity = new Vector2(_moveDir.x * _moveSpeed, _moveDir.y * _moveSpeed);
    }
}
