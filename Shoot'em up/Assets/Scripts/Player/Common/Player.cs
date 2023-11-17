using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerExperience _playerExperience;
    [SerializeField] private PlayerHealth _health;
    [SerializeField] private int _enemyLayerID;
    [SerializeField] private PlayerInput _input;
    [SerializeField] private PlayerStateMachine _stateMachine;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != _enemyLayerID)
        {
            return;
        }

        collision.gameObject.TryGetComponent<Enemy>(out var enemy);
        _health.Decrease(enemy.Config.Damage);
    }

    private void Update()
    {
        if(_input.MoveDir != Vector2.zero)
        {
            _stateMachine.SetState(_stateMachine.GetState<PlayerWalkState>());
        }
        if(_input.MoveDir == Vector2.zero)
        {
            _stateMachine.SetState(_stateMachine.GetState<PlayerIdleState>());
        }
    }
}
