using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private PlayerMovement _playerMovement;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (_playerMovement.moveDir.x != 0 || _playerMovement.moveDir.y != 0)
        {
            _animator.SetBool("Move", true);
            SpriteDirectionChecker();
        }
        else
        {
            _animator.SetBool("Move", false);
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
