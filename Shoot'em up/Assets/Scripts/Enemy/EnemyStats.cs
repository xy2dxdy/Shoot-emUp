using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public EnemyConfig enemyData;

    private float _currentMoveSpeed;
    private float _currentHealth;
    private float _currentDamage;

    private void Awake()
    {
        _currentMoveSpeed = enemyData.MoveSpeed;
        _currentDamage = enemyData.Damage;
        _currentHealth = enemyData.MaxHealth;  
    }

    public void TakeDamage(float dmg)
    {
        _currentHealth -= dmg;

        if (_currentHealth <= 0)
        {
            Kill();
        }
    }

    private void Kill() 
    {
        Destroy(gameObject);
    }
}
