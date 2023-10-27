using System;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStateMachine : MonoBehaviour
{
    private Dictionary<Type, IWeaponState> _behaviours = new();
    private IWeaponState _currentBehaviour;
    private void Awake()
    {
        var _activeBehaviours = GetComponents<IWeaponState>();
        foreach (var behaviour in _activeBehaviours)
        {
            _behaviours.Add(behaviour.GetType(), behaviour);
        }
        SetBehaviour(GetBehaviour<BigAxeState>());
    }

    public void SetBehaviour(IWeaponState newBehaviour)
    {
        _currentBehaviour?.Exit();
        _currentBehaviour = newBehaviour;
        _currentBehaviour.Enter();
    }

    public IWeaponState GetBehaviour<T>() where T : IWeaponState
    {
        var type = typeof(T);
        return _behaviours[type];
    }

    private void FixedUpdate()
    {
        _currentBehaviour.OnUpdate();
    }
}