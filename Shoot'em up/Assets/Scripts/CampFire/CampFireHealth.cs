using System;
using UnityEngine;

public class CampFireHealth : MonoBehaviour, IHealth
{
    [SerializeField] private CampFireConfig _config;

    public event Action OnDecrease;
    public event Action OnIncrease;

    public float Current { get; private set; }

    private void Start()
    {
        Current = _config.MaxHP;
    }

    public void Decrease(float value)
    {
        Current -= value;
        if (Current <= _config.MinHP)
        {
            Current = _config.MinHP;
        }
        OnDecrease?.Invoke();
    }

    public void Increase(float value)
    {
        Current += value;
        if (Current >= _config.MaxHP)
        {
            Current = _config.MaxHP;
        }
        OnIncrease?.Invoke();
    }
}
