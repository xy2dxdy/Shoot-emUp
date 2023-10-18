using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimator : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (_playerMovement.moveDir.x != 0 || _playerMovement.moveDir.y != 0)
        {
            if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
            {
            }
            SpriteDirectionChecker();
        }

    }

    private void SpriteDirectionChecker()
    {
        if (_playerMovement.lastHorizontalVector < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else
        {
            _spriteRenderer.flipX = false;
        }
    }
}
