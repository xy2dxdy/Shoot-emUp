using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponController : WeaponController
{
    GameObject spawnMelee;
    [HideInInspector] public Vector3 offset;

    private Vector3 weaponSize;
    public Vector3 WeaponSize { get => weaponSize; }

    private Vector3 playerSize;
    public Vector3 PlayerSize { get => playerSize; }

    protected override void Start()
    {
        base.Start();
        playerSize = pm.GetComponent<BoxCollider2D>().size;
        weaponSize = weaponData.Prefab.GetComponent<BoxCollider2D>().size;
        offset = new Vector3(playerSize.x / 2, 0, 0) + new Vector3(weaponSize.x / 2, 0, 0);
        spawnMelee = Instantiate(weaponData.Prefab, transform.position + offset, Quaternion.identity);
    }
    protected override void Update()
    {
        base.Update();
        spawnMelee.transform.position = transform.position + offset;
        //spawnMelee.GetComponent<MeleeBehaviour>().DirectionChecker(pm.LastMovedVector);
    }
    protected override void Attack()
    {
        base.Attack(); 
    }
}
