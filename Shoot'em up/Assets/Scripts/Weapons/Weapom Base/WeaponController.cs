using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("Weapon Stats")]
    public WeaponConfig weaponData;
    protected float _currentCooldown;
    protected PlayerMovement pm;

    virtual protected void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
        _currentCooldown = weaponData.CooldownDuration;
    }
    virtual protected void Update()
    {
        _currentCooldown -= Time.deltaTime;
        if (_currentCooldown <= 0f && (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2")))
        {
            Attack();
        }
    }
    virtual protected void Attack()
    {
        _currentCooldown = weaponData.CooldownDuration;
    }
}
