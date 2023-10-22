using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    [SerializeField] private PlayerConfig _config;
    
    public event Action<int> OnDecrease;
    public event Action OnIncrease;

    public int Current { get; private set; }

    private void Start()
    {
        Current = _config.MaxHP;
    }

    public void Decrease(int value)
    {
        Current -= value;
        if (Current <= _config.MinHP)
        {
            Current = _config.MinHP;
        }
        OnDecrease?.Invoke(_config.MinHP);
    }

    public void Increase(int value)
    {
        Current += value;
        if (Current >= _config.MaxHP)
        {
            Current = _config.MaxHP;
        }
        OnIncrease?.Invoke();
    }

    public void Reload(int value)
    {

    }
}
