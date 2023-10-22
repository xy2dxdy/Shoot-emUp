using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEffect : MonoBehaviour
{
    [SerializeField] private PlayerHealth _health;

    public bool isDead { get; private set; }

    private void OnEnable()
    {
        _health.OnDecrease += DeadCheck;
    }

    private void OnDisable()
    {
        _health.OnDecrease -= DeadCheck;
    }

    private void DeadCheck(int value)
    {
        if (_health.Current <= value)
        {
            isDead = true;
        }
    }
}
