using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float _xDirection;
    private float _yDirection;

    public event Action OnMoveDirectionChanged;

    public Vector2 MoveDir { get; private set; }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            OnMoveDirectionChanged?.Invoke();
            _xDirection = Input.GetAxis("Horizontal");
        }
        if (Input.GetButton("Vertical"))
        {
            OnMoveDirectionChanged?.Invoke();
            _yDirection = Input.GetAxis("Vertical");
        }
        MoveDir = new Vector2(_xDirection, _yDirection).normalized;
    }
}
