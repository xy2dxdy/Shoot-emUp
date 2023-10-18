using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private PlayerMovement _playerMovement;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _spriteUp;
    [SerializeField] private Sprite _spriteDown;
    [SerializeField] private Sprite _spriteRight;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        float dx = _playerMovement.moveDir.x;
        float dy = _playerMovement.moveDir.y;
        if (dy == 0 && dx != 0)
        {
            _animator.SetBool("MoveUp", false);
            _animator.SetBool("MoveDown", false);
            SpriteDirectionChecker();
            _animator.SetBool("Move", true);
            
        }
        else if (dx == 0 && dy > 0)
        {
            _animator.SetBool("Move", false);
            _animator.SetBool("MoveDown", false);
            _animator.SetBool("MoveUp", true);
        }
        else if (dx == 0 && dy < 0)
        {
            _animator.SetBool("Move", false);
            _animator.SetBool("MoveUp", false);
            _animator.SetBool("MoveDown", true);
        }
        else if (dx < 0 && dy > 0) // left up
        {
            if (-dx > dy)
            {
                _animator.SetBool("MoveUp", false);
                _animator.SetBool("MoveDown", false);
                SpriteDirectionChecker();
                _animator.SetBool("Move", true);
            }
            else
            {
                _animator.SetBool("MoveUp", false);
                _animator.SetBool("MoveDown", false);
                _animator.SetBool("MoveUp", true);
            }
        }
        else if (dx < 0 && dy < 0)//left down
        {
            if (dx < dy)
            {
                _animator.SetBool("MoveUp", false);
                _animator.SetBool("MoveDown", false);
                SpriteDirectionChecker();
                _animator.SetBool("Move", true);
            }
            else
            {
                _animator.SetBool("Move", false);
                _animator.SetBool("MoveUp", false);
                _animator.SetBool("MoveDown", true);
            }
        }
        else if (dx > 0 && dy > 0)//right up
        {
            if (dx > dy)
            {
                _animator.SetBool("MoveUp", false);
                _animator.SetBool("MoveDown", false);
                SpriteDirectionChecker();
                _animator.SetBool("Move", true);
            }
            else
            {
                _animator.SetBool("Move", false);
                _animator.SetBool("MoveDown", false);
                _animator.SetBool("MoveUp", true);
            }
        }
        else if (dx > 0 && dy < 0)//right down
        {
            if (dx > -dy)
            {
                _animator.SetBool("MoveUp", false);
                _animator.SetBool("MoveDown", false);
                SpriteDirectionChecker();
                _animator.SetBool("Move", true);
            }
            else
            {
                _animator.SetBool("Move", false);
                _animator.SetBool("MoveUp", false);
                _animator.SetBool("MoveDown", true);
            }
        }
        else 
        {
            _animator.SetBool("MoveDown", false);
            _animator.SetBool("MoveUp", false);
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
