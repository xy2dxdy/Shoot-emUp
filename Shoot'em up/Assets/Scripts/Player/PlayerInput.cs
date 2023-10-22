using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action OnMoveDirectionChanged;

    public Vector2 MoveDir { get; private set; }

    private void Update()
    {
        MoveDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
