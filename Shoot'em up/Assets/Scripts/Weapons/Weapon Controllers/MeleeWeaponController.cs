using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponController : WeaponController
{
    GameObject spawnMelee;
    protected override void Start()
    {
        base.Start();
        spawnMelee = Instantiate(weaponData.Prefab);
        spawnMelee.transform.position = transform.position;
    }
    protected override void Update()
    {
        spawnMelee.transform.position = transform.position;
        _currentCooldown -= Time.deltaTime;
        if (_currentCooldown <= 0f && (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2")))
        {
            Attack();
        }
    }
    protected override void Attack()
    {
        base.Attack();
        spawnMelee.transform.position = transform.position;
        spawnMelee.GetComponent<MeleeBehaviour>().DirectionChecker(pm.lastMovedVector);
    }
}
